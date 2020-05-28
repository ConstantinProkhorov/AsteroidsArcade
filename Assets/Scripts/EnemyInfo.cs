using UnityEngine;
/// <summary>
/// General info about enemy, added to prefab
/// </summary>
public class EnemyInfo : MonoBehaviour
{
    [SerializeField] private EnemyType type = EnemyType.NoType;
    [SerializeField] private int scoreToGain = default;
    [SerializeField] private float baseSpeed = default;
    /// <summary>
    /// Type of an enemy.
    /// </summary>
    public EnemyType Type { get => type; }
    /// <summary>
    /// How much score player will get for killing this enemy.
    /// Defined in prefab.
    /// </summary>
    public int ScoreToGain { get => scoreToGain; }
    /// <summary>
    /// Base speed of an enemy.
    /// </summary>
    public float BaseSpeed { get => baseSpeed; }
}
