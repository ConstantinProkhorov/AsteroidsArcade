using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Activates InputField on Start().
/// </summary>
public class ActiveInputField : MonoBehaviour
{
	[SerializeField] private InputField mainInputField = null;
	private void Start() => SetActive();
	/// <summary>
	/// Set InputField as active. 
	/// </summary>
	public void SetActive()
	{
		mainInputField.ActivateInputField();
		mainInputField.text = "";
	} 
}
