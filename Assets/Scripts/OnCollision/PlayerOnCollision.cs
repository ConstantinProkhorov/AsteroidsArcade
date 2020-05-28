using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Logic on how player ship reacts on collision.
/// </summary>
public class PlayerOnCollision : MonoBehaviour
{
    [SerializeField] private OnInputActionsBehaviour PlayerDestruction = null;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerDestruction.Perform(new InputAction.CallbackContext());
    }
}
