//Controls are W, A, S, D, SPACE, Arrow Keys

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float jumpForce = 7f;

    public LayerMask groundLayer;
    public Transform groundPosition;

    private Rigidbody2D rb;
    private bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundPosition.position, 0.1f, groundLayer);
        float moveDirection = Input.GetAxisRaw("Horizontal");
        Vector2 movement = new Vector2(moveDirection * moveSpeed, rb.linearVelocity.y);
        rb.linearVelocity = movement;

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
