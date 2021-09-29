// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlatformerPlayer1"",
            ""id"": ""96b6570f-0264-4ead-90b1-5160c07ee332"",
            ""actions"": [
                {
                    ""name"": ""MovementX"",
                    ""type"": ""Value"",
                    ""id"": ""b244bac9-fd8e-471d-a0a6-621997eb8361"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementY"",
                    ""type"": ""Button"",
                    ""id"": ""267e2cfc-feb9-441f-be5a-154f93091429"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b9ad2947-edd3-4c13-a29e-aae68f73ba88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""b9cf824a-1061-42eb-b839-41498a0b30e4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""def3ac2f-f2ea-4c77-99f1-6ba1de0b7048"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""cd39d192-2806-4a73-8974-c75311ae4ba5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9f53be62-e56d-4e99-91f6-d2c34fb996f5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""f32d6466-4863-44ba-b2ce-00bfebeb6ebe"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""526138c5-d6b7-4cf5-8be0-2a2ad3e82b17"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""88b138bb-fd63-4fa2-9b1a-523ba6df339f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlatformerPlayer2"",
            ""id"": ""58ebbdd4-00f3-4bf3-addf-24c8450a087d"",
            ""actions"": [
                {
                    ""name"": ""MovementX"",
                    ""type"": ""Value"",
                    ""id"": ""e42a5fd2-c3fb-4af5-9357-bfec090a518c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MovementY"",
                    ""type"": ""Button"",
                    ""id"": ""c644de6d-0149-4243-b48d-de98489cfabd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4b9f2351-4646-4e0c-98b2-4b042c66f8af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""86e3faf3-b0dc-4381-b1c4-df5ea796dcb7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""30cd006b-97f1-4985-aaff-b37a16f891d8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""967d21d2-0d36-413d-a41c-06c82f0a111a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b4872c2f-a226-4988-b9ab-8c97e757f770"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""fbf09bcf-1c69-4675-b50d-0d2b7f12320b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""41130de3-aa06-4b26-a275-ec58f17543a2"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ccd494d5-29e4-4ba2-bb24-03fc565b28f7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MovementY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Maze"",
            ""id"": ""38d5f237-aa09-4cd9-9935-baeb6585e811"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""30b14611-5ae5-4fd7-b247-d780995d9bcc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""ff3d8634-2e01-46f2-a342-f0ff24c1f572"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""6402b2a5-e200-486d-b188-5e5564499b93"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""d8da9d58-3bd4-4891-9013-5db027bca10e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""560b6643-3e57-47b3-a2a2-91a1b3d5a2c5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08b52267-3415-483a-8b71-b2139d983e11"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab841a60-9845-4bd6-a981-00c5a0925fd1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b425e37-62fa-4b73-aaec-6c3d214a8b5d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03684b84-05bc-4938-86b4-26042d02a6cf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5936479-00e8-48af-b4a5-5bbf3311b45f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cfd6706-c97e-4267-9713-ca5f431d0be0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19184a24-f452-41fa-b690-76cb66e62db4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlatformerPlayer1
        m_PlatformerPlayer1 = asset.FindActionMap("PlatformerPlayer1", throwIfNotFound: true);
        m_PlatformerPlayer1_MovementX = m_PlatformerPlayer1.FindAction("MovementX", throwIfNotFound: true);
        m_PlatformerPlayer1_MovementY = m_PlatformerPlayer1.FindAction("MovementY", throwIfNotFound: true);
        m_PlatformerPlayer1_Jump = m_PlatformerPlayer1.FindAction("Jump", throwIfNotFound: true);
        // PlatformerPlayer2
        m_PlatformerPlayer2 = asset.FindActionMap("PlatformerPlayer2", throwIfNotFound: true);
        m_PlatformerPlayer2_MovementX = m_PlatformerPlayer2.FindAction("MovementX", throwIfNotFound: true);
        m_PlatformerPlayer2_MovementY = m_PlatformerPlayer2.FindAction("MovementY", throwIfNotFound: true);
        m_PlatformerPlayer2_Jump = m_PlatformerPlayer2.FindAction("Jump", throwIfNotFound: true);
        // Maze
        m_Maze = asset.FindActionMap("Maze", throwIfNotFound: true);
        m_Maze_Up = m_Maze.FindAction("Up", throwIfNotFound: true);
        m_Maze_Down = m_Maze.FindAction("Down", throwIfNotFound: true);
        m_Maze_Left = m_Maze.FindAction("Left", throwIfNotFound: true);
        m_Maze_Right = m_Maze.FindAction("Right", throwIfNotFound: true);
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

    // PlatformerPlayer1
    private readonly InputActionMap m_PlatformerPlayer1;
    private IPlatformerPlayer1Actions m_PlatformerPlayer1ActionsCallbackInterface;
    private readonly InputAction m_PlatformerPlayer1_MovementX;
    private readonly InputAction m_PlatformerPlayer1_MovementY;
    private readonly InputAction m_PlatformerPlayer1_Jump;
    public struct PlatformerPlayer1Actions
    {
        private @PlayerControls m_Wrapper;
        public PlatformerPlayer1Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementX => m_Wrapper.m_PlatformerPlayer1_MovementX;
        public InputAction @MovementY => m_Wrapper.m_PlatformerPlayer1_MovementY;
        public InputAction @Jump => m_Wrapper.m_PlatformerPlayer1_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlatformerPlayer1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlatformerPlayer1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlatformerPlayer1Actions instance)
        {
            if (m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface != null)
            {
                @MovementX.started -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnMovementX;
                @MovementX.performed -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnMovementX;
                @MovementX.canceled -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnMovementX;
                @MovementY.started -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnMovementY;
                @MovementY.performed -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnMovementY;
                @MovementY.canceled -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnMovementY;
                @Jump.started -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlatformerPlayer1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementX.started += instance.OnMovementX;
                @MovementX.performed += instance.OnMovementX;
                @MovementX.canceled += instance.OnMovementX;
                @MovementY.started += instance.OnMovementY;
                @MovementY.performed += instance.OnMovementY;
                @MovementY.canceled += instance.OnMovementY;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlatformerPlayer1Actions @PlatformerPlayer1 => new PlatformerPlayer1Actions(this);

    // PlatformerPlayer2
    private readonly InputActionMap m_PlatformerPlayer2;
    private IPlatformerPlayer2Actions m_PlatformerPlayer2ActionsCallbackInterface;
    private readonly InputAction m_PlatformerPlayer2_MovementX;
    private readonly InputAction m_PlatformerPlayer2_MovementY;
    private readonly InputAction m_PlatformerPlayer2_Jump;
    public struct PlatformerPlayer2Actions
    {
        private @PlayerControls m_Wrapper;
        public PlatformerPlayer2Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovementX => m_Wrapper.m_PlatformerPlayer2_MovementX;
        public InputAction @MovementY => m_Wrapper.m_PlatformerPlayer2_MovementY;
        public InputAction @Jump => m_Wrapper.m_PlatformerPlayer2_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlatformerPlayer2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlatformerPlayer2Actions set) { return set.Get(); }
        public void SetCallbacks(IPlatformerPlayer2Actions instance)
        {
            if (m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface != null)
            {
                @MovementX.started -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnMovementX;
                @MovementX.performed -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnMovementX;
                @MovementX.canceled -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnMovementX;
                @MovementY.started -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnMovementY;
                @MovementY.performed -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnMovementY;
                @MovementY.canceled -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnMovementY;
                @Jump.started -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlatformerPlayer2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovementX.started += instance.OnMovementX;
                @MovementX.performed += instance.OnMovementX;
                @MovementX.canceled += instance.OnMovementX;
                @MovementY.started += instance.OnMovementY;
                @MovementY.performed += instance.OnMovementY;
                @MovementY.canceled += instance.OnMovementY;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlatformerPlayer2Actions @PlatformerPlayer2 => new PlatformerPlayer2Actions(this);

    // Maze
    private readonly InputActionMap m_Maze;
    private IMazeActions m_MazeActionsCallbackInterface;
    private readonly InputAction m_Maze_Up;
    private readonly InputAction m_Maze_Down;
    private readonly InputAction m_Maze_Left;
    private readonly InputAction m_Maze_Right;
    public struct MazeActions
    {
        private @PlayerControls m_Wrapper;
        public MazeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_Maze_Up;
        public InputAction @Down => m_Wrapper.m_Maze_Down;
        public InputAction @Left => m_Wrapper.m_Maze_Left;
        public InputAction @Right => m_Wrapper.m_Maze_Right;
        public InputActionMap Get() { return m_Wrapper.m_Maze; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MazeActions set) { return set.Get(); }
        public void SetCallbacks(IMazeActions instance)
        {
            if (m_Wrapper.m_MazeActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_MazeActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_MazeActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_MazeActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_MazeActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_MazeActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_MazeActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_MazeActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_MazeActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_MazeActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_MazeActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_MazeActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_MazeActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_MazeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public MazeActions @Maze => new MazeActions(this);
    public interface IPlatformerPlayer1Actions
    {
        void OnMovementX(InputAction.CallbackContext context);
        void OnMovementY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlatformerPlayer2Actions
    {
        void OnMovementX(InputAction.CallbackContext context);
        void OnMovementY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IMazeActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
