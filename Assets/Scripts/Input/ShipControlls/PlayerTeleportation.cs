using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Implements strategy for player teleportation
/// </summary>
public class PlayerTeleportation : OnInputActionsBehaviour
{
    [SerializeField] private ControllsSettings ControllsSettings = null;
    private (float Top, float Bottom, float Left, float Right) TeleportationBorders;
    private Transform PlayerShip;
    public void Start()
    {
        float deadZone = ControllsSettings.TeleportationDeadZone;
        TeleportationBorders = 
            (ScreenBorders.Top - deadZone, ScreenBorders.Bottom + deadZone, 
            ScreenBorders.Left + deadZone, ScreenBorders.Right - deadZone);
        PlayerShip = gameObject.transform.parent;
    }
    public override void Perform(InputAction.CallbackContext context)
    {
        PlayerShip.position = CalculateNewPosition();           
    }
    private Vector3 CalculateNewPosition()
    {
        return new Vector3(
            Random.Range(TeleportationBorders.Left, TeleportationBorders.Right), 
            Random.Range(TeleportationBorders.Bottom, TeleportationBorders.Top), 
            0);
    }
}
