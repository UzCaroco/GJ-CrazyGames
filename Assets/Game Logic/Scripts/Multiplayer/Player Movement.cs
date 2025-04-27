using UnityEngine;
using Fusion;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : NetworkBehaviour
{
    
    Vector2 moveInput;
    PlayerInput playerInput;

    public sbyte speed = 5;
    Collider2D collider;
    public LayerMask collisionLayers; // Define no Inspector os layers que vai colidir

    private void Awake()
    {
        playerInput = new PlayerInput();
        collider = GetComponent<Collider2D>();
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
        Vector2 moveDelta = moveInput * speed * Runner.DeltaTime;


        if (moveDelta != Vector2.zero)
        {
            RaycastHit2D hit = Physics2D.BoxCast(transform.position, collider.bounds.size, 0f, moveDelta.normalized, moveDelta.magnitude, collisionLayers);

            if (!hit)
            {
                transform.Translate(moveInput * speed * Runner.DeltaTime);
            }
            else
            {
                // Opcional: pode fazer algo quando colidir, tipo logar
                Debug.Log("Bateu em: " + hit.collider.name);
            }
        }

        if (playerInput.Player.Jump.triggered)
        {
            //rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
        }

    }
}
