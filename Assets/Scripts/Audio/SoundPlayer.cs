using System;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class SoundPlayer : MonoBehaviour, ISoundPlayer
{
    [SerializeField] private AudioSource AudioSource = null;
    [SerializeField] private AudioList AudioList = null;
    private float LoopTime;
    /// <summary>
    /// 
    /// </summary>
    public event Action<float> StartedPlayingSound;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="looped"></param>
    public void Play(Sounds sound, bool looped = false) => Play(sound, Vector3.zero, looped);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="position"></param>
    /// <param name="looped"></param>
    public void Play(Sounds sound, Vector3 position, bool looped = false)
    {
        AudioSource.transform.position = position;
        AudioClip clip = AudioList.GetSound(sound);
        StartedPlayingSound?.Invoke(clip.length);
        AudioSource.PlayOneShot(clip);
        AudioSource.transform.position = Vector3.zero;
    }
}
