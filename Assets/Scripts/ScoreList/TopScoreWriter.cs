using UnityEngine.UI;
/// <summary>
/// Class for writing top score in the Text field.
/// </summary>
public static class TopScoreWriter 
{
    /// <summary>
    /// Writes provided topScore in the textField
    /// </summary>
    public static void Write(Text textField, string[,] topScore)
    {
        for (int i = 0; i < ScoreList.Lenght; i++)
        {
            if (topScore[i,0].Length != 0)
            {
                textField.text += $"{i + 1}.\t{topScore[i, 1]}\t{topScore[i, 0]}\n";
            }
        }
    }
}
