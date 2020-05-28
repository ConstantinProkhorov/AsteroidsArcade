using System;
using System.Collections;
using UnityEngine;
/// <summary>
/// Core class for EnemyCreator module.
/// Acts as a mediator for other classes of the module. 
/// Uses factory method for instantiating new Enemies. 
/// </summary>
public class EnemyCreator : MonoBehaviour
{
    /// <summary>
    /// This event is fired every time a new enemy is created;
    /// </summary>
    public event Action<GameObject> EnemyCreated;
    [SerializeField] private FactoryList FactoryList = null;
    private DifficultyLevel currentDifficultyLevel;
    private EnemyFactory[] EnemyFactories;
    private int[] StartSpawnChances;
    private int[] IntervalSpawnChances;
    private IEnemyTracker EnemyTracker;
    /// <summary>
    /// Set enemy tracker for this enemy creator. 
    /// <para>If enemy tracker is not set enemy creator would work just fine without it.</para>
    /// </summary>
    /// <param name="enemyTracker">Any class that implements IEnemyTracker.</param>
    public void SetEnemyTracker(IEnemyTracker enemyTracker) => EnemyTracker = enemyTracker;
    /// <summary>
    /// Turns EnemyCreator module on.
    /// Must be parameterised with difficulty level.
    /// Will work until turned off.
    /// </summary>
    public void TurnOn(DifficultyLevel difficultyLevel)
    {
        if (difficultyLevel.Enemies.Length == 0)
        {
            Debug.LogError("No Enemies were provided with the difficulty level.");
            return;
        }
        //получение текущего уровня сложности
        currentDifficultyLevel = difficultyLevel;
        GetFactories();
        RecalculateSpawnChances();
        //проеверяем, нужны ли враги на старте
        if (currentDifficultyLevel.SpawnOnStart)
        {
            //спавним сколько нужно
            SpawnWave(currentDifficultyLevel.NumberToSpawnOnStart, StartSpawnChances);
        }
        //отключаем корутины, которые могли остаться с предыдущего уровня сложности
        StopAllCoroutines();
        //проверяем, нужно ли спавнить врагов по таймеру
        if (currentDifficultyLevel.SpawnAfterStart)
        {
            if (currentDifficultyLevel.SpawnInterval != 0)
            {
                StartCoroutine(IntervalSpawn(currentDifficultyLevel.SpawnInterval));
            }
        }
    }
    /// <summary>
    /// Turn EnemyCreator module off. After this method is called will stop spawning new enemies.
    /// </summary>
    public void TurnOff() => StopAllCoroutines();
    /// <summary>
    /// Creates enemy of enemyType in position. Ignores all restrictions. 
    /// </summary>
    /// <param name="enemyType"></param>
    /// <param name="number"></param>
    //TODO: метод с очень сильными связями. Подумать как ослабить. 
    public void ForceCreate(EnemyType enemyType, Vector3 position)
    {
        GameObject enemy = FactoryList.Get(enemyType).Create(position);
        enemy.GetComponent<DebrisCreator>()?.SetEnemyCreator(this);
        //Добавить врага в трекер.
        EnemyTracker?.Add(enemy);
        EnemyCreated?.Invoke(enemy);
    }
    //получает все имеющиеся в наличии фабрики для удобного к ним доступа.
    private void GetFactories()
    {
        int length = currentDifficultyLevel.Enemies.Length;
        EnemyFactories = new EnemyFactory[length];
        for (int i = 0; i < length; i++)
        {
            EnemyFactories[i] = FactoryList.Get(currentDifficultyLevel.Enemies[i]);
        }
    }
    //приведение введенных шансов к процентным шансам.
    private void RecalculateSpawnChances()
    {
        //TODO: подумать как это можно укоротить. А то два абзаца одинакового текста. 
        int length = currentDifficultyLevel.StartSpawnChance.Length;
        StartSpawnChances = new int[length];
        int[] SpawnChancesInPecents = PercentageCalculator.ToPercents(currentDifficultyLevel.StartSpawnChance);
        int previousValue = 0;
        for (int i = 0; i < length; i++)
        {
            StartSpawnChances[i] = previousValue + SpawnChancesInPecents[i];
            previousValue = StartSpawnChances[i];
        }
        length = currentDifficultyLevel.IntervalSpawnChance.Length;
        IntervalSpawnChances = new int[length];
        SpawnChancesInPecents = PercentageCalculator.ToPercents(currentDifficultyLevel.IntervalSpawnChance);
        previousValue = 0;
        for (int i = 0; i < length; i++)
        {
            IntervalSpawnChances[i] = previousValue + SpawnChancesInPecents[i];
            previousValue = IntervalSpawnChances[i];
        }
    }
    //Создает группу врагов заданного размера на основе процентных шансов переданного в параметре массива.
    private void SpawnWave(int waveSize, int[] spawnChances)
    {
        for (int i = 0; i < waveSize; i++)
        {
            SpawnSingle(spawnChances);
        }
    }
    //Создает одного врага на основе процентных шансов переданного в параметре массива.
    private void SpawnSingle(int[] spawnChances)
    {
        int chance = UnityEngine.Random.Range(1, 101);
        for (int i = 0; i < spawnChances.Length; i++)
        {
            if (chance < spawnChances[i])
            {
                if (IsSpawnAllowed(i))
                {
                    GameObject enemy = EnemyFactories[i].Create();
                    enemy.GetComponent<DebrisCreator>()?.SetEnemyCreator(this);
                    //Добавить врага в трекер.
                    EnemyTracker?.Add(enemy);
                    EnemyCreated?.Invoke(enemy);
                    return;
                }
            }
        }
    }
    //Проверка, разрешен ли спавн для текущего типа врага. 
    private bool IsSpawnAllowed(int index)
    {
        //Разрешен, если:
        //EnemyTracker не подключен.
        if (EnemyTracker == null)
        {
            return true;
        }
        //Настройка максимального количества не задана.
        else if (currentDifficultyLevel.MaxNumber[index] == 0)
        {
            return true;
        }
        //Текущее количество врагов меньше максимально разрешенного. 
        else if (EnemyTracker.EnemiesCount(EnemyFactories[index].EnemyType) < currentDifficultyLevel.MaxNumber[index])
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //Логика для спавна врагов через определенный интервал времени.
    private IEnumerator IntervalSpawn(float interval)
    {
        yield return new WaitForSeconds(interval);
        float NewInterval = currentDifficultyLevel.SpawnInterval;
        if (currentDifficultyLevel.SpawnIntervalStep != 0)
        {
            NewInterval = UnityEngine.Random.Range(0, 1) == 0 ? 
                NewInterval + currentDifficultyLevel.SpawnIntervalStep : NewInterval - currentDifficultyLevel.SpawnIntervalStep;
        }
        SpawnSingle(IntervalSpawnChances);
        StartCoroutine(IntervalSpawn(NewInterval));
    }
}
