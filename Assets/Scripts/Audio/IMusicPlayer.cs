/// <summary>
/// Interface for playing music.
/// </summary>
public interface IMusicPlayer
{
    /// <summary>
    /// Starts playing music.
    /// </summary>
    /// <param name="sound">Use Music enum to specify which music track should be played.</param>
    void Play(Music music);
    /// <summary>
    /// Stop playing music if it is playing.
    /// </summary>
    void Pause();
    /// <summary>
    /// Resume playing music.
    /// </summary>
    void Resume();
}
