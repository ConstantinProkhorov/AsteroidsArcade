using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Implements strategy for firing gun.
/// </summary>
public class PlayerFire : OnInputActionsBehaviour, INeedSoundPlayer
{
    [SerializeField] private GameObject ProjectilePrefab = null;
    [SerializeField] private GameObject Gun = null;
    private ISoundPlayer SoundPlayer;
    /// <summary>
    /// Set ISoundPlayer for this Behaviour.
    /// </summary>
    public void Set(ISoundPlayer soundPlayer) => SoundPlayer = soundPlayer;
    public override void Perform(InputAction.CallbackContext context)
    {
        //instansiates projectile with player rotation, so it can just fly forward
        GameObject Projectile = Instantiate(ProjectilePrefab, Gun.transform.position, gameObject.transform.rotation);
        Projectile.transform.parent = null;
        SoundPlayer.Play(Sounds.Fire);
    }
}