using UnityEngine;
/// <summary>
/// Singleton for accessing Player ship's position.
/// </summary>
public class PlayerPosition : MonoBehaviour
{
    private static PlayerPosition Instance { get; set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    /// <summary>
    /// Returns Vector3 position of the player ship.
    /// </summary>
    public static Vector3 Get()
    {
        return Instance.transform.position;
    }
}
