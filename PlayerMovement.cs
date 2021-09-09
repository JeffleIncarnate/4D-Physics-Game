// Modules
using UnityEngine;

// Unity Class
public class PlayerMovement : MonoBehaviour 
{
    // Movement
    public float movementSpeed;
    public Rigidbody2D rb;

    // Jumping / Raycast
    public float jumpForce = 20f;
    public Transform feet;
    public LayerMask groundLayer;

    // mx
    float mx;

    // Time
    public TimeManager timeManager;
    public TimeManager_Fast TimeManager;

    // Update is called once per frame

    // This is called once at the start of the game
    public void start()
    {
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);
    }

    // Update is called once per frame
    public void Update() 
    {
        mx = Input.GetAxisRaw("Horizontal");

        // Jumping with Raycast
        if (Input.GetButton("Jump") && isGround() == true) 
        {
            // Calling Jump Method
            Jump();
        }

        // Slowing Time
        if (Input.GetKey(KeyCode.Mouse0))
        {
            timeManager.doSlowMotion();
        }

        // Fast Time 
        if (Input.GetKey(KeyCode.Mouse1))
        {
            TimeManager.doFastMotion();
        }

        // Slow Death
        if (rb.position.y < -9)
        {
            timeManager.doSlowMotion();
        }
    }

    // Fixed Updates
    public void FixedUpdate()
    {
        // Creating Vector
        Vector2 move = new Vector2(mx * movementSpeed, rb.velocity.y);

        rb.velocity = move;
    }

    // Jump Method
    public void Jump() 
    {
        // Creating Vector
        Vector2 move = new Vector2(rb.velocity.x, jumpForce);

        rb.velocity = move;
    }

    // Raycasting
    public bool isGround() 
    {
        // Actual Raycast
        Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.3f, groundLayer);

        // Ground Check
        if (groundCheck != null) 
        {
            // Returning true
            return true;
        }
        // Returning False
        return false;
    }
}
