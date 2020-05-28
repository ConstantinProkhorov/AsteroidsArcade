using UnityEngine;
/// <summary>
/// Assigns ISoundPlayer to classes implementing INeedSoundPlayer intrface.
/// </summary>
public class SoundPlayerProvider : MonoBehaviour
{
    [SerializeField] private EnemyCreator EnemyCreator = null;
    [SerializeField] private GameObject Player = null;
    [SerializeField] private SoundPlayer SoundPlayer = null;
    private void Start()
    {
        EnemyCreator.EnemyCreated += SetSoundPlayer;
        SetSoundPlayer(Player);
    }
    private void SetSoundPlayer(GameObject providedObject)
    {
        INeedSoundPlayer[] behaviours = providedObject.GetComponentsInChildren<INeedSoundPlayer>();
        foreach (INeedSoundPlayer item in behaviours)
        {
            item.Set(SoundPlayer);
        }
    }
}
