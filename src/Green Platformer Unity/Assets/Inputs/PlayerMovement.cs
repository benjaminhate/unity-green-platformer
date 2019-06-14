// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerMovement.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public class PlayerMovement : IInputActionCollection
    {
        private InputActionAsset asset;
        public PlayerMovement()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMovement"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""3000077a-1309-48e4-b3a0-9ffdb26ff60b"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""e13ea0e4-8f70-44c0-af89-88f2231aa667"",
                    ""expectedControlLayout"": ""Axis"",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Jump"",
                    ""id"": ""6243cf36-a89d-4295-a436-5c9c329c3fc3"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                },
                {
                    ""name"": ""Crouch"",
                    ""id"": ""118473c0-d8d1-4690-a5aa-610a0f3a9a75"",
                    ""expectedControlLayout"": """",
                    ""continuous"": false,
                    ""passThrough"": false,
                    ""initialStateCheck"": false,
                    ""processors"": """",
                    ""interactions"": """",
                    ""bindings"": []
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""QD"",
                    ""id"": ""1582028c-f028-42e7-8f2a-399e596856f3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f4b9d197-9678-45de-b69f-da780bc309e6"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""afc884d4-e0cf-4065-b8cb-832e008d542d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""013aaaca-5180-4ade-a64c-755c19117d51"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""eed2a8e0-1ae9-4f00-8d86-adc5bec884a5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""76623d4e-d456-45aa-a267-21d313033349"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""9866196b-ffce-45fe-a6dc-8c04e2316e37"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""3e6b14a4-1c4f-41d7-a0e6-4fa70966875c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""ee6a0786-b5cf-4a6c-b885-9b64babb1b7f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                },
                {
                    ""name"": """",
                    ""id"": ""1ac18143-5f70-43df-b081-314266ef47bd"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false,
                    ""modifiers"": """"
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Movement
            m_Movement = asset.GetActionMap("Movement");
            m_Movement_Horizontal = m_Movement.GetAction("Horizontal");
            m_Movement_Jump = m_Movement.GetAction("Jump");
            m_Movement_Crouch = m_Movement.GetAction("Crouch");
        }

        ~PlayerMovement()
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

        public ReadOnlyArray<InputControlScheme> controlSchemes
        {
            get => asset.controlSchemes;
        }

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

        // Movement
        private InputActionMap m_Movement;
        private IMovementActions m_MovementActionsCallbackInterface;
        private InputAction m_Movement_Horizontal;
        private InputAction m_Movement_Jump;
        private InputAction m_Movement_Crouch;
        public struct MovementActions
        {
            private PlayerMovement m_Wrapper;
            public MovementActions(PlayerMovement wrapper) { m_Wrapper = wrapper; }
            public InputAction @Horizontal { get { return m_Wrapper.m_Movement_Horizontal; } }
            public InputAction @Jump { get { return m_Wrapper.m_Movement_Jump; } }
            public InputAction @Crouch { get { return m_Wrapper.m_Movement_Crouch; } }
            public InputActionMap Get() { return m_Wrapper.m_Movement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled { get { return Get().enabled; } }
            public InputActionMap Clone() { return Get().Clone(); }
            public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
            public void SetCallbacks(IMovementActions instance)
            {
                if (m_Wrapper.m_MovementActionsCallbackInterface != null)
                {
                    Horizontal.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                    Horizontal.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                    Horizontal.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontal;
                    Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    Crouch.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                    Crouch.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                    Crouch.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnCrouch;
                }
                m_Wrapper.m_MovementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Horizontal.started += instance.OnHorizontal;
                    Horizontal.performed += instance.OnHorizontal;
                    Horizontal.canceled += instance.OnHorizontal;
                    Jump.started += instance.OnJump;
                    Jump.performed += instance.OnJump;
                    Jump.canceled += instance.OnJump;
                    Crouch.started += instance.OnCrouch;
                    Crouch.performed += instance.OnCrouch;
                    Crouch.canceled += instance.OnCrouch;
                }
            }
        }
        public MovementActions @Movement
        {
            get
            {
                return new MovementActions(this);
            }
        }
        public interface IMovementActions
        {
            void OnHorizontal(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
        }
    }
}
