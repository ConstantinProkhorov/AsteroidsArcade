using UnityEngine;
/// <summary>
/// Interface for tracking enemies.
/// </summary>
public interface IEnemyTracker
{
    /// <summary>
    /// Add new enemy so it can be tracked.
    /// </summary>
    void Add(GameObject enemy);
    /// <summary>
    /// Are ther any enemies left? 
    /// </summary>
    /// <returns>Returns true if there are enemies.</returns>
    bool AreThereEnemies();
    /// <summary>
    /// Returns total number of enemies of all types present on the game scene at the moment.
    /// </summary>
    int EnemiesCount();
    /// <summary>
    /// Returns total number of enemies of enemyType.
    /// </summary>
    int EnemiesCount(EnemyType enemyType);
}