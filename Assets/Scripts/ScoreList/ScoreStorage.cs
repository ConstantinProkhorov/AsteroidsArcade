using UnityEngine;
/// <summary>
/// Underlying storage for ScriptableObjScoreList subclass. 
/// </summary>
[CreateAssetMenu(fileName = "ScoreStorage", menuName = "ScriptabelObjects/ScoreStorage", order = 4)]
public class ScoreStorage : ScriptableObject
{
    public string[] Keys = new string[ScoreList.Lenght];
    public int[] Values = new int[ScoreList.Lenght];
    /// <summary>
    /// Sorts underlying arrays descending.
    /// </summary>
    public void Sort()
    {
        for (int i = 0; i < ScoreList.Lenght - 1; i++)
        {
            for (int j = 0; j < ScoreList.Lenght - 1; j++)
            {
                if (Values[j] < Values[j + 1])
                {
                    Swap(j, j + 1);
                }
            }
        }
        void Swap(int i, int j)
        {
            int tempInt = Values[j];
            Values[j] = Values[i];
            Values[i] = tempInt;
            string tempString = Keys[j];
            Keys[j] = Keys[i];
            Keys[i] = tempString;
        }
    }
}
