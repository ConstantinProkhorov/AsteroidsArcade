using UnityEngine;
/// <summary>
/// Basic tracker for enemies. 
/// </summary>
public class EnemyTracker : IEnemyTracker
{
    private GameObject[] Enemies;
    private int EnemiesLength = 20;
    private int Index = 0;
    public EnemyTracker()
    {
        Enemies = new GameObject[EnemiesLength];
    }
    /// <summary>
    /// Add new enemy so it can be tracked.
    /// </summary>
    public void Add(GameObject enemy)
    {
        if (Index < EnemiesLength)
        {
            Enemies[Index] = enemy;
        }
        else
        {
            GameObject[] temp = new GameObject[EnemiesLength * 2];
            Enemies.CopyTo(temp, 0);
            Enemies = temp;
            Enemies[Index] = enemy;
        }
        Index++;
    }
    /// <summary>
    /// Are there any enemies left? 
    /// </summary>
    /// <returns>Returns true if there are enemies.</returns>
    public bool AreThereEnemies()
    {
        return !(EnemiesCount() == 0);
    }
    /// <summary>
    /// Returns total number of enemies of all types present on the game scene at the moment.
    /// </summary>
    public int EnemiesCount()
    {
        int counter = 0;
        foreach (GameObject enemy in Enemies)
        {
            if (enemy != null) counter++;
        }
        return counter;
    }
    /// <summary>
    /// Returns total number of enemies of enemyType.
    /// </summary>
    public int EnemiesCount(EnemyType enemyType)
    {
        int counter = 0;
        foreach (GameObject enemy in Enemies)
        {
            if (enemy != null)
            {
                if (enemy.GetComponent<EnemyInfo>().Type == enemyType)
                {
                    counter++;
                }
            }
        }
        return counter;
    }
}
