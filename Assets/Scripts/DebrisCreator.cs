using UnityEngine;
/// <summary>
/// Creates new enemies on top of the other one.
/// </summary>
public class DebrisCreator : MonoBehaviour
{
    [Tooltip("How many child enemies will be spawned.")]
    [SerializeField] private int DebrisCount = 2;
    [Tooltip("What type of child enemies will be spawned.")]
    [SerializeField] private EnemyType DebrisType = EnemyType.NoType;
    private EnemyCreator EnemyCreator;
    /// <summary>
    /// Set enemy creator to be used.
    /// </summary>
    public void SetEnemyCreator(EnemyCreator enemyCreator) => EnemyCreator = enemyCreator;
    /// <summary>
    /// Creates n amount of new enemies. All parameters should be set in inspector.
    /// </summary>
    public void Create()
    {
        if (EnemyCreator != null)
        {
            for (int i = 0; i < DebrisCount; i++)
            {
               EnemyCreator.ForceCreate(DebrisType, transform.position);
            }
        }
    }
}
