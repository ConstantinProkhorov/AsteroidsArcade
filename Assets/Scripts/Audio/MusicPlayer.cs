using UnityEngine;
/// <summary>
/// Class for playing music.
/// </summary>
public class MusicPlayer : MonoBehaviour, IMusicPlayer
{
    [SerializeField] private float LoopTime = 0.1f;
    [SerializeField] private AudioSource AudioSource = null;
    [SerializeField] private AudioList AudioList = null;
    private bool IsPaused = false;
    /// <summary>
    /// Starts playing music.
    /// </summary>
    /// <param name="sound">Use Music enum to specify which music track should be played.</param>
    public void Play(Music music)
    {
        AudioSource.clip = AudioList.GetMusic(music);
        if (LoopTime < AudioSource.clip.length)
        {
            LoopTime = AudioSource.clip.length;
        }
        PlayInLoop();
    }
    /// <summary>
    /// Stop playing music if it is playing.
    /// </summary>
    public void Pause()
    {
        if (IsInvoking())
        {
            CancelInvoke();
        }
        IsPaused = true;
    }
    /// <summary>
    /// Resume playing music.
    /// </summary>
    public void Resume()
    {
        if (IsPaused)
        {
            PlayInLoop();
            IsPaused = false;
        }
        else Debug.LogError("Music was not paused. To start playing music use MusicPlayer.Play(Music music).");
    }
    private void PlayInLoop() => InvokeRepeating(nameof(MusicLoop), LoopTime, LoopTime);
    private void MusicLoop() => AudioSource.Play();
}
