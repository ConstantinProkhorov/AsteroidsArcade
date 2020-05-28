using UnityEngine;
/// <summary>
/// Provides movement direction for UFO.
/// </summary>
public static class UFOMovementDirection
{
    /// <summary>
    /// Returns Vector3(0, Random, 0) based what side of Y-axis provided coordinates are on.
    /// </summary>
    /// <returns></returns>
    public static Vector3 Get(Vector3 position)
    {
        if (position.x == ScreenBorders.Left || position.x == ScreenBorders.Right)
        {
            //right side
            if (position.x > 0)
            {
                return new Vector3(-1, 0, 0);
            }
            //left side
            else /*if (position.x < 0)*/
            {
                return new Vector3(1, 0, 0);
            }
        }
        else
        {
            if (position.x > 0)
            {
                return GetDiagonalDirection(new Vector2(-1, 0));
            }
            else
            {
                return GetDiagonalDirection(new Vector2(1, 0));
            }
        }

    }
    /// <summary>
    /// Returns new Vector2 based on currentDirection.
    /// </summary>
    public static Vector2 GetDiagonalDirection(Vector2 currentDirection)
    {
        Vector2 Direction;
        //going right
        if (currentDirection.x > 0)
        {
            Direction = Random.Range(0, 2) == 0 ? Vector2.one : new Vector2(1, -1);
        }
        //going left
        else /*if (FlightDirection.x < 0)*/
        {
            Direction = Random.Range(0, 2) == 0 ? new Vector2(-1, 1) : new Vector2(-1, -1);
        }
        return Direction;
    }
    /// <summary>
    /// Returns new Vector2 based on currentDirection.
    /// </summary>
    public static Vector2 GetHorizontalDirection(Vector2 currentDirection)
    {
        return currentDirection.x > 0 ? Vector2.right : Vector2.left;
    }
}
