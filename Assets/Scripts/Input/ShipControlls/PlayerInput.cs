using UnityEngine;
/// <summary>
/// Calls different input reaction strategies after getting input from player.
/// In this class only input affecting player ship is handled.
/// Concrete strategies are implemented in OnInputActionsBehaviour subclasses.  
/// </summary>
public class PlayerInput : MonoBehaviour
{
    [Header("Input Strategies:")]
    [SerializeField] private OnInputActionsBehaviour PlayerRotation = null;
    [SerializeField] private OnInputActionsBehaviour PlayerTeleportation = null;
    [SerializeField] private OnInputActionsBehaviour PlayerThrust = null;
    [SerializeField] private OnInputActionsBehaviour PlayerFire = null;
    [SerializeField] private OnInputActionsBehaviour PlayerSelfDestruction = null;
    private InputMaster PlayerInputActions;
    /// <summary>
    /// Turn controlls on.
    /// </summary>
    public void TurnOn() => PlayerInputActions.Enable();
    /// <summary>
    /// Turn controlls off.
    /// </summary>
    public void TurnOff() => PlayerInputActions.Disable();
    private void Awake()
    {
        PlayerInputActions = new InputMaster();
        //player rotation
        PlayerInputActions.Player.Rotation.performed += PlayerRotation.Perform;
        //player teleportation aka hyperdrive
        PlayerInputActions.Player.Teleportation.performed += PlayerTeleportation.Perform;
        //player thrust
        PlayerInputActions.Player.Thrust.performed += PlayerThrust.Perform;
        //player fire
        PlayerInputActions.Player.Fire.performed += PlayerFire.Perform;
        //player selfdestruction
        PlayerInputActions.Player.SelfDestruct.performed += PlayerSelfDestruction.Perform;
    }
    //private void OnEnable() => PlayerInputActions.Enable();
    private void OnDisable()
    {
        PlayerInputActions.Player.Rotation.performed -= PlayerRotation.Perform;
        PlayerInputActions.Player.Teleportation.performed -= PlayerTeleportation.Perform;
        PlayerInputActions.Player.Thrust.performed -= PlayerThrust.Perform;
        PlayerInputActions.Player.Fire.performed -= PlayerFire.Perform;
        PlayerInputActions.Player.SelfDestruct.performed -= PlayerSelfDestruction.Perform;
        PlayerInputActions.Disable();
    }
    //получается в итоге, что весь класс зависит от типа ввода. И обратока ввода может поменяться при смене стратегии. Это произойдет потому, что
    //часть стратегий требует параметра, а часть нет. Кроме того часть возвращаемых значений Input.GetAxis это bool, а часть - float.
    //получается, что паттерн применен, а эффекта нет. Изменение в классах стратегий приведет к изменению этого класса, а значит у него 2 причины для 
    //изменения.
    //получается, что я должен при каждом вызове отправлять параметр, вне зависимости от того нужен он сейчас или нет? 
    //то разделение и использование паттерна вообще имеет смысл?
    //если я меняю детали реализации самого поведения, то я этот класс не трогаю. Если я меняю само поведение, заменяю его например, добавляю еще одно,
    //то я меняю этот класс, а другие классы не трогаю.
    //чего я хочу?
    //1) независимого изменения способа обработки ввода и реакций на этот ввод
    //2) возможности легко подменять реакции на ввод, не меняя ничего в обработке
    //оставляю весь этот текст пока для раздумий.
    //по итогу переделки и перехода на новую систему ввода unity получилсь архитектура, которая действительно позволяет заменять одни стратегии на другие без 
    //изменения этого класса - это было не просто. То есть эта задача решена. Так же получилось 2 типа классов. Этот отвечает за назначение стратегий
    //определенному типу ввода. Другие отвечают за реализацию стратегий поведения в ответ на ввод. 
    //С другой стороны часть классов нарушает теперь принцип сегрегации интерфейсов.
    //как этого избежать? С текущей системой только придумав способ считывая ввода без двухкратной подписки на события за 1 ввод. 
    //всё! ура, принцип сегрегации интерфейсов больше не нарушается. Это было тяжело. Я за ночь придумал более вменяемую логику. Теперь подписываемся только
    //на событие performed, так как оно вызывается 2 раза. 
}