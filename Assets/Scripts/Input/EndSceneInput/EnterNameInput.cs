using UnityEngine;
/// <summary>
/// Calls different input reaction strategies after getting input from player.
/// Handles input from player on EndScene in EnterName state.
/// Concrete strategies are implemented in OnInputActionsBehaviour subclasses.
/// </summary>
public class EnterNameInput : MonoBehaviour
{
    [Header("Input Strategies:")]
    [SerializeField] private OnInputActionsBehaviour EnterName = null;
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
        EndScoreInputActions.EnterNameInput.EnterName.performed += EnterName.Perform;
        EndScoreInputActions.EnterNameInput.LeaveScene.performed += LeaveScene.Perform;
    }
    private void OnDisable()
    {
        EndScoreInputActions.EnterNameInput.EnterName.performed -= LeaveScene.Perform;
        EndScoreInputActions.EnterNameInput.LeaveScene.performed -= LeaveScene.Perform;
    }
}
