using System;
using UnityEngine;
/// <summary>
/// Provides difficulty level settings. 
/// Be extremely carefull, as ALL arrays should be equal in size and will be resized automatically.
/// </summary>
[CreateAssetMenu(fileName = "DifficultyLevel", menuName = "ScriptabelObjects/DifficultyLevel", order = 3)]
public class DifficultyLevel : ScriptableObject
{
    [Tooltip("List of enemies available on this difficulty level. Will trigger error if no enemies are provided.")]
    [SerializeField] private EnemyType[] enemies = default;
    [Header("Level Start Parameters:")]
    [Tooltip("Should enemies be spawned on difficulty level start.")]
    [SerializeField] private bool spawnOnStart = false;
    [Tooltip("How many enemies will be spawned after this difficulte level is enabled.")]
    [SerializeField] private int numberToSpawnOnStart = default;
    [Tooltip("Spawn chances for enemies that will be spawned right after this difficulty level is enabled. Zero will be treated as 1.")]
    [SerializeField] private int[] startSpawnChance = default;
    [Header("After Start Parameters:")]
    [Tooltip("Should enemies be spawned periodically after this difficulty level is enabled.")]
    [SerializeField] private bool spawnAfterStart = false;
    [Tooltip("Spawn chances for enemies that will be spawned periodically after this difficulty level is enabled.")]
    [SerializeField] private int[] intervalSpawnChance = default;
    [Tooltip("Max number that can be present simultaniously on game scene for each type of an enemy. Set it to zero if you want this number to be ignored.")]
    [SerializeField] private int[] maxNumber = default;
    [Tooltip("Interval in seconds at which enemies will be spawned. If set to zero, enemies won't spawn.")]
    [SerializeField] private float spawnInterval = 1.0f;
    [Tooltip("This value will be added or substracted from SpawnInterval. Leave it zero if you want SpawnInterval to be stable.")]
    [Range(0.0f, 3.0f)]
    [SerializeField] private float spawnIntervalStep = 1.0f;
    //Приводит все массивы к одному размеру
    #region Array size сontroll сode
    private int InitialLenght;
    private int[] InitialArrayLenghts;
    private void OnEnable() => SaveArrayLengths();
    private void SaveArrayLengths()
    {
        InitialLenght = enemies.Length;
        InitialArrayLenghts = new int[]
        {
                enemies.Length,
                startSpawnChance.Length,
                intervalSpawnChance.Length,
                maxNumber.Length
        };
    }
    //TODO: есть ли более оптимальный алгоритм. Вообще проверь весь алгоритм, я довольно усталым его писал. 
    //TODO: обеспечить копирование массивов.
    private void OnValidate()
    {
        if (InitialArrayLenghts == null) return;
        //Предполагаем, что изменения длинны массивов не было.
        int newLenght = InitialLenght;
        Array[] Arrays = new Array[]
        {
            enemies,
            startSpawnChance,
            intervalSpawnChance,
            maxNumber
        };
        //Проверяем, была ли изменена длинна массивов. 
        for (int i = 0; i < InitialArrayLenghts.Length; i++)
        {
            if (InitialLenght != Arrays[i].Length)
            {
                newLenght = Arrays[i].Length;
            }
        }
        //Создаем новые массивы, только если длинна какого-то массива менялась. 
        if (newLenght != InitialLenght)
        {
            enemies = new EnemyType[newLenght];
            startSpawnChance = new int[newLenght];
            intervalSpawnChance = new int[newLenght];
            maxNumber = new int[newLenght];
            SaveArrayLengths();
            Debug.LogWarning("Arrays have been resized to match one another.");
        }
    }
    #endregion
    /// <summary>
    /// List of enemies available on this difficulty level.
    /// </summary>
    public EnemyType[] Enemies { get => enemies; }
    /// <summary>
    /// Should enemies be spawned on difficulty level start.
    /// </summary>
    public bool SpawnOnStart { get => spawnOnStart; }
    /// <summary>
    /// How many enemies will be spawned after this difficulte level is enabled.
    /// </summary>
    public int NumberToSpawnOnStart { get => numberToSpawnOnStart; }
    /// <summary>
    /// Spawn chances for enemies that will be spawned right after this difficulty level is enabled.
    /// </summary>
    public int[] StartSpawnChance { get => startSpawnChance; }
    /// <summary>
    /// Should enemies be spawned periodically after this difficulty level is enabled.
    /// </summary>
    public bool SpawnAfterStart { get => spawnAfterStart; }
    /// <summary>
    /// Spawn chances for enemies that will be spawned periodically after this difficulty level is enabled.
    /// </summary>
    public int[] IntervalSpawnChance { get => intervalSpawnChance; }
    /// <summary>
    /// Max number that can be present simultaniously on game scene for each type of an enemy.
    /// <para>Set it to 0 if you want this number to be ignored.</para>
    /// </summary>
    public int[] MaxNumber { get => maxNumber; }
    /// <summary>
    /// Interval in seconds at which enemies will be spawned.
    /// </summary>
    public float SpawnInterval { get => spawnInterval; }
    /// <summary>
    /// This value will be added or substracted from SpawnInterval. Leave it zero if you want SpawnInterval to be stable.
    /// </summary>
    public float SpawnIntervalStep { get => spawnIntervalStep; }
}
