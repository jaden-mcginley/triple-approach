//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Framework/Input/inp_DefaultInput.inputactions
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

public partial class @scr_DefaultInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @scr_DefaultInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""inp_DefaultInput"",
    ""maps"": [
        {
            ""name"": ""PlayerBasics"",
            ""id"": ""a4c8ce31-9f18-476d-84f8-9163b9dc2352"",
            ""actions"": [
                {
                    ""name"": ""MovementUp"",
                    ""type"": ""Button"",
                    ""id"": ""d9f42254-63f7-4e18-9612-f08a871554a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovementDown"",
                    ""type"": ""Button"",
                    ""id"": ""53dd0e4a-1fb7-4a5d-b9c8-1d5a9138d188"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovementLeft"",
                    ""type"": ""Button"",
                    ""id"": ""03b352b7-78ec-4088-b451-131871e90f2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MovementRight"",
                    ""type"": ""Button"",
                    ""id"": ""67b23376-ed0b-4d5d-b213-2a189e890192"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectFistStyle"",
                    ""type"": ""Button"",
                    ""id"": ""ebf36e5a-f8c0-4e88-9e5c-f5521cffef82"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectSwordStyle"",
                    ""type"": ""Button"",
                    ""id"": ""f9a168ee-999c-4af6-8525-8f7ff086b186"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SelectGunStyle"",
                    ""type"": ""Button"",
                    ""id"": ""012eae2d-976e-4249-81d7-bcbc45ec1911"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Primary"",
                    ""type"": ""Button"",
                    ""id"": ""92f434dc-26ee-467c-931d-980c3e25c751"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Secondary"",
                    ""type"": ""Button"",
                    ""id"": ""b850f4c0-a34a-4518-8f8e-a3e70cb83317"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1dda6b39-a01a-4c66-b933-aeb492c9c3ca"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23d98bae-89df-423e-8b19-0b3f7df7592e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""880cad5b-3d16-473f-9fb0-9763863a5195"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f26a005-6c83-4b94-bf36-008487b6513f"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""776db574-b1b9-482f-91f6-244354525be4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9edcfa03-6b80-43d4-812f-012eeaaaa515"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af854885-4601-4f03-b7db-e7eeea34dfb1"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectFistStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acdc1b62-c9e0-4fd6-9b9d-583d9c03d277"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectFistStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""114b187d-cb05-4a4e-833b-59697beca1f1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectFistStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e3f26f2-1129-4c24-8cae-e0e46f694f64"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSwordStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67fe2db2-413a-4fb7-ad92-c071b6905438"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSwordStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0553ca9a-de38-4077-82cf-23631154d540"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectSwordStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afddb2aa-538a-453e-b453-c764df2126e8"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectGunStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fde0e14e-76e1-4cd7-8f2f-f1b526a899f6"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectGunStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e02e9fbf-4612-40bb-92df-dbcd5493d18b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectGunStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f55bd9d0-2dff-43c8-a6ff-af0fd0f08028"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectGunStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95235387-c940-41eb-89c5-2d13f1a3b39d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectGunStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32e78b7b-be2a-4b64-92e6-6714bf4b492a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectGunStyle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b02ca0d9-18ab-4cd5-ae86-b7f7cf4e1390"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d509c6bd-b3b7-4a5f-b879-b3f0a7694139"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""187d6b87-3fac-4c45-ae74-a03bcc970756"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04b842dc-83d2-4e70-94e0-01c6f19e8209"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42fb0c9e-d1f3-483f-b442-2ec7767f3aee"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a18cd4f4-be1a-443c-b078-094569538cda"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f477e3a-500e-4ea1-bad9-469568654909"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dc99caa-334c-45cf-a525-86b48427a109"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerBasics
        m_PlayerBasics = asset.FindActionMap("PlayerBasics", throwIfNotFound: true);
        m_PlayerBasics_MovementUp = m_PlayerBasics.FindAction("MovementUp", throwIfNotFound: true);
        m_PlayerBasics_MovementDown = m_PlayerBasics.FindAction("MovementDown", throwIfNotFound: true);
        m_PlayerBasics_MovementLeft = m_PlayerBasics.FindAction("MovementLeft", throwIfNotFound: true);
        m_PlayerBasics_MovementRight = m_PlayerBasics.FindAction("MovementRight", throwIfNotFound: true);
        m_PlayerBasics_SelectFistStyle = m_PlayerBasics.FindAction("SelectFistStyle", throwIfNotFound: true);
        m_PlayerBasics_SelectSwordStyle = m_PlayerBasics.FindAction("SelectSwordStyle", throwIfNotFound: true);
        m_PlayerBasics_SelectGunStyle = m_PlayerBasics.FindAction("SelectGunStyle", throwIfNotFound: true);
        m_PlayerBasics_Primary = m_PlayerBasics.FindAction("Primary", throwIfNotFound: true);
        m_PlayerBasics_Secondary = m_PlayerBasics.FindAction("Secondary", throwIfNotFound: true);
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

    // PlayerBasics
    private readonly InputActionMap m_PlayerBasics;
    private IPlayerBasicsActions m_PlayerBasicsActionsCallbackInterface;
    private readonly InputAction m_PlayerBasics_MovementUp;
    private readonly InputAction m_PlayerBasics_MovementDown;
    private readonly InputAction m_PlayerBasics_MovementLeft;
    private readonly InputAction m_PlayerBasics_MovementRight;
    private readonly InputAction m_PlayerBasics_SelectFistStyle;
    private readonly InputAction m_PlayerBasics_SelectSwordStyle;
    private readonly InputAction m_PlayerBasics_SelectGunStyle;
    private readonly InputAction m_PlayerBasics_Primary;
    private readonly InputAction m_PlayerBasics_Secondary;
    public struct PlayerBasicsActions
    {
        private @scr_DefaultInput m_Wrapper;
        public PlayerBasicsActions(@scr_DefaultInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementUp => m_Wrapper.m_PlayerBasics_MovementUp;
        public InputAction @MovementDown => m_Wrapper.m_PlayerBasics_MovementDown;
        public InputAction @MovementLeft => m_Wrapper.m_PlayerBasics_MovementLeft;
        public InputAction @MovementRight => m_Wrapper.m_PlayerBasics_MovementRight;
        public InputAction @SelectFistStyle => m_Wrapper.m_PlayerBasics_SelectFistStyle;
        public InputAction @SelectSwordStyle => m_Wrapper.m_PlayerBasics_SelectSwordStyle;
        public InputAction @SelectGunStyle => m_Wrapper.m_PlayerBasics_SelectGunStyle;
        public InputAction @Primary => m_Wrapper.m_PlayerBasics_Primary;
        public InputAction @Secondary => m_Wrapper.m_PlayerBasics_Secondary;
        public InputActionMap Get() { return m_Wrapper.m_PlayerBasics; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerBasicsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerBasicsActions instance)
        {
            if (m_Wrapper.m_PlayerBasicsActionsCallbackInterface != null)
            {
                @MovementUp.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementUp;
                @MovementUp.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementUp;
                @MovementUp.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementUp;
                @MovementDown.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementDown;
                @MovementDown.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementDown;
                @MovementDown.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementDown;
                @MovementLeft.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementLeft;
                @MovementLeft.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementLeft;
                @MovementLeft.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementLeft;
                @MovementRight.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementRight;
                @MovementRight.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementRight;
                @MovementRight.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnMovementRight;
                @SelectFistStyle.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectFistStyle;
                @SelectFistStyle.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectFistStyle;
                @SelectFistStyle.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectFistStyle;
                @SelectSwordStyle.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectSwordStyle;
                @SelectSwordStyle.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectSwordStyle;
                @SelectSwordStyle.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectSwordStyle;
                @SelectGunStyle.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectGunStyle;
                @SelectGunStyle.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectGunStyle;
                @SelectGunStyle.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSelectGunStyle;
                @Primary.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnPrimary;
                @Primary.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnPrimary;
                @Primary.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnPrimary;
                @Secondary.started -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSecondary;
                @Secondary.performed -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSecondary;
                @Secondary.canceled -= m_Wrapper.m_PlayerBasicsActionsCallbackInterface.OnSecondary;
            }
            m_Wrapper.m_PlayerBasicsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementUp.started += instance.OnMovementUp;
                @MovementUp.performed += instance.OnMovementUp;
                @MovementUp.canceled += instance.OnMovementUp;
                @MovementDown.started += instance.OnMovementDown;
                @MovementDown.performed += instance.OnMovementDown;
                @MovementDown.canceled += instance.OnMovementDown;
                @MovementLeft.started += instance.OnMovementLeft;
                @MovementLeft.performed += instance.OnMovementLeft;
                @MovementLeft.canceled += instance.OnMovementLeft;
                @MovementRight.started += instance.OnMovementRight;
                @MovementRight.performed += instance.OnMovementRight;
                @MovementRight.canceled += instance.OnMovementRight;
                @SelectFistStyle.started += instance.OnSelectFistStyle;
                @SelectFistStyle.performed += instance.OnSelectFistStyle;
                @SelectFistStyle.canceled += instance.OnSelectFistStyle;
                @SelectSwordStyle.started += instance.OnSelectSwordStyle;
                @SelectSwordStyle.performed += instance.OnSelectSwordStyle;
                @SelectSwordStyle.canceled += instance.OnSelectSwordStyle;
                @SelectGunStyle.started += instance.OnSelectGunStyle;
                @SelectGunStyle.performed += instance.OnSelectGunStyle;
                @SelectGunStyle.canceled += instance.OnSelectGunStyle;
                @Primary.started += instance.OnPrimary;
                @Primary.performed += instance.OnPrimary;
                @Primary.canceled += instance.OnPrimary;
                @Secondary.started += instance.OnSecondary;
                @Secondary.performed += instance.OnSecondary;
                @Secondary.canceled += instance.OnSecondary;
            }
        }
    }
    public PlayerBasicsActions @PlayerBasics => new PlayerBasicsActions(this);
    public interface IPlayerBasicsActions
    {
        void OnMovementUp(InputAction.CallbackContext context);
        void OnMovementDown(InputAction.CallbackContext context);
        void OnMovementLeft(InputAction.CallbackContext context);
        void OnMovementRight(InputAction.CallbackContext context);
        void OnSelectFistStyle(InputAction.CallbackContext context);
        void OnSelectSwordStyle(InputAction.CallbackContext context);
        void OnSelectGunStyle(InputAction.CallbackContext context);
        void OnPrimary(InputAction.CallbackContext context);
        void OnSecondary(InputAction.CallbackContext context);
    }
}