using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
/// <summary>
/// Strategy for loading GameScene.
/// </summary>
public class SceneLoadOnInput : OnInputActionsBehaviour
{
    [SerializeField] private string GameSceneName = "GameScene";
    public override void Perform(InputAction.CallbackContext context) => SceneManager.LoadScene(GameSceneName);
}
