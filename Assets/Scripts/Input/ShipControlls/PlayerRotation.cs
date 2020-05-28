using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Implements strategy for player rotation.
/// </summary>
public class PlayerRotation : OnInputActionsBehaviour
{
    [SerializeField] private ControllsSettings ControllsSettings = null;
    private float RotationDirection;
    private bool ButtonIsPressed = false;
    private Transform PlayerShip;
    //в системе ввода настроена реакция на нажатие и отпускание кнопки. 
    //в этом случае событие performed срабатывает 2 раза: при нажатии кнопки и отпускании. 
    //следовательно все время, пока кнопка нажата, в методе Update производится вращение игрока в направлении, 
    //переданном из контекста. 
    private void Start()
    {
        PlayerShip = gameObject.transform.parent;
    }
    public override void Perform(InputAction.CallbackContext context)
    {
        RotationDirection = context.ReadValue<float>();
        ButtonIsPressed = !ButtonIsPressed;
    }
    private void Update()
    {
        if (ButtonIsPressed)
        {
            PlayerShip.Rotate(0, 0, RotationDirection * ControllsSettings.RotationSensetivity * Time.fixedDeltaTime);
        }
    }
}
