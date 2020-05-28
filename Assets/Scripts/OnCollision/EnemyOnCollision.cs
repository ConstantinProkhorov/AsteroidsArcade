using UnityEngine;
/// <summary>
/// Logic on how Enemies react on collision.
/// </summary>
public class EnemyOnCollision : MonoBehaviour, INeedSoundPlayer
{
    [SerializeField] private EnemyInfo Info = null;
    [SerializeField] private ParticleSystem DestructionEffect = null;
    [SerializeField] private Sounds DestructionSound = Sounds.No;
    [SerializeField] private IntegerVariable PlayerScore = null;
    [Tooltip("Leave this field empty if it is not needed.")]
    [SerializeField] private DebrisCreator DebrisCreator = null;
    private ISoundPlayer SoundPlayer;
    /// <summary>
    /// Set ISoundPlayer for this Behaviour.
    /// </summary>
    public void Set(ISoundPlayer soundPlayer) => SoundPlayer = soundPlayer;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DebrisCreator?.Create();
        SoundPlayer.Play(DestructionSound);
        //начисление очков за сбитого врага
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerScore += Info.ScoreToGain;
        }
        //процедура уничтожения астероида
        Instantiate(DestructionEffect, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}

