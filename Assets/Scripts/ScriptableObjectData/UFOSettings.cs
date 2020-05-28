using UnityEngine;
/// <summary>
/// Settings for providing easy way to alter UFO characteristics without changing each prefab.
/// </summary>
[CreateAssetMenu(fileName = "UFOSettings", menuName = "ScriptabelObjects/UFOSettings", order = 1)]
public class UFOSettings : ScriptableObject
{
    [Tooltip("Max interval at which UFO will fire.")]
    [SerializeField] private float maxFireInterval = 0; 
    [Tooltip("Offset of the target position before firing.")]
    [SerializeField] private float accuracyOffset = 0.5f;
    [Tooltip("Min time after which UFO will change direction.")]
    [SerializeField] private int minChangeDirectionTime = 0;
    [Tooltip("Max time after which UFO will change direction.")]
    [SerializeField] private int maxChangeDirectionTime = 0;
    /// <summary>
    /// Max interval at which UFO will fire.
    /// </summary>
    public float MaxFireInterval { get => maxFireInterval;}
    /// <summary>
    /// Offset of the target position before firing.
    /// </summary>
    public float AccuracyOffset { get => accuracyOffset; }
    /// <summary>
    /// Min time after which UFO will change direction.
    /// </summary>
    public int MinChangeDirectionTime { get => minChangeDirectionTime;}
    /// <summary>
    /// Max time after which UFO will change direction.
    /// </summary>
    public int MaxChangeDirectionTime { get => maxChangeDirectionTime;}
}
