// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/CinemaControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CinemaControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CinemaControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CinemaControls"",
    ""maps"": [
        {
            ""name"": ""CinemaControlsBasic"",
            ""id"": ""4a096d8e-9023-4423-8901-38e2796c597a"",
            ""actions"": [
                {
                    ""name"": ""PlayPause"",
                    ""type"": ""Button"",
                    ""id"": ""a684cf31-958d-4db8-b76c-7fdba71f126d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Skip"",
                    ""type"": ""Value"",
                    ""id"": ""258c799c-8962-4113-842e-03efc64a1e12"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7aa66d93-3df7-4819-afb1-22bd93b25f5e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59f3e859-cd24-4083-b488-eea156b86ce6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""fd66f151-1491-44e8-8993-ebe1f2774d5d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fe5bce49-b66d-4b0d-b978-4b44c33ebb55"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""37f5debe-208f-4c52-85c4-8b3571a36e72"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""876e8498-579d-439c-b4ab-bf198c8cc17b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""db6e3525-cd51-46d7-8753-e5391de78a61"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""ECSTest"",
            ""id"": ""adac73eb-1093-4726-8687-2ffb76260556"",
            ""actions"": [
                {
                    ""name"": ""SpawnEntity"",
                    ""type"": ""Button"",
                    ""id"": ""7d64d82d-54a6-4421-873a-2909f3d1aef1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0565aacf-43da-4521-a50c-cd9351577196"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpawnEntity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CinemaControlsBasic
        m_CinemaControlsBasic = asset.FindActionMap("CinemaControlsBasic", throwIfNotFound: true);
        m_CinemaControlsBasic_PlayPause = m_CinemaControlsBasic.FindAction("PlayPause", throwIfNotFound: true);
        m_CinemaControlsBasic_Skip = m_CinemaControlsBasic.FindAction("Skip", throwIfNotFound: true);
        // ECSTest
        m_ECSTest = asset.FindActionMap("ECSTest", throwIfNotFound: true);
        m_ECSTest_SpawnEntity = m_ECSTest.FindAction("SpawnEntity", throwIfNotFound: true);
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

    // CinemaControlsBasic
    private readonly InputActionMap m_CinemaControlsBasic;
    private ICinemaControlsBasicActions m_CinemaControlsBasicActionsCallbackInterface;
    private readonly InputAction m_CinemaControlsBasic_PlayPause;
    private readonly InputAction m_CinemaControlsBasic_Skip;
    public struct CinemaControlsBasicActions
    {
        private @CinemaControls m_Wrapper;
        public CinemaControlsBasicActions(@CinemaControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayPause => m_Wrapper.m_CinemaControlsBasic_PlayPause;
        public InputAction @Skip => m_Wrapper.m_CinemaControlsBasic_Skip;
        public InputActionMap Get() { return m_Wrapper.m_CinemaControlsBasic; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CinemaControlsBasicActions set) { return set.Get(); }
        public void SetCallbacks(ICinemaControlsBasicActions instance)
        {
            if (m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface != null)
            {
                @PlayPause.started -= m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface.OnPlayPause;
                @PlayPause.performed -= m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface.OnPlayPause;
                @PlayPause.canceled -= m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface.OnPlayPause;
                @Skip.started -= m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface.OnSkip;
            }
            m_Wrapper.m_CinemaControlsBasicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PlayPause.started += instance.OnPlayPause;
                @PlayPause.performed += instance.OnPlayPause;
                @PlayPause.canceled += instance.OnPlayPause;
                @Skip.started += instance.OnSkip;
                @Skip.performed += instance.OnSkip;
                @Skip.canceled += instance.OnSkip;
            }
        }
    }
    public CinemaControlsBasicActions @CinemaControlsBasic => new CinemaControlsBasicActions(this);

    // ECSTest
    private readonly InputActionMap m_ECSTest;
    private IECSTestActions m_ECSTestActionsCallbackInterface;
    private readonly InputAction m_ECSTest_SpawnEntity;
    public struct ECSTestActions
    {
        private @CinemaControls m_Wrapper;
        public ECSTestActions(@CinemaControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @SpawnEntity => m_Wrapper.m_ECSTest_SpawnEntity;
        public InputActionMap Get() { return m_Wrapper.m_ECSTest; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ECSTestActions set) { return set.Get(); }
        public void SetCallbacks(IECSTestActions instance)
        {
            if (m_Wrapper.m_ECSTestActionsCallbackInterface != null)
            {
                @SpawnEntity.started -= m_Wrapper.m_ECSTestActionsCallbackInterface.OnSpawnEntity;
                @SpawnEntity.performed -= m_Wrapper.m_ECSTestActionsCallbackInterface.OnSpawnEntity;
                @SpawnEntity.canceled -= m_Wrapper.m_ECSTestActionsCallbackInterface.OnSpawnEntity;
            }
            m_Wrapper.m_ECSTestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SpawnEntity.started += instance.OnSpawnEntity;
                @SpawnEntity.performed += instance.OnSpawnEntity;
                @SpawnEntity.canceled += instance.OnSpawnEntity;
            }
        }
    }
    public ECSTestActions @ECSTest => new ECSTestActions(this);
    public interface ICinemaControlsBasicActions
    {
        void OnPlayPause(InputAction.CallbackContext context);
        void OnSkip(InputAction.CallbackContext context);
    }
    public interface IECSTestActions
    {
        void OnSpawnEntity(InputAction.CallbackContext context);
    }
}
