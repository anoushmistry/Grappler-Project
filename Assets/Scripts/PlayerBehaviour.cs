using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
   
    [Header("Ground")]
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatisGround;

   [Header("Rope reference: ")]
   [SerializeField] private GrapplingRope grapplingRope;


    [Header("Jump Values :")]
    private int extraJumps;
    public int extraJumpsValue;
    [SerializeField] private float jumpForce = 5f;

    [Header("Animator :")]
    public Animator animator;

    [Header("Audio Sources")]
    public AudioSource backgroundNoise;
    public AudioSource jumpSound;
    int scorenum = 0;

    [Header("Player properties:")]
    public float moveSpeed = 0.6f;
    public bool facingRight = true;
    // Start is called before the first frame update

    public GameManager gameManager;

    public TextMeshProUGUI score;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        score.text = scorenum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        backgroundNoise.Play();
        if (grapplingRope.isGrappling == false && isGrounded == true)
        {
            float moveX = Input.GetAxis("Horizontal");

            // Move the player horizontally
            rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

            // Flip the player's sprite if moving in the opposite direction
            if (moveX < 0 && facingRight)
            {
                //  Flip();
            }
            else if (moveX > 0 && !facingRight)
            {
                //Flip();
            }

            //Update the animator's parameters for controlling animations
            animator.SetFloat("HorSpeed", Mathf.Abs(rb.velocity.x));
        }
        if (isGrounded == true)
        {
            animator.SetFloat("VerSpeed", Mathf.Abs(rb.velocity.y));
            extraJumps = extraJumpsValue;
            rb.collisionDetectionMode = CollisionDetectionMode2D.Discrete;
        }
        if (isGrounded == false)
        {
            rb.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            Debug.Log("Space pressed");
            jumpSound.Play();
            rb.velocity = Vector2.up * jumpForce;
            animator.SetFloat("VerSpeed", Mathf.Abs(rb.velocity.y));
            extraJumps--;
        }
        else if (Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            jumpSound.Play();
            rb.velocity = Vector2.up * jumpForce;
        }
    }
   /* private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }*/

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatisGround);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Bounds"))
        {
            gameManager.YouLose();
            gameObject.SetActive(false);
            Debug.Log("Lost!!!!!");
            
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Gems"))
        {
            scorenum++;
            score.text = scorenum.ToString();

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            gameManager.YouWin();
            gameObject.SetActive(false);
            Debug.Log("Win!!!!!!");
            

        }
    }
}
