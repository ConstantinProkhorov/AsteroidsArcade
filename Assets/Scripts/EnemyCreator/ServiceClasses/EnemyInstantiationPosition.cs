using UnityEngine;
/// <summary>
/// Random spawn position calculator. 
/// </summary>
public static class EnemyInstantiationPosition
{
    /// <summary>
    /// Calculates random spawn position on one of the sceen borders.
    /// Must be parameterised with specific enemy type.
    /// Use EnemyType enum to specify enemy type. 
    /// </summary>
    /// <param name="enemyType">Specifies enemy type using EnemyType enum.</param>
    /// <returns>Random Vector3 coordinates on one of the screen sides depending on the type of the enemy provided.</returns>
    public static Vector3 Get(EnemyType enemyType, float spawnZoneWidth = 2.0f)
    {
        //There are only 5 types of Enemies in the game: BigUFO, SmallUFO and 3 asteroid types.
        //UFOs has its own spawning rules. Spawning rules for asteroids are the same.
        //Big UFO can spawn only on the left or right sides of the screen
        if (enemyType == EnemyType.BigUFO)
        {
            switch (Random.Range(0, 2))
            {
                case 0: return RandomLeftSidePosition();
                case 1: return RandomRightSidePosition();
                default:
                    break;
            }
        }
        //Small UFO can spawn only on screen borders
        if (enemyType == EnemyType.SmallUFO)
        {
            switch (Random.Range(0, 4))
            {
                case 0: return RandomTopSidePosition();
                case 1: return RandomBottomSidePosition();
                case 2: return RandomLeftSidePosition();
                case 3: return RandomRightSidePosition();
                default:
                    break;
            }
        }
        //Asteroids spawn within screen space
        else
        {
            return GetInScreenSpace(spawnZoneWidth);
        }
        return Vector3.zero;
    }
    private static Vector3 GetInScreenSpace(float spawnZoneWidth)
    {
        Vector3 position;
        position.x = GetSelector() == 0 ?
            Random.Range(ScreenBorders.Left, ScreenBorders.Left + spawnZoneWidth)
            : Random.Range(ScreenBorders.Right - spawnZoneWidth, ScreenBorders.Right);
        position.y = GetSelector() == 0 ?
            Random.Range(ScreenBorders.Top - spawnZoneWidth, ScreenBorders.Top)
            : Random.Range(ScreenBorders.Bottom, ScreenBorders.Bottom + spawnZoneWidth);
        position.z = 0;
        return position;
        int GetSelector() => Random.Range(0, 2);
    }
    private static Vector3 RandomTopSidePosition()
    {
        return new Vector3(Random.Range(ScreenBorders.Left, ScreenBorders.Right), ScreenBorders.Top, 0);
    }
    private static Vector3 RandomBottomSidePosition()
    {
        return new Vector3(Random.Range(ScreenBorders.Left, ScreenBorders.Right), ScreenBorders.Bottom, 0);
    }
    private static Vector3 RandomLeftSidePosition()
    {
        return new Vector3(ScreenBorders.Left, Random.Range(ScreenBorders.Bottom, ScreenBorders.Top), 0);
    }
    private static Vector3 RandomRightSidePosition()
    {
        return new Vector3(ScreenBorders.Right, Random.Range(ScreenBorders.Bottom, ScreenBorders.Top), 0);
    }
}
    