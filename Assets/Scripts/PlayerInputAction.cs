//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActions/PlayerInput.inputactions
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

public partial class @PlayerInputAction: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PlayerSkillActionMap"",
            ""id"": ""f44d4954-4d8f-4ec8-95f4-e06d08d449df"",
            ""actions"": [
                {
                    ""name"": ""ChangeSkill"",
                    ""type"": ""Button"",
                    ""id"": ""b37e0844-e59f-4916-8079-f0a9f2bd78e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""33d64fee-373f-4901-98bf-b3363006105c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ThrowSkill"",
                    ""type"": ""Button"",
                    ""id"": ""b5a47de5-4339-4014-86a0-997656096809"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""20ac0d84-2e1d-4cec-9df8-6fd4fe69cfa7"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f7e2a0a-faec-413c-a24c-e63f4bfea13c"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": ""MultiTap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9331ab7b-5ba2-426e-885f-208f0d2f02f4"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowSkill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerSkillActionMap
        m_PlayerSkillActionMap = asset.FindActionMap("PlayerSkillActionMap", throwIfNotFound: true);
        m_PlayerSkillActionMap_ChangeSkill = m_PlayerSkillActionMap.FindAction("ChangeSkill", throwIfNotFound: true);
        m_PlayerSkillActionMap_Scroll = m_PlayerSkillActionMap.FindAction("Scroll", throwIfNotFound: true);
        m_PlayerSkillActionMap_ThrowSkill = m_PlayerSkillActionMap.FindAction("ThrowSkill", throwIfNotFound: true);
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

    // PlayerSkillActionMap
    private readonly InputActionMap m_PlayerSkillActionMap;
    private List<IPlayerSkillActionMapActions> m_PlayerSkillActionMapActionsCallbackInterfaces = new List<IPlayerSkillActionMapActions>();
    private readonly InputAction m_PlayerSkillActionMap_ChangeSkill;
    private readonly InputAction m_PlayerSkillActionMap_Scroll;
    private readonly InputAction m_PlayerSkillActionMap_ThrowSkill;
    public struct PlayerSkillActionMapActions
    {
        private @PlayerInputAction m_Wrapper;
        public PlayerSkillActionMapActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @ChangeSkill => m_Wrapper.m_PlayerSkillActionMap_ChangeSkill;
        public InputAction @Scroll => m_Wrapper.m_PlayerSkillActionMap_Scroll;
        public InputAction @ThrowSkill => m_Wrapper.m_PlayerSkillActionMap_ThrowSkill;
        public InputActionMap Get() { return m_Wrapper.m_PlayerSkillActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerSkillActionMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerSkillActionMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerSkillActionMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerSkillActionMapActionsCallbackInterfaces.Add(instance);
            @ChangeSkill.started += instance.OnChangeSkill;
            @ChangeSkill.performed += instance.OnChangeSkill;
            @ChangeSkill.canceled += instance.OnChangeSkill;
            @Scroll.started += instance.OnScroll;
            @Scroll.performed += instance.OnScroll;
            @Scroll.canceled += instance.OnScroll;
            @ThrowSkill.started += instance.OnThrowSkill;
            @ThrowSkill.performed += instance.OnThrowSkill;
            @ThrowSkill.canceled += instance.OnThrowSkill;
        }

        private void UnregisterCallbacks(IPlayerSkillActionMapActions instance)
        {
            @ChangeSkill.started -= instance.OnChangeSkill;
            @ChangeSkill.performed -= instance.OnChangeSkill;
            @ChangeSkill.canceled -= instance.OnChangeSkill;
            @Scroll.started -= instance.OnScroll;
            @Scroll.performed -= instance.OnScroll;
            @Scroll.canceled -= instance.OnScroll;
            @ThrowSkill.started -= instance.OnThrowSkill;
            @ThrowSkill.performed -= instance.OnThrowSkill;
            @ThrowSkill.canceled -= instance.OnThrowSkill;
        }

        public void RemoveCallbacks(IPlayerSkillActionMapActions instance)
        {
            if (m_Wrapper.m_PlayerSkillActionMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerSkillActionMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerSkillActionMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerSkillActionMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerSkillActionMapActions @PlayerSkillActionMap => new PlayerSkillActionMapActions(this);
    public interface IPlayerSkillActionMapActions
    {
        void OnChangeSkill(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
        void OnThrowSkill(InputAction.CallbackContext context);
    }
}
