using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    //[SerializeField] private float SoundPlayPause = 0.8f;
    //[SerializeField] private float MuteDuration = 1.0f;
    //[Header("Objects for event subscription:")]
    //[SerializeField] private PlayerFire PlayerFire = null;
    //[SerializeField] private PlayerThrust PlayerThrust = null;
    //[Header("Audio sources:")]
    //[SerializeField] private AudioSource BackgroundBeat = null;
    //[SerializeField] private AudioSource Fire = null;
    //[SerializeField] private AudioSource Thrust = null;
    //[SerializeField] private AudioSource Bang = null;
    //void Start()
    //{
    //    PlayerFire.GunFired += () =>
    //    {
    //        Fire.Play();
    //        StartCoroutine(MuteBackgroundSound());
    //    };
    //    PlayerThrust.ThrustStarted += () =>
    //    {
    //        Thrust.Play();
    //        StartCoroutine(MuteBackgroundSound());
    //    };
    //    //subscribes to event of destruction of an asteroid, triggers bang sound
    //    //AsteriodFactory.EnemyCreated += (GameObject asteroid) =>
    //    //{
    //    //    asteroid.GetComponent<EnemyOnCollision>().EnemyDestroyed += (int i) =>
    //    //    {
    //    //        Bang.Play();
    //    //        StartCoroutine(MuteBackgroundSound());
    //    //    };
    //    //};
    //    InvokeRepeating("PlaySound", 0.0f, SoundPlayPause);
    //}
    //private void PlaySound()
    //{
    //    BackgroundBeat.Play();
    //}
    //private IEnumerator MuteBackgroundSound()
    //{
    //    CancelInvoke();
    //    yield return new WaitForSeconds(MuteDuration);
    //    if (!IsInvoking("PlaySound"))
    //    {
    //        InvokeRepeating("PlaySound", 0.0f, SoundPlayPause);
    //    }
    //}
}
