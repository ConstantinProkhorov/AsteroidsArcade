/// <summary>
/// Check entered name.
/// </summary>
public static class CheckName
{
    /// <summary>
    /// Checks entered name.
    /// </summary>
    /// <param name="name">String to check.</param>
    /// <returns>True if name length is 3 and it contains 3 letters.</returns>
    public static bool Check(string name)
    {
        if (name.Length != 3)
        {
            return false;
        }
        foreach (char letter in name)
        {
            if (!char.IsLetter(letter))
            {
                return false;
            }
        }
        return true;      
    }
}
