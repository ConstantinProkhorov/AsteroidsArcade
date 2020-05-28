using UnityEngine;
/// <summary>
/// Settings for providing easy way to alter Controlls responsivness without changing each script.
/// </summary>
[CreateAssetMenu(fileName = "ControllsSettings", menuName = "ScriptabelObjects/ControllsSettings", order = 2)]
public class ControllsSettings : ScriptableObject
{
    [Tooltip("How responsive to rotation button ship is.")]
    [SerializeField] private float rotationSensetivity = 200.0f;
    [Tooltip("DeadZone is a width of an area near screenborder where player can't be telepoted." +
        "\nIt is need so that player won't teleport right on top of the spawning asteroid, which he couldn't have seen or predicted.")]
    [SerializeField] private float teleportationDeadZone = 0.3f;
    [Tooltip("How powerfull the thrust is.")]
    [SerializeField] private float thrustPower = 0.1f;
    /// <summary>
    /// How responsive to rotation button ship is.
    /// </summary>
    public float RotationSensetivity { get => rotationSensetivity; }
    /// <summary>
    /// DeadZone is a width of an area near screenborder where player can't be telepoted.
    /// </summary>
    public float TeleportationDeadZone { get => teleportationDeadZone; }
    /// <summary>
    /// How powerfull the thrust is.
    /// </summary>
    public float ThrustPower { get => thrustPower; set => thrustPower = value; }
}
