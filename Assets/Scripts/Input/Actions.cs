// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/Actions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace CarterGames.TheShadowWithin
{
    public class @Actions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Actions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Actions"",
    ""maps"": [
        {
            ""name"": ""Platformer"",
            ""id"": ""37aa2911-c72a-4dd3-bed3-510527eb3cfd"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""255475d5-acc8-4cfe-9184-aa685c0093b1"",
                    ""expectedControlType"": ""Double"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""8e8bfc65-9059-42ed-8cd8-4d1aa047ec9b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""94d66372-41f6-48dc-91f3-e306face31dc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""85f50d15-eef7-459e-a47f-53276fbbc0fc"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LR"",
                    ""id"": ""80905d25-0426-4b15-9c4b-f73759bbac0f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""19ac2c8c-954d-47f0-89f3-da89aa61aa95"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d73a7e0a-2158-4e74-b84a-0f6b75555a23"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Platformer
            m_Platformer = asset.FindActionMap("Platformer", throwIfNotFound: true);
            m_Platformer_Move = m_Platformer.FindAction("Move", throwIfNotFound: true);
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

        // Platformer
        private readonly InputActionMap m_Platformer;
        private IPlatformerActions m_PlatformerActionsCallbackInterface;
        private readonly InputAction m_Platformer_Move;
        public struct PlatformerActions
        {
            private @Actions m_Wrapper;
            public PlatformerActions(@Actions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Platformer_Move;
            public InputActionMap Get() { return m_Wrapper.m_Platformer; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlatformerActions set) { return set.Get(); }
            public void SetCallbacks(IPlatformerActions instance)
            {
                if (m_Wrapper.m_PlatformerActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_PlatformerActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_PlatformerActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_PlatformerActionsCallbackInterface.OnMove;
                }
                m_Wrapper.m_PlatformerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                }
            }
        }
        public PlatformerActions @Platformer => new PlatformerActions(this);
        public interface IPlatformerActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
    }
}
