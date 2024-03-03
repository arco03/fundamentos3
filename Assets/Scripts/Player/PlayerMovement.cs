using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private float x;
    [Header("Movement")]
    [SerializeField] private string Horizontal;
    [SerializeField] private float speed;
    [Header("Jump")]
    [SerializeField] private float jumpForce;
    [SerializeField] private bool onGround;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        x = Input.GetAxisRaw(Horizontal);
        animator.SetFloat(Horizontal, Mathf.Abs(x));
        animator.SetFloat("VelY", rb.velocity.y);
        //Saltar si el jugador esta en el suelo
        if (onGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            onGround = false;
        }
    }
    private void FixedUpdate()
    {
        animator.SetBool("onGround", onGround);
        //Movimiento del jugador
        Vector2 xMovement = new Vector2(x, 0);
        rb.velocity = new Vector2(xMovement.x * speed, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Verifica que el jugador esta tocando el suelo
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
