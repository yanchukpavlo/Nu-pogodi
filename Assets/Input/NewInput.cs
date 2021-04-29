// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cb573a6a-f56f-40a3-9a33-3e10ade2039c"",
            ""actions"": [
                {
                    ""name"": ""Camera X"",
                    ""type"": ""Value"",
                    ""id"": ""704af16d-7fa3-4c93-9d17-33e21891c0b6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera Y"",
                    ""type"": ""Value"",
                    ""id"": ""5a521c4c-359a-436d-828b-74e641953bf8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1dab6cf2-ec02-4c9c-bb8d-3d97c803e8b7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reaction"",
                    ""type"": ""Button"",
                    ""id"": ""d294bd72-ff46-4998-a509-aecb5e58a0b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""50e43427-19f5-4f2b-899c-626afc31c896"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MicroGame"",
                    ""type"": ""Value"",
                    ""id"": ""7e71098d-7f91-485e-ad94-e7ec0eefe8bc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""42a26972-083c-477d-8da8-92d95ba76a14"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""Normalize(min=-1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""db34757f-9c57-4e49-a191-72979345d1af"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6ca7d148-b01f-4f8d-b9c6-97af42acaa24"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2fd69a16-6250-4853-b215-ffdc1d4d4d96"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d290e715-07a6-4d60-b4db-651c14b080e5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d6306b9a-66fc-480d-a308-17ef8fe8c23f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Reaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""48ddc355-7855-4bd1-9478-a7846881469a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MicroGame"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c615b18b-6856-483f-ae3b-6c346f88d203"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MicroGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5b79e9b8-ef20-45cc-8d16-ae348a72bb92"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MicroGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4d168421-a4a2-4165-b2df-677d05f19b62"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MicroGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d9b0e5f7-ca9a-4cdf-acd2-9d55abc59e5e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""MicroGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9da29701-bce6-41b3-bf92-63d3bf184a8e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5aca814-7500-427a-8591-fdccfd78c701"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Camera X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0dd9a48-af68-4fce-879e-dd48fca7ea45"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Camera Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_CameraX = m_Player.FindAction("Camera X", throwIfNotFound: true);
        m_Player_CameraY = m_Player.FindAction("Camera Y", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Reaction = m_Player.FindAction("Reaction", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_MicroGame = m_Player.FindAction("MicroGame", throwIfNotFound: true);
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
    private readonly InputAction m_Player_CameraX;
    private readonly InputAction m_Player_CameraY;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Reaction;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_MicroGame;
    public struct PlayerActions
    {
        private @NewInput m_Wrapper;
        public PlayerActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraX => m_Wrapper.m_Player_CameraX;
        public InputAction @CameraY => m_Wrapper.m_Player_CameraY;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Reaction => m_Wrapper.m_Player_Reaction;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @MicroGame => m_Wrapper.m_Player_MicroGame;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @CameraX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraX;
                @CameraX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraX;
                @CameraX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraX;
                @CameraY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraY;
                @CameraY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraY;
                @CameraY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCameraY;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Reaction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReaction;
                @Reaction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReaction;
                @Reaction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnReaction;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @MicroGame.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMicroGame;
                @MicroGame.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMicroGame;
                @MicroGame.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMicroGame;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraX.started += instance.OnCameraX;
                @CameraX.performed += instance.OnCameraX;
                @CameraX.canceled += instance.OnCameraX;
                @CameraY.started += instance.OnCameraY;
                @CameraY.performed += instance.OnCameraY;
                @CameraY.canceled += instance.OnCameraY;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Reaction.started += instance.OnReaction;
                @Reaction.performed += instance.OnReaction;
                @Reaction.canceled += instance.OnReaction;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MicroGame.started += instance.OnMicroGame;
                @MicroGame.performed += instance.OnMicroGame;
                @MicroGame.canceled += instance.OnMicroGame;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardandmouseSchemeIndex = -1;
    public InputControlScheme KeyboardandmouseScheme
    {
        get
        {
            if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
            return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnCameraX(InputAction.CallbackContext context);
        void OnCameraY(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnReaction(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMicroGame(InputAction.CallbackContext context);
    }
}
