using UnityEngine;
/// <summary>
/// Interface for module working with top 5 scores. 
/// </summary>
public abstract class ScoreList : MonoBehaviour
{
    /// <summary>
    /// Constant representing lenght of ScoreList.
    /// </summary>
    public const int Lenght = 5;
    /// <summary>
    /// Checks if provided playerScore is greater than any of the values stored in the top 5 list.
    /// </summary>
    public abstract bool Compare(int playerScore);
    /// <summary>
    /// Returns string[5,2] containing top 5 score and assosiated initials.
    /// </summary>
    public abstract string[,] Get();
    /// <summary>
    /// Saves player score and name in the underlying storage.
    /// </summary>
    /// <param name="name">Player initials.</param>
    /// <param name="playerScore">Player score.</param>
    public abstract void Save(string name, int playerScore);
}
