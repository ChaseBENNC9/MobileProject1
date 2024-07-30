//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/GolfGameInputActions.inputactions
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

public partial class @GolfGameInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GolfGameInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GolfGameInputActions"",
    ""maps"": [
        {
            ""name"": ""Mobile"",
            ""id"": ""b9debb16-846c-4c38-8dd9-cb63d1ad62be"",
            ""actions"": [
                {
                    ""name"": ""TouchInput"",
                    ""type"": ""PassThrough"",
                    ""id"": ""faee5784-b8d6-4d11-b37a-92b8ccff9541"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchPress"",
                    ""type"": ""Button"",
                    ""id"": ""1c171d36-5ae0-4282-a4a0-61627ce405b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchPos"",
                    ""type"": ""Value"",
                    ""id"": ""9f61f4db-c011-4226-8e5d-b98933f8f5d5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Drag"",
                    ""type"": ""Value"",
                    ""id"": ""f816e642-931c-44c0-9177-d6f7be91dd78"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""db8e9fce-00f5-46e0-a440-d75ec9163a24"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchInput"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79529dc8-e3b4-4235-9c26-6b8df50d6ced"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d65bc64f-06db-42a6-a126-0d58a29fe60c"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eb3cd84-826f-4ad3-8163-d37da01341dc"",
                    ""path"": ""<Touchscreen>/primaryTouch/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mobile
        m_Mobile = asset.FindActionMap("Mobile", throwIfNotFound: true);
        m_Mobile_TouchInput = m_Mobile.FindAction("TouchInput", throwIfNotFound: true);
        m_Mobile_TouchPress = m_Mobile.FindAction("TouchPress", throwIfNotFound: true);
        m_Mobile_TouchPos = m_Mobile.FindAction("TouchPos", throwIfNotFound: true);
        m_Mobile_Drag = m_Mobile.FindAction("Drag", throwIfNotFound: true);
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

    // Mobile
    private readonly InputActionMap m_Mobile;
    private List<IMobileActions> m_MobileActionsCallbackInterfaces = new List<IMobileActions>();
    private readonly InputAction m_Mobile_TouchInput;
    private readonly InputAction m_Mobile_TouchPress;
    private readonly InputAction m_Mobile_TouchPos;
    private readonly InputAction m_Mobile_Drag;
    public struct MobileActions
    {
        private @GolfGameInputActions m_Wrapper;
        public MobileActions(@GolfGameInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchInput => m_Wrapper.m_Mobile_TouchInput;
        public InputAction @TouchPress => m_Wrapper.m_Mobile_TouchPress;
        public InputAction @TouchPos => m_Wrapper.m_Mobile_TouchPos;
        public InputAction @Drag => m_Wrapper.m_Mobile_Drag;
        public InputActionMap Get() { return m_Wrapper.m_Mobile; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MobileActions set) { return set.Get(); }
        public void AddCallbacks(IMobileActions instance)
        {
            if (instance == null || m_Wrapper.m_MobileActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MobileActionsCallbackInterfaces.Add(instance);
            @TouchInput.started += instance.OnTouchInput;
            @TouchInput.performed += instance.OnTouchInput;
            @TouchInput.canceled += instance.OnTouchInput;
            @TouchPress.started += instance.OnTouchPress;
            @TouchPress.performed += instance.OnTouchPress;
            @TouchPress.canceled += instance.OnTouchPress;
            @TouchPos.started += instance.OnTouchPos;
            @TouchPos.performed += instance.OnTouchPos;
            @TouchPos.canceled += instance.OnTouchPos;
            @Drag.started += instance.OnDrag;
            @Drag.performed += instance.OnDrag;
            @Drag.canceled += instance.OnDrag;
        }

        private void UnregisterCallbacks(IMobileActions instance)
        {
            @TouchInput.started -= instance.OnTouchInput;
            @TouchInput.performed -= instance.OnTouchInput;
            @TouchInput.canceled -= instance.OnTouchInput;
            @TouchPress.started -= instance.OnTouchPress;
            @TouchPress.performed -= instance.OnTouchPress;
            @TouchPress.canceled -= instance.OnTouchPress;
            @TouchPos.started -= instance.OnTouchPos;
            @TouchPos.performed -= instance.OnTouchPos;
            @TouchPos.canceled -= instance.OnTouchPos;
            @Drag.started -= instance.OnDrag;
            @Drag.performed -= instance.OnDrag;
            @Drag.canceled -= instance.OnDrag;
        }

        public void RemoveCallbacks(IMobileActions instance)
        {
            if (m_Wrapper.m_MobileActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMobileActions instance)
        {
            foreach (var item in m_Wrapper.m_MobileActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MobileActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MobileActions @Mobile => new MobileActions(this);
    public interface IMobileActions
    {
        void OnTouchInput(InputAction.CallbackContext context);
        void OnTouchPress(InputAction.CallbackContext context);
        void OnTouchPos(InputAction.CallbackContext context);
        void OnDrag(InputAction.CallbackContext context);
    }
}
