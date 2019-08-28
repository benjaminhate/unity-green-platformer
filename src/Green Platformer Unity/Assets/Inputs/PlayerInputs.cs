// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputs.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Inputs
{
    public class PlayerInputs : IInputActionCollection
    {
        private InputActionAsset asset;
        public PlayerInputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""3000077a-1309-48e4-b3a0-9ffdb26ff60b"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e13ea0e4-8f70-44c0-af89-88f2231aa667"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""6243cf36-a89d-4295-a436-5c9c329c3fc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""118473c0-d8d1-4690-a5aa-610a0f3a9a75"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
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
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f4b9d197-9678-45de-b69f-da780bc309e6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""afc884d4-e0cf-4065-b8cb-832e008d542d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""eed2a8e0-1ae9-4f00-8d86-adc5bec884a5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""76623d4e-d456-45aa-a267-21d313033349"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""1c62e312-b20d-4206-b7ca-dbe403ef2fde"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=1,max=1)"",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cbf07845-102d-4d8f-9fe6-34daad2bfb7e"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f9dcd030-00c4-41d0-a9c8-ea1838acf4b7"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9866196b-ffce-45fe-a6dc-8c04e2316e37"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e6b14a4-1c4f-41d7-a0e6-4fa70966875c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5500b2ff-8c73-41dd-b4c6-6044812409d5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0efef812-b39d-4e43-a2a3-f02e86040863"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee6a0786-b5cf-4a6c-b885-9b64babb1b7f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ac18143-5f70-43df-b081-314266ef47bd"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dac9943f-8928-41b7-a3f4-7dc9364fb28a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""694acf61-693f-426e-9f84-304e7c99bd58"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Attack"",
            ""id"": ""0f65c564-3007-4d1c-b881-4b7ae455f2ee"",
            ""actions"": [
                {
                    ""name"": ""Swipe"",
                    ""type"": ""Button"",
                    ""id"": ""c1ad33ed-4039-47a8-b3b2-266b1f8b64f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7e7d81cb-5429-45d4-8ea1-b0cd2967c8ed"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and mouse"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1747d31-6bdb-4d58-b8ac-60f213701628"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Swipe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and mouse"",
            ""basedOn"": """",
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
        },
        {
            ""name"": ""Gamepad"",
            ""basedOn"": """",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Movement
            m_Movement = asset.GetActionMap("Movement");
            m_Movement_Horizontal = m_Movement.GetAction("Horizontal");
            m_Movement_Jump = m_Movement.GetAction("Jump");
            m_Movement_Crouch = m_Movement.GetAction("Crouch");
            // Attack
            m_Attack = asset.GetActionMap("Attack");
            m_Attack_Swipe = m_Attack.GetAction("Swipe");
        }

        ~PlayerInputs()
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

        // Movement
        private readonly InputActionMap m_Movement;
        private IMovementActions m_MovementActionsCallbackInterface;
        private readonly InputAction m_Movement_Horizontal;
        private readonly InputAction m_Movement_Jump;
        private readonly InputAction m_Movement_Crouch;
        public struct MovementActions
        {
            private PlayerInputs m_Wrapper;
            public MovementActions(PlayerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Horizontal => m_Wrapper.m_Movement_Horizontal;
            public InputAction @Jump => m_Wrapper.m_Movement_Jump;
            public InputAction @Crouch => m_Wrapper.m_Movement_Crouch;
            public InputActionMap Get() { return m_Wrapper.m_Movement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
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
        public MovementActions @Movement => new MovementActions(this);

        // Attack
        private readonly InputActionMap m_Attack;
        private IAttackActions m_AttackActionsCallbackInterface;
        private readonly InputAction m_Attack_Swipe;
        public struct AttackActions
        {
            private PlayerInputs m_Wrapper;
            public AttackActions(PlayerInputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Swipe => m_Wrapper.m_Attack_Swipe;
            public InputActionMap Get() { return m_Wrapper.m_Attack; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(AttackActions set) { return set.Get(); }
            public void SetCallbacks(IAttackActions instance)
            {
                if (m_Wrapper.m_AttackActionsCallbackInterface != null)
                {
                    Swipe.started -= m_Wrapper.m_AttackActionsCallbackInterface.OnSwipe;
                    Swipe.performed -= m_Wrapper.m_AttackActionsCallbackInterface.OnSwipe;
                    Swipe.canceled -= m_Wrapper.m_AttackActionsCallbackInterface.OnSwipe;
                }
                m_Wrapper.m_AttackActionsCallbackInterface = instance;
                if (instance != null)
                {
                    Swipe.started += instance.OnSwipe;
                    Swipe.performed += instance.OnSwipe;
                    Swipe.canceled += instance.OnSwipe;
                }
            }
        }
        public AttackActions @Attack => new AttackActions(this);
        private int m_KeyboardandmouseSchemeIndex = -1;
        public InputControlScheme KeyboardandmouseScheme
        {
            get
            {
                if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.GetControlSchemeIndex("Keyboard and mouse");
                return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
            }
        }
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.GetControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        public interface IMovementActions
        {
            void OnHorizontal(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
        }
        public interface IAttackActions
        {
            void OnSwipe(InputAction.CallbackContext context);
        }
    }
}
