using UnityEngine;
using Fusion;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : NetworkBehaviour
{
    Vector2 moveInput;
    PlayerInput playerInput;

    public sbyte speed = 5;

    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    private void OnEnable()
    {
        playerInput.Player.Enable();
    }

    private void OnDisable()
    {
        playerInput.Player.Disable();
    }

    public override void FixedUpdateNetwork()
    {
        UnityEngine.InputSystem.InputSystem.Update();

        moveInput = playerInput.Player.Move.ReadValue<Vector2>().normalized;
        

        if (moveInput != Vector2.zero)
        {
            transform.Translate(moveInput * speed * Runner.DeltaTime);
        }

        if (playerInput.Player.Jump.triggered)
        {
            //rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }

    }
}
