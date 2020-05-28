using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
/// <summary>
/// Controlls sequence of events when EndScene is loaded.
/// Acts is mediator for all the module in the scene.
/// </summary>
public class EndSceneController : OnInputActionsBehaviour
{
    //TODO: привести все Input к единому интерфейсу.
    [SerializeField] private IntegerVariable PlayerScore = null;
    [SerializeField] private ScoreList ScoreList = null;
    [Header("Scene Texts:")]
    [SerializeField] private GameObject NoRecordTexts = null;
    [SerializeField] private GameObject EnterNameTexts = null;
    [SerializeField] private InputField NameInputField = null;
    [SerializeField] private GameObject RecordTexts = null;
    [SerializeField] private Text RecordTable = null;
    [Header("Scene Inputs:")]
    [SerializeField] private EndSceneInput EndSceneInput = null;
    [SerializeField] private EnterNameInput EnterNameInput = null;
    [Header("For Testing:")]
    [SerializeField] private bool NameState = false;
    private void Start()
    {
        if (ScoreList.Compare(PlayerScore) | NameState)
        {
            EnterNameState();
        }
        else
        {
            EnterNoRecordState();
        }
    }
    private void EnterNoRecordState()
    {
        NoRecordTexts.SetActive(true);
        EndSceneInput.TurnOn();
    }
    private void EnterNameState()
    {
        EnterNameTexts.SetActive(true);
        EnterNameInput.TurnOn();
    }
    private void EnterRecordState()
    {
        RecordTexts.SetActive(true);
        EndSceneInput.TurnOn();
        TopScoreWriter.Write(RecordTable, ScoreList.Get());
    }
    private void ExitNameState()
    {
        EnterNameTexts.SetActive(false);
        EnterNameInput.TurnOff();
    }
    public override void Perform(InputAction.CallbackContext context)
    {
        //Проверка правильности ввода.
        if (CheckName.Check(NameInputField.text))
        {
            ExitNameState();
            //запись данных в таблицу рекордов.
            ScoreList.Save(NameInputField.text, PlayerScore);
            EnterRecordState();
        }
        else
        {
            //Возврат к вводу, при провале проверки.
            NameInputField.GetComponent<ActiveInputField>().SetActive();
        }
    }
}
