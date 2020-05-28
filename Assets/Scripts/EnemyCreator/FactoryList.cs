using UnityEngine;
/// <summary>
/// List of all Factories for EnemyCreator module to use.
/// </summary>
public class FactoryList : MonoBehaviour
{
    [SerializeField] private EnemyFactory[] Factories = null;
    /// <summary>
    /// Returns Factory for provided enemyType.
    /// </summary>
    //TODO: неоптимальная логика, переделать. Должно вызываться только 1 раз.
    public EnemyFactory Get(EnemyType enemyType)
    {
        foreach (EnemyFactory factory in Factories)
        {
            if (factory.EnemyType == enemyType)
            {
                return factory;
            }
        }
        Debug.LogError(name + " Has no EnemyFactory corresponding to provided " + enemyType.ToString() + " EnemyType");
        return null;
    }
}
