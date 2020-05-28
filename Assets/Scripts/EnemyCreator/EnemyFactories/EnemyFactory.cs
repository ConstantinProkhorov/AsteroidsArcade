using UnityEngine;
/// <summary>
/// Abstract class for Factory Method to create Enemies.
/// </summary>
public abstract class EnemyFactory : MonoBehaviour
{
    [Tooltip("Prefab of an enemy this factory will create.")]
    [SerializeField] protected GameObject Product = null;
    /// <summary>
    /// EnemyType type of the enemy this factory creates.
    /// </summary>
    public EnemyType EnemyType { get; private set; } = EnemyType.NoType;
    private void Awake() => EnemyType = Product.GetComponent<EnemyInfo>().Type;
    /// <summary>
    /// Creates a new enemy at random positon.
    /// </summary>
    /// <returns>Reference to created GameObject. So they can be tracked.</returns>
    public abstract GameObject Create();
    /// <summary>
    /// Creates a new enemy at the positon.
    /// </summary>
    /// <returns>Reference to created GameObject. So they can be tracked.</returns>
    public abstract GameObject Create(Vector3 position);
}

