using UnityEngine;

public class MenuAudioLoop : MonoBehaviour
{
    [SerializeField] private float SoundPlayPause = 0.5f;
    [SerializeField] private AudioSource BackgroundBeat = null;
    void Start()
    {
        InvokeRepeating("PlaySound", 0.0f, SoundPlayPause);
    }
    void PlaySound()
    {
        BackgroundBeat.Play();
    }
}
