using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    PlayerInput playerInput;
    Rigidbody2D rb;
    Vector2 moveVec;

    public float speed = 4;

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.linearVelocity = new Vector2(moveVec.x * speed, moveVec.y * speed);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveVec = context.ReadValue<Vector2>();
    }
}
