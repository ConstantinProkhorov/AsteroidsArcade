using UnityEngine;
/// <summary>
/// Controlls sequence of events when StartScene is loaded.
/// </summary>
public class StartSceneController : MonoBehaviour
{
    [SerializeField] private EnemyCreator EnemyCreator = null;
    [SerializeField] private DifficultyLevelManager DifficultyLevelManager = null;
    [SerializeField] private GameObject AudioPlayer = null;
    private void Start()
    {
        AudioPlayer.GetComponent<IMusicPlayer>()?.Play(Music.SlowWaveBeat);
        EnemyCreator.TurnOn(DifficultyLevelManager.GetNext());
    }
}
