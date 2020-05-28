using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
/// <summary>
/// Controlls sequence of events when GameScene is loaded.
/// </summary>
public class GameSceneController : MonoBehaviour
{
    //идея рефакторинга состоит в следующем: есть иерархия контроля. Контроллеры управляют модулями. А модули управляют своими пакетами/классами. 
    //иерархия контроля расползается как паучья сеть от единого центра, которым является Controller. Он управляет модулями через интерфейс включения/
    //выключения. Далее модули функционируют автономно. Наверное дерево, всё же лучшая метафора. Идея дерева в том, что узлы не взаимодействуют друг с другом.
    //Единственный способ взаимодействия - это управление старшего узла младшими. Пока с такой историей не до конца ясно как быть с событиями. Если надо
    //подписаться на собитя на одну ступень выше, чем позволено?
    //Может взаимодействия старших узлов друг с другом допустимо?
    //Интерфейс:
    //Этот интерфей плохая абстракция, потому что он абстрагирует неизвестно что. Почти что угодно может быть включено и выключен.
    //С другой стороны поддерживать стандартизованный доступ (то ест одинаковые название через всю игру - это хорошо.
    //interface IControllable
    //{
    //    public void TurnOn(object obj = null);
    //    public void TurnOff();
    //}
    //идея в том, чтобы управляемые классы могли в параметрах принят любой тип данных.
    //есть модули (например астероид), которые после появления функционируют вне иерархии контроля. 
    [Header("Level Parameters:")]
    [SerializeField] private float LevelStartDelay = 2.0f;
    [SerializeField] private DifficultyLevelManager DifficultyLevelManager = null;
    [SerializeField] private GameObject AudioPlayer = null;
    [Header("Controllable Scripts:")]
    [SerializeField] private PlayerIText PlayerIText = null;
    [SerializeField] private EnemyCreator EnemyCreator = null;
    [SerializeField] private PlayerInput PlayerInput = null;
    [Header("Player Data:")]
    [SerializeField] private IntegerVariable PlayerLives = null;
    [SerializeField] private IntegerVariable PlayerScore = null;
    [SerializeField] private string EndSceneName = "EndScene";
    private EnemyTracker EnemyTracker;
    public void Awake()
    {
        PlayerDataReset();
        EnemyTracker = new EnemyTracker();
    }
    IEnumerator Start()
    {
        AudioPlayer.GetComponent<IMusicPlayer>()?.Play(Music.SlowWaveBeat);
        PlayerIText.TurnOn(LevelStartDelay);
        yield return new WaitForSeconds(LevelStartDelay);
        PlayerInput.TurnOn();
        EnemyCreator.SetEnemyTracker(EnemyTracker);
        EnemyCreator.TurnOn(DifficultyLevelManager.GetNext());
        PlayerLives.Changed += () =>
        {
            if (PlayerLives == 0)
            {
                SceneManager.LoadScene(EndSceneName);
            }
        };
        StartCoroutine(EnemiesCheck());
    }
    private void PlayerDataReset()
    {
        PlayerLives.ResetValue();
        PlayerScore.ResetValue();
    }
    private IEnumerator EnemiesCheck()
    {
        yield return new WaitForSeconds(LevelStartDelay);
        if (!EnemyTracker.AreThereEnemies())
        {
            EnemyTracker = new EnemyTracker();
            EnemyCreator.SetEnemyTracker(EnemyTracker);
            EnemyCreator.TurnOn(DifficultyLevelManager.GetNext());
        }
        StartCoroutine(EnemiesCheck());
    }
}
