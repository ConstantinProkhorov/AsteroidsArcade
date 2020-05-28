using UnityEngine;
using System;
/// <summary>
/// 
/// </summary>
public interface ISoundPlayer
{
    /// <summary>
    /// 
    /// </summary>
    event Action<float> StartedPlayingSound;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="looped"></param>
    void Play(Sounds sound, bool looped = false);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sound"></param>
    /// <param name="position"></param>
    /// <param name="looped"></param>
    void Play(Sounds sound, Vector3 position, bool looped = false);
}
