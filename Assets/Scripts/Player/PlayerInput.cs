using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public PlayerAnimator playerAnimator;
    public PlayerAttack playerAttack;
    public PlayerGUI playerGUI;
    public LayerMask layerMask;
    private Camera mainCamera;

    void Awake()
    {
        Mouse.current.WarpCursorPosition(new Vector2(123, 234));
    }

    void Start()
    {
        mainCamera = Camera.main;
    }

    public void OnRoll(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            playerMovement.Roll();
        }
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (Pointer.current == null) return;
            Vector2 screenPosition = Pointer.current.position.ReadValue();
            Ray ray = mainCamera.ScreenPointToRay(screenPosition);

            if (Physics.Raycast(ray, out RaycastHit hitInfo, Mathf.Infinity, layerMask))
            {
                playerMovement.Move(hitInfo.point);
            }
        }
    }

    public void OnStopMoving(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            playerMovement.StopMoving();
        }
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            playerAttack.Attack();
        }
    }

    public void OnInventory(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            playerGUI.Inventory();
        }
    }

    public void OnSkill(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            print(context.control);
        }
    }
    
    public void OnEscapse(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            GameUtility.INSTANCE.Escape();
        }
    }
}
