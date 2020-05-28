using UnityEngine;
using System.Collections;
/// <summary>
/// Logic on how projectile reacts on collision.
/// </summary>
public class ProjectileOnCollision : MonoBehaviour
{
    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        //по идеи эту задержку можно убрать, когда начнет работать object pulling
        yield return new WaitForEndOfFrame();
        Destroy(gameObject);
    }
}
