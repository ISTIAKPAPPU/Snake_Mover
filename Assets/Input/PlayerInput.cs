// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""InputController"",
            ""id"": ""61b8ffcf-0b30-4e9d-92ff-e872fa8dfdc9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""86422786-532a-483c-946c-c0ab6a34c368"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseInput"",
                    ""type"": ""Button"",
                    ""id"": ""72507978-4413-4e8f-990c-aa80f36c65f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""58294625-ccb8-4964-965a-dd5a56c82e5a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9cc9a058-43d1-450c-b3b4-e30f79677f66"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""fce7ff51-7548-40d6-8e2d-486c98c81d12"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""947d21b1-bf10-4d16-a311-a7b647fa256a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ad116c4d-7304-4a2f-ae5d-1e8f975649c9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bb4cdcda-bc9a-43b5-b22d-86c51c797655"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15c51d6d-f42b-40eb-8d4c-6543f042f57e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // InputController
        m_InputController = asset.FindActionMap("InputController", throwIfNotFound: true);
        m_InputController_Movement = m_InputController.FindAction("Movement", throwIfNotFound: true);
        m_InputController_MouseInput = m_InputController.FindAction("MouseInput", throwIfNotFound: true);
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

    // InputController
    private readonly InputActionMap m_InputController;
    private IInputControllerActions m_InputControllerActionsCallbackInterface;
    private readonly InputAction m_InputController_Movement;
    private readonly InputAction m_InputController_MouseInput;
    public struct InputControllerActions
    {
        private @PlayerInput m_Wrapper;
        public InputControllerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_InputController_Movement;
        public InputAction @MouseInput => m_Wrapper.m_InputController_MouseInput;
        public InputActionMap Get() { return m_Wrapper.m_InputController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InputControllerActions set) { return set.Get(); }
        public void SetCallbacks(IInputControllerActions instance)
        {
            if (m_Wrapper.m_InputControllerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_InputControllerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_InputControllerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_InputControllerActionsCallbackInterface.OnMovement;
                @MouseInput.started -= m_Wrapper.m_InputControllerActionsCallbackInterface.OnMouseInput;
                @MouseInput.performed -= m_Wrapper.m_InputControllerActionsCallbackInterface.OnMouseInput;
                @MouseInput.canceled -= m_Wrapper.m_InputControllerActionsCallbackInterface.OnMouseInput;
            }
            m_Wrapper.m_InputControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @MouseInput.started += instance.OnMouseInput;
                @MouseInput.performed += instance.OnMouseInput;
                @MouseInput.canceled += instance.OnMouseInput;
            }
        }
    }
    public InputControllerActions @InputController => new InputControllerActions(this);
    public interface IInputControllerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnMouseInput(InputAction.CallbackContext context);
    }
}
