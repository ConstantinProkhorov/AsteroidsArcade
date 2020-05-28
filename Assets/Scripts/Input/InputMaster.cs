// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""0cf30e2c-1603-4e23-ab80-60f7e06ed3bc"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""b10c645a-48fc-4d02-8250-a7d094b6707d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Teleportation"",
                    ""type"": ""Button"",
                    ""id"": ""3276617f-82c2-4a4f-bc3f-72df19e7db5d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""e2b98a90-7778-4d02-93e3-d2d3f49f7500"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""b697df3d-ad55-4056-84a6-12a175689c5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SelfDestruct"",
                    ""type"": ""Button"",
                    ""id"": ""18134ced-5749-4d86-9160-03b1ec883967"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cccc5db4-3fc9-410a-beca-82e6cff9c73d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1ba28e68-0590-4ca2-93a2-27421a692710"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4892b44b-6785-4306-8cfb-cf3d0cc4beab"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6e804995-b710-4a76-8ba5-16a738705c9d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Teleportation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1f571f4-0298-4c45-8a26-8c707ec16a49"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e00ca39b-2c6a-4242-af88-74197c56c06a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb7fafdc-1ed6-4b43-9114-2fbe821f78f5"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""SelfDestruct"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuInputActions"",
            ""id"": ""2d761369-f734-4725-8b64-408b86d3b392"",
            ""actions"": [
                {
                    ""name"": ""StartGame"",
                    ""type"": ""Button"",
                    ""id"": ""8280b474-29fe-43db-a1d0-963a59e27286"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""HelpScreen"",
                    ""type"": ""Button"",
                    ""id"": ""03273e2d-0f27-43b8-aba1-47a2c7c7a3af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""780ef51c-e123-454b-a67a-35747355177f"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6283a00-14cd-44d2-ba31-6ed1881c0518"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HelpScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1dbff9b2-3145-4090-af72-459977dabaf6"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""HelpScreen"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""EndSceneInput"",
            ""id"": ""9af88ea6-41d9-4be0-bb33-a2d284b4d66d"",
            ""actions"": [
                {
                    ""name"": ""LeaveScene"",
                    ""type"": ""Button"",
                    ""id"": ""fd1b3ef1-5dfc-4ced-a072-e6e10b2c3941"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b27ca8c7-4e09-459d-a394-392c2732cf24"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeaveScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""592dddee-6610-443c-9442-e05e7a8e213c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeaveScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""EnterNameInput"",
            ""id"": ""c093ca53-25db-47dc-873e-8d4669eab6fd"",
            ""actions"": [
                {
                    ""name"": ""LeaveScene"",
                    ""type"": ""Button"",
                    ""id"": ""8d0622d6-ad7a-4516-a782-cbf7b9a1b8c9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterName"",
                    ""type"": ""Button"",
                    ""id"": ""ea15b61f-b52d-4504-85b6-ca00f0f07daa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""32b14ee3-98e9-4566-95be-c9158235b128"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""LeaveScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""086ca276-fbec-49cc-85d0-d03a3ad75c3e"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""EnterName"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Rotation = m_Player.FindAction("Rotation", throwIfNotFound: true);
        m_Player_Teleportation = m_Player.FindAction("Teleportation", throwIfNotFound: true);
        m_Player_Thrust = m_Player.FindAction("Thrust", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_SelfDestruct = m_Player.FindAction("SelfDestruct", throwIfNotFound: true);
        // MenuInputActions
        m_MenuInputActions = asset.FindActionMap("MenuInputActions", throwIfNotFound: true);
        m_MenuInputActions_StartGame = m_MenuInputActions.FindAction("StartGame", throwIfNotFound: true);
        m_MenuInputActions_HelpScreen = m_MenuInputActions.FindAction("HelpScreen", throwIfNotFound: true);
        // EndSceneInput
        m_EndSceneInput = asset.FindActionMap("EndSceneInput", throwIfNotFound: true);
        m_EndSceneInput_LeaveScene = m_EndSceneInput.FindAction("LeaveScene", throwIfNotFound: true);
        // EnterNameInput
        m_EnterNameInput = asset.FindActionMap("EnterNameInput", throwIfNotFound: true);
        m_EnterNameInput_LeaveScene = m_EnterNameInput.FindAction("LeaveScene", throwIfNotFound: true);
        m_EnterNameInput_EnterName = m_EnterNameInput.FindAction("EnterName", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Rotation;
    private readonly InputAction m_Player_Teleportation;
    private readonly InputAction m_Player_Thrust;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_SelfDestruct;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_Player_Rotation;
        public InputAction @Teleportation => m_Wrapper.m_Player_Teleportation;
        public InputAction @Thrust => m_Wrapper.m_Player_Thrust;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @SelfDestruct => m_Wrapper.m_Player_SelfDestruct;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotation;
                @Teleportation.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportation;
                @Teleportation.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportation;
                @Teleportation.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTeleportation;
                @Thrust.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrust;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @SelfDestruct.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfDestruct;
                @SelfDestruct.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfDestruct;
                @SelfDestruct.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSelfDestruct;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Teleportation.started += instance.OnTeleportation;
                @Teleportation.performed += instance.OnTeleportation;
                @Teleportation.canceled += instance.OnTeleportation;
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @SelfDestruct.started += instance.OnSelfDestruct;
                @SelfDestruct.performed += instance.OnSelfDestruct;
                @SelfDestruct.canceled += instance.OnSelfDestruct;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // MenuInputActions
    private readonly InputActionMap m_MenuInputActions;
    private IMenuInputActionsActions m_MenuInputActionsActionsCallbackInterface;
    private readonly InputAction m_MenuInputActions_StartGame;
    private readonly InputAction m_MenuInputActions_HelpScreen;
    public struct MenuInputActionsActions
    {
        private @InputMaster m_Wrapper;
        public MenuInputActionsActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @StartGame => m_Wrapper.m_MenuInputActions_StartGame;
        public InputAction @HelpScreen => m_Wrapper.m_MenuInputActions_HelpScreen;
        public InputActionMap Get() { return m_Wrapper.m_MenuInputActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuInputActionsActions set) { return set.Get(); }
        public void SetCallbacks(IMenuInputActionsActions instance)
        {
            if (m_Wrapper.m_MenuInputActionsActionsCallbackInterface != null)
            {
                @StartGame.started -= m_Wrapper.m_MenuInputActionsActionsCallbackInterface.OnStartGame;
                @StartGame.performed -= m_Wrapper.m_MenuInputActionsActionsCallbackInterface.OnStartGame;
                @StartGame.canceled -= m_Wrapper.m_MenuInputActionsActionsCallbackInterface.OnStartGame;
                @HelpScreen.started -= m_Wrapper.m_MenuInputActionsActionsCallbackInterface.OnHelpScreen;
                @HelpScreen.performed -= m_Wrapper.m_MenuInputActionsActionsCallbackInterface.OnHelpScreen;
                @HelpScreen.canceled -= m_Wrapper.m_MenuInputActionsActionsCallbackInterface.OnHelpScreen;
            }
            m_Wrapper.m_MenuInputActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StartGame.started += instance.OnStartGame;
                @StartGame.performed += instance.OnStartGame;
                @StartGame.canceled += instance.OnStartGame;
                @HelpScreen.started += instance.OnHelpScreen;
                @HelpScreen.performed += instance.OnHelpScreen;
                @HelpScreen.canceled += instance.OnHelpScreen;
            }
        }
    }
    public MenuInputActionsActions @MenuInputActions => new MenuInputActionsActions(this);

    // EndSceneInput
    private readonly InputActionMap m_EndSceneInput;
    private IEndSceneInputActions m_EndSceneInputActionsCallbackInterface;
    private readonly InputAction m_EndSceneInput_LeaveScene;
    public struct EndSceneInputActions
    {
        private @InputMaster m_Wrapper;
        public EndSceneInputActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeaveScene => m_Wrapper.m_EndSceneInput_LeaveScene;
        public InputActionMap Get() { return m_Wrapper.m_EndSceneInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EndSceneInputActions set) { return set.Get(); }
        public void SetCallbacks(IEndSceneInputActions instance)
        {
            if (m_Wrapper.m_EndSceneInputActionsCallbackInterface != null)
            {
                @LeaveScene.started -= m_Wrapper.m_EndSceneInputActionsCallbackInterface.OnLeaveScene;
                @LeaveScene.performed -= m_Wrapper.m_EndSceneInputActionsCallbackInterface.OnLeaveScene;
                @LeaveScene.canceled -= m_Wrapper.m_EndSceneInputActionsCallbackInterface.OnLeaveScene;
            }
            m_Wrapper.m_EndSceneInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeaveScene.started += instance.OnLeaveScene;
                @LeaveScene.performed += instance.OnLeaveScene;
                @LeaveScene.canceled += instance.OnLeaveScene;
            }
        }
    }
    public EndSceneInputActions @EndSceneInput => new EndSceneInputActions(this);

    // EnterNameInput
    private readonly InputActionMap m_EnterNameInput;
    private IEnterNameInputActions m_EnterNameInputActionsCallbackInterface;
    private readonly InputAction m_EnterNameInput_LeaveScene;
    private readonly InputAction m_EnterNameInput_EnterName;
    public struct EnterNameInputActions
    {
        private @InputMaster m_Wrapper;
        public EnterNameInputActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeaveScene => m_Wrapper.m_EnterNameInput_LeaveScene;
        public InputAction @EnterName => m_Wrapper.m_EnterNameInput_EnterName;
        public InputActionMap Get() { return m_Wrapper.m_EnterNameInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(EnterNameInputActions set) { return set.Get(); }
        public void SetCallbacks(IEnterNameInputActions instance)
        {
            if (m_Wrapper.m_EnterNameInputActionsCallbackInterface != null)
            {
                @LeaveScene.started -= m_Wrapper.m_EnterNameInputActionsCallbackInterface.OnLeaveScene;
                @LeaveScene.performed -= m_Wrapper.m_EnterNameInputActionsCallbackInterface.OnLeaveScene;
                @LeaveScene.canceled -= m_Wrapper.m_EnterNameInputActionsCallbackInterface.OnLeaveScene;
                @EnterName.started -= m_Wrapper.m_EnterNameInputActionsCallbackInterface.OnEnterName;
                @EnterName.performed -= m_Wrapper.m_EnterNameInputActionsCallbackInterface.OnEnterName;
                @EnterName.canceled -= m_Wrapper.m_EnterNameInputActionsCallbackInterface.OnEnterName;
            }
            m_Wrapper.m_EnterNameInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeaveScene.started += instance.OnLeaveScene;
                @LeaveScene.performed += instance.OnLeaveScene;
                @LeaveScene.canceled += instance.OnLeaveScene;
                @EnterName.started += instance.OnEnterName;
                @EnterName.performed += instance.OnEnterName;
                @EnterName.canceled += instance.OnEnterName;
            }
        }
    }
    public EnterNameInputActions @EnterNameInput => new EnterNameInputActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnRotation(InputAction.CallbackContext context);
        void OnTeleportation(InputAction.CallbackContext context);
        void OnThrust(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnSelfDestruct(InputAction.CallbackContext context);
    }
    public interface IMenuInputActionsActions
    {
        void OnStartGame(InputAction.CallbackContext context);
        void OnHelpScreen(InputAction.CallbackContext context);
    }
    public interface IEndSceneInputActions
    {
        void OnLeaveScene(InputAction.CallbackContext context);
    }
    public interface IEnterNameInputActions
    {
        void OnLeaveScene(InputAction.CallbackContext context);
        void OnEnterName(InputAction.CallbackContext context);
    }
}
