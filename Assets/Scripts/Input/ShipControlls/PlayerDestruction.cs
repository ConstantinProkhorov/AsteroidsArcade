using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Implements strategy for player selfdestruction.
/// </summary>
public class PlayerDestruction : OnInputActionsBehaviour
{
    [SerializeField] private PlayerRespawn PlayerRespawn = null;
    [SerializeField] private IntegerVariable PlayerLives = null;
    [SerializeField] private ParticleSystem DestructionEffect = null;
    public override void Perform(InputAction.CallbackContext context)
    {
        PlayerLives--;
        Instantiate(DestructionEffect, gameObject.transform.position, Quaternion.identity);
        PlayerRespawn.DestroyAndRespawn();
    }
}
