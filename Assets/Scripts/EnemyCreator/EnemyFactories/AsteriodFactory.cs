using UnityEngine;
/// <summary>
/// Concrete factory for creating all asteroids. 
/// </summary>
public class AsteriodFactory : EnemyFactory
{
    [Tooltip("Distance from each side of the sceen in which asteroid can spawn.")]
    [SerializeField] private float SpawnZoneWidth = 1.0f;
    /// <summary>
    /// Creates new asteroid at random positon.
    /// </summary>
    /// <returns>Reference to created GameObject. So they can be tracked.</returns>
    public override GameObject Create()
    {
        Vector3 SpawnPosition = EnemyInstantiationPosition.Get(EnemyType, SpawnZoneWidth);
        return Create(SpawnPosition);
    }
    /// <summary>
    /// Creates new asteroid at the positon.
    /// </summary>
    /// <returns>Reference to created GameObject. So they can be tracked.</returns>
    public override GameObject Create(Vector3 position) 
    {
        //получение рандомного вращения
        Vector3 RandomRotation = new Vector3(0, 0, Random.Range(0.0f, 360.0f));
        //назначение полученных данных врагу
        GameObject NewEnemy = Instantiate(Product, position, Quaternion.Euler(RandomRotation));
        //получение направления движения для врага
        Vector3 MovementDirection = AsteroidMovementDirection.Get(position);
        //назначение направления движения врагу
        NewEnemy.GetComponent<IFlyingObject>().SetFlightParameters(MovementDirection);
        return NewEnemy;
    }
}
