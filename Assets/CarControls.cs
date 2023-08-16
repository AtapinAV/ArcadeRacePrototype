//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/CarControls.inputactions
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

namespace Cars
{
    public partial class @CarControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @CarControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarControls"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""d9b6d47d-7f2a-4482-851f-adc58cc7a278"",
            ""actions"": [
                {
                    ""name"": ""HandBrake"",
                    ""type"": ""Button"",
                    ""id"": ""d938e3b3-d840-4006-aa0c-94369628eb61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Value"",
                    ""id"": ""b7a12d78-d0da-4a7d-a421-df7d00c6e3f4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""c9e9f663-78de-4383-81f5-b81bcd18aa42"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3ac2ab11-777c-4592-9622-dc0af74afc32"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HandBrake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""3a89fd7e-cfd3-4398-ab26-68a7d6584f7e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4b991c94-7728-4a5a-a9ee-3c7bd5aa2ac4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1eafb840-65ff-4a9a-911c-9222b27ec2d2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""6521fda6-37eb-4149-a8c2-7cc2f2e0b156"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f9840719-d964-48df-8ee3-19803c871f5d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""782bc35a-b1a5-4c11-b70c-7904a02379e9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Car
            m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
            m_Car_HandBrake = m_Car.FindAction("HandBrake", throwIfNotFound: true);
            m_Car_Acceleration = m_Car.FindAction("Acceleration", throwIfNotFound: true);
            m_Car_Rotate = m_Car.FindAction("Rotate", throwIfNotFound: true);
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

        // Car
        private readonly InputActionMap m_Car;
        private List<ICarActions> m_CarActionsCallbackInterfaces = new List<ICarActions>();
        private readonly InputAction m_Car_HandBrake;
        private readonly InputAction m_Car_Acceleration;
        private readonly InputAction m_Car_Rotate;
        public struct CarActions
        {
            private @CarControls m_Wrapper;
            public CarActions(@CarControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @HandBrake => m_Wrapper.m_Car_HandBrake;
            public InputAction @Acceleration => m_Wrapper.m_Car_Acceleration;
            public InputAction @Rotate => m_Wrapper.m_Car_Rotate;
            public InputActionMap Get() { return m_Wrapper.m_Car; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
            public void AddCallbacks(ICarActions instance)
            {
                if (instance == null || m_Wrapper.m_CarActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_CarActionsCallbackInterfaces.Add(instance);
                @HandBrake.started += instance.OnHandBrake;
                @HandBrake.performed += instance.OnHandBrake;
                @HandBrake.canceled += instance.OnHandBrake;
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }

            private void UnregisterCallbacks(ICarActions instance)
            {
                @HandBrake.started -= instance.OnHandBrake;
                @HandBrake.performed -= instance.OnHandBrake;
                @HandBrake.canceled -= instance.OnHandBrake;
                @Acceleration.started -= instance.OnAcceleration;
                @Acceleration.performed -= instance.OnAcceleration;
                @Acceleration.canceled -= instance.OnAcceleration;
                @Rotate.started -= instance.OnRotate;
                @Rotate.performed -= instance.OnRotate;
                @Rotate.canceled -= instance.OnRotate;
            }

            public void RemoveCallbacks(ICarActions instance)
            {
                if (m_Wrapper.m_CarActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ICarActions instance)
            {
                foreach (var item in m_Wrapper.m_CarActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_CarActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public CarActions @Car => new CarActions(this);
        public interface ICarActions
        {
            void OnHandBrake(InputAction.CallbackContext context);
            void OnAcceleration(InputAction.CallbackContext context);
            void OnRotate(InputAction.CallbackContext context);
        }
    }
}
