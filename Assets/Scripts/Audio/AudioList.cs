using UnityEngine;
/// <summary>
/// Access to audio clips assosiated with Music and Sounds enums.
/// </summary>
public class AudioList : MonoBehaviour
{
    [SerializeField] private MusicAsset[] MusicAssets = null;
    [SerializeField] private SoundsAsset[] SoundsAssets = null;
    /// <summary>
    /// Returns AudioClip assosiated with provided Music enum member.
    /// </summary>
    public AudioClip GetMusic(Music music)
    {
        foreach (MusicAsset item in MusicAssets)
        {
            if (item.Music == music)
            {
                return item.Clip;
            }
        }
        Debug.LogError(music + " not found.");
        return null;
    }
    /// <summary>
    /// Returns AudioClip assosiated with provided Sounds enum member.
    /// </summary>
    public AudioClip GetSound(Sounds sound)
    {
        foreach (SoundsAsset item in SoundsAssets)
        {
            if (item.Sound == sound)
            {
                return item.Clip;
            }
        }
        Debug.LogError(sound + " not found.");
        return null;
    }
    [System.Serializable]
    private class MusicAsset
    {
        public Music Music = Music.No;
        public AudioClip Clip = null;
    }
    [System.Serializable]
    private class SoundsAsset
    {
        public Sounds Sound = Sounds.No;
        public AudioClip Clip = null;
    }
}
