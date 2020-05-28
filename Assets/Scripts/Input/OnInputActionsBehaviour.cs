using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Provides interface for classes reacting on input
/// </summary>
public abstract class OnInputActionsBehaviour : MonoBehaviour
{
    /// <summary>
    /// Concrete behaviours are specified in subclasses. 
    /// For subscribtion to Input Action started event.
    /// </summary>
    /// <param name="context">InputAction.CallbackContext</param>
    public abstract void Perform(InputAction.CallbackContext context);
}