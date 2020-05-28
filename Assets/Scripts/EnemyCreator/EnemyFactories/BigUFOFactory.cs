using UnityEngine;
/// <summary>
/// Concrete factory for creating big UFO.
/// </summary>
public class BigUFOFactory : EnemyFactory
{
    /// <summary>
    /// Creates new UFO at random positon.
    /// </summary>
    /// <returns>Reference to created GameObject. So they can be tracked.</returns>
    public override GameObject Create()
    {
        Vector3 SpawnPosition = EnemyInstantiationPosition.Get(EnemyType);
        return Create(SpawnPosition);
    }
    /// <summary>
    /// Creates new big UFO at the positon.
    /// </summary>
    /// <returns>Reference to created GameObject. So they can be tracked.</returns>
    public override GameObject Create(Vector3 position)
    {
        GameObject NewEnemy = Instantiate(Product, position, Quaternion.identity);
        //подписка нового врага на события, если требуется. 
        //получение направления движения для врага
        Vector3 MovementDirection = UFOMovementDirection.Get(position);
        //назначение направления движения врагу
        NewEnemy.GetComponent<IFlyingObject>().SetFlightParameters(MovementDirection);
        return NewEnemy;
    }
}
