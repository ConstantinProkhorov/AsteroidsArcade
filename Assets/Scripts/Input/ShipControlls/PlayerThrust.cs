using UnityEngine;
using UnityEngine.InputSystem;
/// <summary>
/// Implements strategy for thrusting.
/// </summary>
public class PlayerThrust : OnInputActionsBehaviour, INeedSoundPlayer
{
    [SerializeField] private ControllsSettings ControllsSettings = null;
    [SerializeField] private Animator ThrustAnimator = null;
    private string AnimatorBoolName = "IsThrusting";
    private bool ButtonIsPressed = false;
    private Rigidbody2D Rigidbody;
    private ISoundPlayer SoundPlayer;
    /// <summary>
    /// Set ISoundPlayer for this Behaviour.
    /// </summary>
    public void Set(ISoundPlayer soundPlayer) => SoundPlayer = soundPlayer;
    public void Awake() => Rigidbody = gameObject.transform.parent.gameObject.GetComponent<Rigidbody2D>();
    //в системе ввода настроена реакция на нажатие и отпускание кнопки. 
    //в этом случае событие performed срабатывает 2 раза: при нажатии кнопки и отпускании. 
    //следовательно все время, пока кнопка нажата, в методе Update производится вращение игрока в направлении, 
    //переданном из контекста.
    public override void Perform(InputAction.CallbackContext context)
    {
        ButtonIsPressed = !ButtonIsPressed;
        ThrustAnimator.SetBool(AnimatorBoolName, ButtonIsPressed);
        SoundPlayer.Play(Sounds.Thrust, true);
    }
    private void Update()
    {
        if (ButtonIsPressed)
        {
            Rigidbody.AddForce(gameObject.transform.up * ControllsSettings.ThrustPower, ForceMode2D.Impulse);
        }
    }
}
