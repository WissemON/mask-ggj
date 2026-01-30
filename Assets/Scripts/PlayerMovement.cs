using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public bool isJumping;
    public bool isGrounded;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask collisionLayers;
    

    public Rigidbody2D rb;
    public Animator animatorObscur;
    public Animator animatorClair;
    public SpriteRenderer spriteRendererObscur;
    public SpriteRenderer spriteRendererClair;

    private Vector3 velocity = Vector3.zero;
    private float horizontalMovement;


    void Update()
    {

         horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed;

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isJumping = true;
        }

        Flip(rb.linearVelocity.x);

        float characterVelocity = Mathf.Abs(rb.linearVelocity.x);
        animatorObscur.SetFloat("Speed", characterVelocity);
        animatorClair.SetFloat("Speed", characterVelocity);
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, collisionLayers);

        MovePlayer(horizontalMovement);
    }

    void MovePlayer(float _horizontalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, rb.linearVelocity.y);
        rb.linearVelocity = Vector3.SmoothDamp(rb.linearVelocity, targetVelocity, ref velocity, 0.05f);

        if (isJumping == true)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            isJumping = false;
        }
    }

    void Flip(float _velocity)
    {
        if (_velocity > 0.1f)
        {
            spriteRendererObscur.flipX = false;
            spriteRendererClair.flipX = false;
        }
        else if (_velocity < -0.1f)
        {
            spriteRendererObscur.flipX = true;
            spriteRendererClair.flipX = true;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}

