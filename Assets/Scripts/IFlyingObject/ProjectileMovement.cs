using UnityEngine;
/// <summary>
/// Moves Projectile.
/// </summary>
public class ProjectileMovement : MonoBehaviour, IFlyingObject
{
    [SerializeField] private EnemyInfo EnemyInfo = null;
    private Vector2 ResultingFlightVector = default;
    private void Start() => SetFlightParameters(Vector2.up, EnemyInfo.BaseSpeed);
    /// <summary>
    /// Sets flight speed and direction of this object.
    /// </summary>
    /// <param name="speed">Optional parameter with default value of 1.</param>
    public void SetFlightParameters(Vector2 direction, float speed = 1)
    {
        ResultingFlightVector = speed * direction;
    }
    void FixedUpdate()
    {
        gameObject.transform.Translate(ResultingFlightVector * Time.fixedDeltaTime);
    }
    //c одной стороны этот метод, находясь здесь нарушает принцип единственной ответственносит. 
    //с другой стороны вынос его в отдельный класс кажется мне неэффективным. И он логически связан с движением. 
    //а добавлять расходы на создание дополнительных объектов и их утилизацию мне не хочется. 
    //с другой стороны это будет устранено, хотя бы частично с использованием object pulling.
    public void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
