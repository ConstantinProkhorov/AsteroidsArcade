using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Displays current player score.
/// Utilises scriptable object.
/// Updates on event.
/// </summary>
public class ScoreTextUpdater : MonoBehaviour
{
    [SerializeField] private Text[] ScoreText = null;
    [SerializeField] private IntegerVariable PlayerScore = null;
    private void Start()
    {
        PlayerScore.Changed += ChangeText;
        ChangeText();
    }
    private void ChangeText()
    {
        foreach (var item in ScoreText)
        {
            item.text = PlayerScore.ToString();
        }
    }
}
