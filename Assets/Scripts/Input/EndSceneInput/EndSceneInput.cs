using UnityEngine;
/// <summary>
/// Calls different input reaction strategies after getting input from player.
/// Handles input from player on EndScene in NoRecord and Record states.
/// Concrete strategies are implemented in OnInputActionsBehaviour subclasses.
/// </summary>
public class EndSceneInput : MonoBehaviour
{
    [Header("Input Strategies:")]
    [SerializeField] private OnInputActionsBehaviour LeaveScene = null;
    private InputMaster EndScoreInputActions;
    /// <summary>
    /// Turn controlls on.
    /// </summary>
    public void TurnOn() => EndScoreInputActions.Enable();
    /// <summary>
    /// Turn controlls off.
    /// </summary>
    public void TurnOff() => EndScoreInputActions.Disable();
    private void Awake()
    {
        EndScoreInputActions = new InputMaster();
        //Reload menu scene.
        EndScoreInputActions.EndSceneInput.LeaveScene.performed += LeaveScene.Perform;
    }
    private void OnDisable()
    {
        EndScoreInputActions.EndSceneInput.LeaveScene.performed -= LeaveScene.Perform;
    }
}
