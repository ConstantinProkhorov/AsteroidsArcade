using UnityEngine;
using System.Collections;
/// <summary>
/// Moves UFO.
/// </summary>
public class UFOMovement : MonoBehaviour, IFlyingObject
{
    /// <summary>
    /// Flight type for the UFO.
    /// </summary>
    public enum FlightType
    {
        Horizontal = 0,
        Diagonal = 1
    }
    [SerializeField] private UFOSettings Settings = null;
    [SerializeField] private EnemyInfo EnemyInfo = null;
    [SerializeField] private Rigidbody2D Rigidbody = null;
    private float BaseSpeed;
    private Vector2 FlightDirection;
    private Vector2 ResultingFligthVector;
    private FlightType Flight = FlightType.Horizontal;
    private void Awake()
    {
        StartCoroutine(ChangeDirection(GetChangeDirectionTime()));
        BaseSpeed = EnemyInfo.BaseSpeed;
    }
    /// <summary>
    /// Sets flight speed and direction of this object.
    /// SpeedMultiplier is used for difficulty level.
    /// </summary>
    /// <param name="direction">Direction is applied using RigidBode2D.MovePosition()</param>
    /// <param name="speedMultiplier">Speed is calculated: EnemyInfo.BaseSpeed * speedMultiplier. It is optional parameter with default value of 1.</param>
    public void SetFlightParameters(Vector2 direction, float speedMultiplier = 1)
    {
        FlightDirection = direction;
        ResultingFligthVector = speedMultiplier * BaseSpeed * FlightDirection;
    }
    private IEnumerator ChangeDirection(float time)
    {
        yield return new WaitForSeconds(time);
        if (Flight == FlightType.Horizontal)
        {
            SetFlightParameters(UFOMovementDirection.GetDiagonalDirection(FlightDirection));
            Flight = FlightType.Diagonal;
        }
        else if (Flight == FlightType.Diagonal)
        {
            SetFlightParameters(UFOMovementDirection.GetHorizontalDirection(FlightDirection));
            Flight = FlightType.Horizontal;
        }
        StartCoroutine(ChangeDirection(GetChangeDirectionTime()));
    }
    private float GetChangeDirectionTime() => Random.Range(Settings.MinChangeDirectionTime, Settings.MaxChangeDirectionTime);
    void FixedUpdate()
    {
        Vector2 position = gameObject.transform.position;
        Rigidbody.MovePosition(new Vector2
            (position.x + ResultingFligthVector.x * Time.fixedDeltaTime,
            position.y + ResultingFligthVector.y * Time.fixedDeltaTime));
    }
}
