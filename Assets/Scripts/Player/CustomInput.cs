//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/CustomInput.inputactions
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

public partial class @CustomInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CustomInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""cb175dbc-eebb-4061-b667-6e10d7aa7d17"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""025bd280-3657-4714-b1a1-8976c828dc2b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interract"",
                    ""type"": ""Button"",
                    ""id"": ""c7e85317-428a-4c7c-8559-b408c2880dd0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""6dbef928-0aea-4860-9bc2-fdcc099f16e2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Value"",
                    ""id"": ""b8647fba-b72b-44ee-8f71-f052558a82f4"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SelectLeftWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""b7051c6e-cadf-4aa5-a12c-52a179972763"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectRightWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""f396c1be-511f-4114-bbae-f8adc59ab7f3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FirstWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""3d42614a-3bac-4678-bd2c-8900b5f6106e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SecondWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""fb07548e-eb8e-46b8-a845-d027edfccadf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ThirdWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""b970a7ca-1fdb-4824-af8f-117aadc12178"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeWeapon"",
                    ""type"": ""Value"",
                    ""id"": ""d0b47a5b-daec-465e-9ad9-0d2dcc0c13ca"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""WeaponAim"",
                    ""type"": ""Button"",
                    ""id"": ""cfaabe57-1795-4add-9a8a-442347dd7407"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponHit"",
                    ""type"": ""Button"",
                    ""id"": ""b2f188dd-0410-4902-820e-3a02ed03f2b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""ZQSD"",
                    ""id"": ""485997f8-a13e-40ca-bb6a-765276401bc7"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""acf0489c-a63f-4884-aec6-5371e0f81c93"",
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
                    ""id"": ""52544bf6-8bd1-4935-8823-3f49e8740617"",
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
                    ""id"": ""62cd329e-1943-4db2-82c3-d6d6fa5afa75"",
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
                    ""id"": ""c843f579-69a8-4576-ab44-75a6e9a113b6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""7d7c56d7-9b76-45d2-867f-d5380e2a5362"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1367fd51-6f6c-4cec-9165-dfa7ee357297"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ec282b93-aa84-43ae-92eb-b16ca335926a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7897877e-5ee3-4101-b252-1a2a95b01428"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c863d415-83f6-4934-b65a-a0993dcab5e2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controler Left Analogue"",
                    ""id"": ""3beadbff-7262-485d-8b58-69ec51d3cad8"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7aa9bbf9-b906-405e-bbd9-c1fa806f9bdf"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""710e2827-3afa-4c57-83b3-7ad2bd3935b9"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d7f7276a-f7c8-40c8-89ee-3c0fa0c4a7cd"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""800d1f7d-6bbf-43be-bacb-c495248a031a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1741f91e-93d4-4659-85bc-6800158fed37"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93d1c0a3-7016-417a-8dce-e2bac9672c3a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right stick"",
                    ""id"": ""9b97dfc6-f0af-4e24-9037-cc7e637cdcfc"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone(min=0.6,max=0.9)"",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""94848ed7-f2b9-497c-ae19-54346de07797"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""82000b00-bdb2-44df-a729-2a29066967d1"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ef670b6-fb18-4f08-9e24-741ce88c5599"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9d3cfbb2-1303-4e31-ae31-fa6ec0c18597"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c6a9d162-02b7-4159-99cf-e205335fc5f6"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""298f759f-ecb0-49e5-ab1c-77f5131e1e17"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interract = m_Player.FindAction("Interract", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        m_Player_SelectLeftWeapon = m_Player.FindAction("SelectLeftWeapon", throwIfNotFound: true);
        m_Player_SelectRightWeapon = m_Player.FindAction("SelectRightWeapon", throwIfNotFound: true);
        m_Player_FirstWeapon = m_Player.FindAction("FirstWeapon", throwIfNotFound: true);
        m_Player_SecondWeapon = m_Player.FindAction("SecondWeapon", throwIfNotFound: true);
        m_Player_ThirdWeapon = m_Player.FindAction("ThirdWeapon", throwIfNotFound: true);
        m_Player_ChangeWeapon = m_Player.FindAction("ChangeWeapon", throwIfNotFound: true);
        m_Player_WeaponAim = m_Player.FindAction("WeaponAim", throwIfNotFound: true);
        m_Player_WeaponHit = m_Player.FindAction("WeaponHit", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interract;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_Sprint;
    private readonly InputAction m_Player_SelectLeftWeapon;
    private readonly InputAction m_Player_SelectRightWeapon;
    private readonly InputAction m_Player_FirstWeapon;
    private readonly InputAction m_Player_SecondWeapon;
    private readonly InputAction m_Player_ThirdWeapon;
    private readonly InputAction m_Player_ChangeWeapon;
    private readonly InputAction m_Player_WeaponAim;
    private readonly InputAction m_Player_WeaponHit;
    public struct PlayerActions
    {
        private @CustomInput m_Wrapper;
        public PlayerActions(@CustomInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interract => m_Wrapper.m_Player_Interract;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputAction @SelectLeftWeapon => m_Wrapper.m_Player_SelectLeftWeapon;
        public InputAction @SelectRightWeapon => m_Wrapper.m_Player_SelectRightWeapon;
        public InputAction @FirstWeapon => m_Wrapper.m_Player_FirstWeapon;
        public InputAction @SecondWeapon => m_Wrapper.m_Player_SecondWeapon;
        public InputAction @ThirdWeapon => m_Wrapper.m_Player_ThirdWeapon;
        public InputAction @ChangeWeapon => m_Wrapper.m_Player_ChangeWeapon;
        public InputAction @WeaponAim => m_Wrapper.m_Player_WeaponAim;
        public InputAction @WeaponHit => m_Wrapper.m_Player_WeaponHit;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Interract.started += instance.OnInterract;
            @Interract.performed += instance.OnInterract;
            @Interract.canceled += instance.OnInterract;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @SelectLeftWeapon.started += instance.OnSelectLeftWeapon;
            @SelectLeftWeapon.performed += instance.OnSelectLeftWeapon;
            @SelectLeftWeapon.canceled += instance.OnSelectLeftWeapon;
            @SelectRightWeapon.started += instance.OnSelectRightWeapon;
            @SelectRightWeapon.performed += instance.OnSelectRightWeapon;
            @SelectRightWeapon.canceled += instance.OnSelectRightWeapon;
            @FirstWeapon.started += instance.OnFirstWeapon;
            @FirstWeapon.performed += instance.OnFirstWeapon;
            @FirstWeapon.canceled += instance.OnFirstWeapon;
            @SecondWeapon.started += instance.OnSecondWeapon;
            @SecondWeapon.performed += instance.OnSecondWeapon;
            @SecondWeapon.canceled += instance.OnSecondWeapon;
            @ThirdWeapon.started += instance.OnThirdWeapon;
            @ThirdWeapon.performed += instance.OnThirdWeapon;
            @ThirdWeapon.canceled += instance.OnThirdWeapon;
            @ChangeWeapon.started += instance.OnChangeWeapon;
            @ChangeWeapon.performed += instance.OnChangeWeapon;
            @ChangeWeapon.canceled += instance.OnChangeWeapon;
            @WeaponAim.started += instance.OnWeaponAim;
            @WeaponAim.performed += instance.OnWeaponAim;
            @WeaponAim.canceled += instance.OnWeaponAim;
            @WeaponHit.started += instance.OnWeaponHit;
            @WeaponHit.performed += instance.OnWeaponHit;
            @WeaponHit.canceled += instance.OnWeaponHit;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Interract.started -= instance.OnInterract;
            @Interract.performed -= instance.OnInterract;
            @Interract.canceled -= instance.OnInterract;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @SelectLeftWeapon.started -= instance.OnSelectLeftWeapon;
            @SelectLeftWeapon.performed -= instance.OnSelectLeftWeapon;
            @SelectLeftWeapon.canceled -= instance.OnSelectLeftWeapon;
            @SelectRightWeapon.started -= instance.OnSelectRightWeapon;
            @SelectRightWeapon.performed -= instance.OnSelectRightWeapon;
            @SelectRightWeapon.canceled -= instance.OnSelectRightWeapon;
            @FirstWeapon.started -= instance.OnFirstWeapon;
            @FirstWeapon.performed -= instance.OnFirstWeapon;
            @FirstWeapon.canceled -= instance.OnFirstWeapon;
            @SecondWeapon.started -= instance.OnSecondWeapon;
            @SecondWeapon.performed -= instance.OnSecondWeapon;
            @SecondWeapon.canceled -= instance.OnSecondWeapon;
            @ThirdWeapon.started -= instance.OnThirdWeapon;
            @ThirdWeapon.performed -= instance.OnThirdWeapon;
            @ThirdWeapon.canceled -= instance.OnThirdWeapon;
            @ChangeWeapon.started -= instance.OnChangeWeapon;
            @ChangeWeapon.performed -= instance.OnChangeWeapon;
            @ChangeWeapon.canceled -= instance.OnChangeWeapon;
            @WeaponAim.started -= instance.OnWeaponAim;
            @WeaponAim.performed -= instance.OnWeaponAim;
            @WeaponAim.canceled -= instance.OnWeaponAim;
            @WeaponHit.started -= instance.OnWeaponHit;
            @WeaponHit.performed -= instance.OnWeaponHit;
            @WeaponHit.canceled -= instance.OnWeaponHit;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInterract(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSelectLeftWeapon(InputAction.CallbackContext context);
        void OnSelectRightWeapon(InputAction.CallbackContext context);
        void OnFirstWeapon(InputAction.CallbackContext context);
        void OnSecondWeapon(InputAction.CallbackContext context);
        void OnThirdWeapon(InputAction.CallbackContext context);
        void OnChangeWeapon(InputAction.CallbackContext context);
        void OnWeaponAim(InputAction.CallbackContext context);
        void OnWeaponHit(InputAction.CallbackContext context);
    }
}
