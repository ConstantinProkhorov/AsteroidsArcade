using UnityEngine;
/// <summary>
/// Moves asteroid.
/// </summary>
public class AsteroidMovement : MonoBehaviour, IFlyingObject
{
    [SerializeField] private EnemyInfo EnemyInfo = null;
    [SerializeField] private Rigidbody2D Rigidbody = null;
    private float BaseSpeed;
    private Vector2 ResultingFligthVector;
    private void Awake() => BaseSpeed = EnemyInfo.BaseSpeed;
    /// <summary>
    /// Sets flight speed and direction of this object.
    /// SpeedMultiplier is used for difficulty level.
    /// </summary>
    /// <param name="direction">Direction is applied using RigidBode2D.MovePosition()</param>
    /// <param name="speedMultiplier">Speed is calculated: EnemyInfo.BaseSpeed * speedMultiplier. It is optional parameter with default value of 1.</param>
    public void SetFlightParameters(Vector2 direction, float speedMultiplier = 1)
    {
        ResultingFligthVector = speedMultiplier * BaseSpeed * direction;
    }
    void FixedUpdate()
    {
        Vector2 position = gameObject.transform.position;
        Rigidbody.MovePosition(new Vector2
            (position.x + ResultingFligthVector.x * Time.fixedDeltaTime,
            position.y + ResultingFligthVector.y * Time.fixedDeltaTime));
    }
}
