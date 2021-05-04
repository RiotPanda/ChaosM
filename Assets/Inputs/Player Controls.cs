// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Player Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player Controls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""170831af-f6e8-4bf1-8ffb-1ee6635b9bd3"",
            ""actions"": [
                {
                    ""name"": ""APressed"",
                    ""type"": ""Button"",
                    ""id"": ""59b58bc1-a0d9-466a-9c21-caa74bff5af5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BPressed"",
                    ""type"": ""Button"",
                    ""id"": ""59c8f7d4-3741-405b-b510-2bf02aff0bda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""XPressed"",
                    ""type"": ""Button"",
                    ""id"": ""55af0e90-4913-4a95-9c97-6ce76a927c7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""YPressed"",
                    ""type"": ""Button"",
                    ""id"": ""8afbaaf2-3eb4-4b64-8756-e01aed6a4969"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LTPressed"",
                    ""type"": ""Button"",
                    ""id"": ""4c9a80ba-70da-4fd3-a121-9832367385cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RTPressed"",
                    ""type"": ""Button"",
                    ""id"": ""a19088ff-00a4-497f-bf29-aa177052e7ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LBPressed"",
                    ""type"": ""Button"",
                    ""id"": ""743eecb2-49ac-4444-82f1-1f25c9caac9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RBPressed"",
                    ""type"": ""Button"",
                    ""id"": ""3fd44c77-2378-4d34-9f09-9bc3bcd99db8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ARelease"",
                    ""type"": ""Button"",
                    ""id"": ""27f22a68-a22d-4113-8d7a-090579ba8b17"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26761cfc-2d37-4d92-a66c-03eceeb0b4af"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""APressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63b3c63a-bdad-46be-a1f8-bb3cac64a957"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e906576-8924-4ff1-9aa3-c740363c3f8f"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""XPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e3b7a1e-010d-4cac-88c2-3922a3f3611f"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""YPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15de9137-4449-4945-b6bd-70e1fea0d7ea"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LTPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""095a13e5-439a-4356-b30e-f0bed61d9d20"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LBPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6217bdff-ba9c-42a8-a2cb-8cab8cb991f2"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RBPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80ff92a6-04b1-4d55-bdc5-234f942a5dd4"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RTPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""998a7177-9c01-4c94-a8d0-4359051b0f8e"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ARelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_APressed = m_Gameplay.FindAction("APressed", throwIfNotFound: true);
        m_Gameplay_BPressed = m_Gameplay.FindAction("BPressed", throwIfNotFound: true);
        m_Gameplay_XPressed = m_Gameplay.FindAction("XPressed", throwIfNotFound: true);
        m_Gameplay_YPressed = m_Gameplay.FindAction("YPressed", throwIfNotFound: true);
        m_Gameplay_LTPressed = m_Gameplay.FindAction("LTPressed", throwIfNotFound: true);
        m_Gameplay_RTPressed = m_Gameplay.FindAction("RTPressed", throwIfNotFound: true);
        m_Gameplay_LBPressed = m_Gameplay.FindAction("LBPressed", throwIfNotFound: true);
        m_Gameplay_RBPressed = m_Gameplay.FindAction("RBPressed", throwIfNotFound: true);
        m_Gameplay_ARelease = m_Gameplay.FindAction("ARelease", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_APressed;
    private readonly InputAction m_Gameplay_BPressed;
    private readonly InputAction m_Gameplay_XPressed;
    private readonly InputAction m_Gameplay_YPressed;
    private readonly InputAction m_Gameplay_LTPressed;
    private readonly InputAction m_Gameplay_RTPressed;
    private readonly InputAction m_Gameplay_LBPressed;
    private readonly InputAction m_Gameplay_RBPressed;
    private readonly InputAction m_Gameplay_ARelease;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @APressed => m_Wrapper.m_Gameplay_APressed;
        public InputAction @BPressed => m_Wrapper.m_Gameplay_BPressed;
        public InputAction @XPressed => m_Wrapper.m_Gameplay_XPressed;
        public InputAction @YPressed => m_Wrapper.m_Gameplay_YPressed;
        public InputAction @LTPressed => m_Wrapper.m_Gameplay_LTPressed;
        public InputAction @RTPressed => m_Wrapper.m_Gameplay_RTPressed;
        public InputAction @LBPressed => m_Wrapper.m_Gameplay_LBPressed;
        public InputAction @RBPressed => m_Wrapper.m_Gameplay_RBPressed;
        public InputAction @ARelease => m_Wrapper.m_Gameplay_ARelease;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @APressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAPressed;
                @APressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAPressed;
                @APressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAPressed;
                @BPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBPressed;
                @BPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBPressed;
                @BPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnBPressed;
                @XPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnXPressed;
                @XPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnXPressed;
                @XPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnXPressed;
                @YPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnYPressed;
                @YPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnYPressed;
                @YPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnYPressed;
                @LTPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLTPressed;
                @LTPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLTPressed;
                @LTPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLTPressed;
                @RTPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRTPressed;
                @RTPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRTPressed;
                @RTPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRTPressed;
                @LBPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLBPressed;
                @LBPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLBPressed;
                @LBPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLBPressed;
                @RBPressed.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRBPressed;
                @RBPressed.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRBPressed;
                @RBPressed.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRBPressed;
                @ARelease.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnARelease;
                @ARelease.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnARelease;
                @ARelease.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnARelease;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @APressed.started += instance.OnAPressed;
                @APressed.performed += instance.OnAPressed;
                @APressed.canceled += instance.OnAPressed;
                @BPressed.started += instance.OnBPressed;
                @BPressed.performed += instance.OnBPressed;
                @BPressed.canceled += instance.OnBPressed;
                @XPressed.started += instance.OnXPressed;
                @XPressed.performed += instance.OnXPressed;
                @XPressed.canceled += instance.OnXPressed;
                @YPressed.started += instance.OnYPressed;
                @YPressed.performed += instance.OnYPressed;
                @YPressed.canceled += instance.OnYPressed;
                @LTPressed.started += instance.OnLTPressed;
                @LTPressed.performed += instance.OnLTPressed;
                @LTPressed.canceled += instance.OnLTPressed;
                @RTPressed.started += instance.OnRTPressed;
                @RTPressed.performed += instance.OnRTPressed;
                @RTPressed.canceled += instance.OnRTPressed;
                @LBPressed.started += instance.OnLBPressed;
                @LBPressed.performed += instance.OnLBPressed;
                @LBPressed.canceled += instance.OnLBPressed;
                @RBPressed.started += instance.OnRBPressed;
                @RBPressed.performed += instance.OnRBPressed;
                @RBPressed.canceled += instance.OnRBPressed;
                @ARelease.started += instance.OnARelease;
                @ARelease.performed += instance.OnARelease;
                @ARelease.canceled += instance.OnARelease;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnAPressed(InputAction.CallbackContext context);
        void OnBPressed(InputAction.CallbackContext context);
        void OnXPressed(InputAction.CallbackContext context);
        void OnYPressed(InputAction.CallbackContext context);
        void OnLTPressed(InputAction.CallbackContext context);
        void OnRTPressed(InputAction.CallbackContext context);
        void OnLBPressed(InputAction.CallbackContext context);
        void OnRBPressed(InputAction.CallbackContext context);
        void OnARelease(InputAction.CallbackContext context);
    }
}
