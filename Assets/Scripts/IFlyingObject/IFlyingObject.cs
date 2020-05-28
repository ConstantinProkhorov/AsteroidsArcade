using UnityEngine;
/// <summary>
/// Interface for interacting with IFlyingObject Behaviours.
/// </summary>
public interface IFlyingObject
{
    /// <summary>
    /// Sets flight speed and direction of this object.
    /// SpeedMultiplier is used for difficulty level.
    /// </summary>
    /// <param name="direction">Direction is applied using RigidBode2D.MovePosition()</param>
    /// <param name="speedMultiplier">Speed is calculated: EnemyInfo.BaseSpeed * speedMultiplier. It is optional parameter with default value of 1.</param>
    void SetFlightParameters(Vector2 direction, float speedMultiplier = 1);
}