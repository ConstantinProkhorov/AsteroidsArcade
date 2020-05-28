using System.Collections;
using UnityEngine;
/// <summary>
/// Logic for UFO firing.
/// </summary>
public class UFOFire : MonoBehaviour, INeedSoundPlayer
{
    [SerializeField] private UFOSettings Settings = null;
    [SerializeField] private GameObject ProjectilePrefab = null;
    [SerializeField] private GameObject Gun = null;
    private ISoundPlayer SoundPlayer;
    /// <summary>
    /// Set ISoundPlayer for this Behaviour.
    /// </summary>
    public void Set(ISoundPlayer soundPlayer) => SoundPlayer = soundPlayer;
    private void Start() => StartCoroutine(Fire());
    private IEnumerator Fire()
    {
        Vector3 Target = PlayerPosition.Get();
        RotateGun(Target);
        //instansiates projectile with player rotation, so it can just fly forward
        GameObject Projectile = Instantiate(ProjectilePrefab, Gun.transform.position, Gun.transform.rotation);
        Projectile.transform.parent = null;
        SoundPlayer.Play(Sounds.Fire);
        yield return new WaitForSeconds(Settings.MaxFireInterval);
        GetFireInterval();
        StartCoroutine(Fire());
    }
    private float GetFireInterval() => Random.Range(0.0f, Settings.MaxFireInterval);
    private void RotateGun(Vector3 target)
    {
        target = OffsetTarget(target);
        Vector3 direction = target - Gun.transform.position;
        Gun.transform.up = direction;
    }
    private Vector3 OffsetTarget(Vector3 vector)
    {
        Vector2 OffsetTarget = vector;
        OffsetTarget.x = Random.Range(0, 2) == 0 ? vector.x += Settings.AccuracyOffset : vector.x -= Settings.AccuracyOffset;
        OffsetTarget.y = Random.Range(0, 2) == 0 ? vector.y += Settings.AccuracyOffset : vector.y -= Settings.AccuracyOffset;
        return OffsetTarget;
    }
}
