using System.Collections;
using UnityEngine;
/// <summary>
/// Logic of player respawn.
/// </summary>
public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private PlayerInput PlayerInput = null;
    [SerializeField] private Collider2D PlayerCollider = null;
    [SerializeField] private Rigidbody2D PlayerRigidBody = null;
    [SerializeField] private Transform PlayerTransform = null;
    private float RespawnDelay = 1.0f;
    private float ColliderReactivationDelay = 1.0f;
    /// <summary>
    /// Removes the player and disables its collider.
    /// After a delay puts player back.
    /// Player collider is disabled for longer.
    /// </summary>
    /// <param name="player">Player GameObject</param>
    public void DestroyAndRespawn()
    {
        HidePlayer();
        PlayerInput.TurnOff();
        StartCoroutine(RespawnPlayer());
    }
    private void HidePlayer()
    {
        PlayerCollider.enabled = false;
        PlayerTransform.localScale = Vector3.zero;
        //сброс действующих на игрока сил
        PlayerRigidBody.velocity = Vector3.zero;
        PlayerRigidBody.angularVelocity = 0.0f;
    }
    private IEnumerator RespawnPlayer()
    {
        yield return new WaitForSeconds(RespawnDelay);
        PlayerTransform.position = Vector3.zero;
        PlayerTransform.localScale = Vector3.one;
        PlayerTransform.eulerAngles = Vector3.zero;
        PlayerInput.TurnOn();
        //включение коллайдера происходит через время после возрождения.
        yield return new WaitForSeconds(ColliderReactivationDelay);
        PlayerCollider.enabled = true;
    }
}
