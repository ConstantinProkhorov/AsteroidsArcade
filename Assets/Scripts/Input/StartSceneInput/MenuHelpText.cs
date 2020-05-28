using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
/// <summary>
/// Strategy for showing help text.
/// </summary>
public class MenuHelpText : OnInputActionsBehaviour
{
    [Header("Help Texts:")]
    [SerializeField] private Text HelpText = null;
    [SerializeField] private Text PressF1Text = null;
    public override void Perform(InputAction.CallbackContext context)
    {
        if (!HelpText.enabled)
        {
            PressF1Text.enabled = false;
            HelpText.enabled = true;
        }
        else
        {
            PressF1Text.enabled = true;
            HelpText.enabled = false;
        }
    }
}
