//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Input/PlayerAction.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""PlayerControl"",
            ""id"": ""6dd2252e-6e3c-49f2-bde3-f80d23774339"",
            ""actions"": [
                {
                    ""name"": ""PlayerMovement"",
                    ""type"": ""Value"",
                    ""id"": ""dfdf3744-16db-4f60-b6b5-186e4a550ac2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftHold"",
                    ""type"": ""Value"",
                    ""id"": ""cc5d65bf-ef5d-48ef-9f98-e4b3cd09747b"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": ""Hold"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftRelease"",
                    ""type"": ""Button"",
                    ""id"": ""8556b942-e4ac-4695-b6c9-8d1c2c014cfd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""db0bc30d-0aaf-439a-bbe3-da55d9d7266d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""6b317a32-0f83-4aa3-bf30-dbbffcb0f352"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""601426c0-5a34-487d-9bd8-6e1515ee05b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD Keys"",
                    ""id"": ""43140559-04d7-4b9f-af78-a63b4de209ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9edcba80-ec6a-4090-8c0c-62c2774abe6e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5bdb3052-0d8e-414e-9aed-fddba0fca7b4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0300cf0d-a062-4cf8-8f72-b7fae3e1ba43"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e692a5d-65c3-4b31-b37a-12124b243f29"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""476c470b-667c-459c-be2a-4415ee49102a"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4286ff2-c8da-4f44-b1ad-7fe2c99d5637"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73dc54c4-849d-40b7-a150-14d64b8931ef"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""9d444240-06f7-435c-9566-aab027b99409"",
            ""actions"": [
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""c9e0a538-c6e1-4ba0-b008-51937e80c8d9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""923226a1-d823-4270-9b2a-a46276cabbc2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControl
        m_PlayerControl = asset.FindActionMap("PlayerControl", throwIfNotFound: true);
        m_PlayerControl_PlayerMovement = m_PlayerControl.FindAction("PlayerMovement", throwIfNotFound: true);
        m_PlayerControl_LeftHold = m_PlayerControl.FindAction("LeftHold", throwIfNotFound: true);
        m_PlayerControl_LeftRelease = m_PlayerControl.FindAction("LeftRelease", throwIfNotFound: true);
        m_PlayerControl_MousePos = m_PlayerControl.FindAction("MousePos", throwIfNotFound: true);
        m_PlayerControl_Restart = m_PlayerControl.FindAction("Restart", throwIfNotFound: true);
        m_PlayerControl_LeftClick = m_PlayerControl.FindAction("LeftClick", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Esc = m_UI.FindAction("Esc", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerControl
    private readonly InputActionMap m_PlayerControl;
    private IPlayerControlActions m_PlayerControlActionsCallbackInterface;
    private readonly InputAction m_PlayerControl_PlayerMovement;
    private readonly InputAction m_PlayerControl_LeftHold;
    private readonly InputAction m_PlayerControl_LeftRelease;
    private readonly InputAction m_PlayerControl_MousePos;
    private readonly InputAction m_PlayerControl_Restart;
    private readonly InputAction m_PlayerControl_LeftClick;
    public struct PlayerControlActions
    {
        private @PlayerAction m_Wrapper;
        public PlayerControlActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMovement => m_Wrapper.m_PlayerControl_PlayerMovement;
        public InputAction @LeftHold => m_Wrapper.m_PlayerControl_LeftHold;
        public InputAction @LeftRelease => m_Wrapper.m_PlayerControl_LeftRelease;
        public InputAction @MousePos => m_Wrapper.m_PlayerControl_MousePos;
        public InputAction @Restart => m_Wrapper.m_PlayerControl_Restart;
        public InputAction @LeftClick => m_Wrapper.m_PlayerControl_LeftClick;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlActions instance)
        {
            if (m_Wrapper.m_PlayerControlActionsCallbackInterface != null)
            {
                @PlayerMovement.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnPlayerMovement;
                @LeftHold.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftHold;
                @LeftHold.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftHold;
                @LeftHold.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftHold;
                @LeftRelease.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftRelease;
                @LeftRelease.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftRelease;
                @LeftRelease.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftRelease;
                @MousePos.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnMousePos;
                @Restart.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnRestart;
                @LeftClick.started -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_PlayerControlActionsCallbackInterface.OnLeftClick;
            }
            m_Wrapper.m_PlayerControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayerMovement.started += instance.OnPlayerMovement;
                @PlayerMovement.performed += instance.OnPlayerMovement;
                @PlayerMovement.canceled += instance.OnPlayerMovement;
                @LeftHold.started += instance.OnLeftHold;
                @LeftHold.performed += instance.OnLeftHold;
                @LeftHold.canceled += instance.OnLeftHold;
                @LeftRelease.started += instance.OnLeftRelease;
                @LeftRelease.performed += instance.OnLeftRelease;
                @LeftRelease.canceled += instance.OnLeftRelease;
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
            }
        }
    }
    public PlayerControlActions @PlayerControl => new PlayerControlActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Esc;
    public struct UIActions
    {
        private @PlayerAction m_Wrapper;
        public UIActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Esc => m_Wrapper.m_UI_Esc;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Esc.started -= m_Wrapper.m_UIActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnEsc;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IPlayerControlActions
    {
        void OnPlayerMovement(InputAction.CallbackContext context);
        void OnLeftHold(InputAction.CallbackContext context);
        void OnLeftRelease(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnEsc(InputAction.CallbackContext context);
    }
}
