using UnityEngine;
/// <summary>
/// Calls different input reaction strategies after getting input from player.
/// Handles input from player on MenuScene in StartSceneState.
/// Concrete strategies are implemented in OnInputActionsBehaviour subclasses.
/// </summary>
//Следуя принципу наименьшего удивления этот код копирует организацию класса PlayerInput.
//Когда подобные вещи сделаны одинакого - это вызывает меньше всего удивления. По крайней мере, я так думаю.
public class StartSceneInput : MonoBehaviour
{
    [Header("Input Strategies:")]
    [SerializeField] private OnInputActionsBehaviour LoadGameScene = null;
    [SerializeField] private OnInputActionsBehaviour HelpText = null;

    private InputMaster MenuInputActions;
    private void Awake()
    {
        MenuInputActions = new InputMaster();
        //Load GameScene.
        MenuInputActions.MenuInputActions.StartGame.performed += LoadGameScene.Perform;
        //Open Help text.
        MenuInputActions.MenuInputActions.HelpScreen.performed += HelpText.Perform;
    }
    private void OnEnable() => MenuInputActions.Enable();
    private void OnDisable()
    {
        MenuInputActions.MenuInputActions.StartGame.performed -= LoadGameScene.Perform;
        MenuInputActions.MenuInputActions.HelpScreen.performed -= HelpText.Perform;
        MenuInputActions.Disable();
    }
}
