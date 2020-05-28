/// <summary>
/// Interface for objects who need ISoundPlayer to play sounds.
/// </summary>
public interface INeedSoundPlayer 
{
    /// <summary>
    /// Set ISoundPlayer for this Behaviour.
    /// </summary>
    void Set(ISoundPlayer soundPlayer);
}
