using UnityEngine;
/// <summary>
/// Score List which stores top 5 score list using scriptable object.
/// </summary>
public class ScriptableObjScoreList : ScoreList
{   
    [SerializeField] private ScoreStorage TopScore = null;
    /// <summary>
    /// Checks if provided playerScore is greater than any of the values stored in the top 5 list.
    /// </summary>
    public override bool Compare(int playerScore)
    {
        foreach (int score in TopScore.Values)
        {
            if (playerScore > score) return true;
        }
        return false;
    }
    /// <summary>
    /// Returns string[5,2] containing top 5 score and assosiated initials.
    /// </summary>
    public override string[,] Get()
    {
        string[,] result = new string[ScoreList.Lenght, 2];
        for (int i = 0; i < ScoreList.Lenght; i++)
        {
            result[i, 0] = TopScore.Keys[i];
            result[i, 1] = TopScore.Values[i].ToString();
        }
        return result;
    }
    public override void Save(string name, int playerScore)
    {
        //полсе сортировки из списка рекордов всегда будет удалено самое маленькое значение. 
        TopScore.Keys[ScoreList.Lenght - 1] = name; 
        TopScore.Values[ScoreList.Lenght - 1] = playerScore;
        TopScore.Sort();
    }
}
