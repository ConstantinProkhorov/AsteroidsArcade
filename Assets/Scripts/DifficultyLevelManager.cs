using UnityEngine;
/// <summary>
/// Logic for providing link to the next difficulty level.
/// </summary>
public class DifficultyLevelManager : MonoBehaviour
{
    [SerializeField] private DifficultyLevel[] DifficultyLevels = null;
    private int Index = 0;
    /// <summary>
    /// Returns the link to the next DifficultyLevel. Upon reaching the last one always returns it.  
    /// </summary>
    public DifficultyLevel GetNext()
    {
        DifficultyLevel result = DifficultyLevels[Index];
        if (Index < DifficultyLevels.Length - 1)
        {
            Index++;
        }
        if (result == null)
        {
            Debug.LogError("Missing " + result.name + "in " + this.name);
        }
        return result;
    }
    /// <summary>
    /// Resets counter and object will return first difficulty level on next GetNext() call.
    /// </summary>
    public void Reset() => Index = 0;
}
