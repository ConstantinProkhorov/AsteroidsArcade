using UnityEngine;
/// <summary>
/// Provides movement direction for asteriods.
/// </summary>
public static class AsteroidMovementDirection
{
    /// <summary>
    /// Calculates enemy movement direction based on what quadrant the enemy have been spawned in.
    /// Must be parameterised with enemy spawning position.
    /// </summary>
    /// <param name="position">Use Vector3 coordinates to specify enemy location. </param>
    /// <returns>Vector3 direction.</returns>
    public static Vector3 Get(Vector3 position)
    {
        // quadrant I
        if (position.x > 0 & position.y > 0)
        {
            return new Vector3(Random.Range(-1.0f, -0.5f), -1, 0);
        }
        // quadrant II
        else if (position.x < 0 & position.y > 0)
        {
            return new Vector3(Random.Range(0.5f, 1.0f), -1, 0);
        }
        // quadrant III
        else if (position.x < 0 & position.y < 0)
        {
            return new Vector3(Random.Range(0.5f, 1.0f), 1, 0);
        }
        // quadrant IV
        else /*if (position.x > 0 & position.y < 0)*/
        {
            return new Vector3(Random.Range(-1.0f, -0.5f), 1, 0);
        }
    }
    /// <summary>
    /// Returns random Vector3.
    /// </summary>
    public static Vector3 GetRandom()
    {
        return new Vector3(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), 0);
    }
}
