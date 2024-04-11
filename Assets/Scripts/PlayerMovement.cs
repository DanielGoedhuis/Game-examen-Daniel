using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;
    private CircleCollider2D circleCollider;
    private BoxCollider2D boxCollider;

    [SerializeField] private LayerMask jumpableGround;

    private Vector3 respawnPoint;
    public GameObject fallDetector;

        
    private float dirX;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    private bool isGrounded;
    AudioManager am;


    public GameManager gameManager;

    public static int health = 4;
    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();
        circleCollider = GetComponent<CircleCollider2D>();
        respawnPoint = transform.position;
        am = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();


    }
    private bool isDead;
    
    private void Update()
        //hier checkt hij of de player op grond staat zodat hij kan springen
    {
        isGrounded = IsGrounded();
        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        //kijkt hoeveel levens de player heeft en als het nul is zorgt hij ervoor dat het game over is
        if (LifeManager.health <= 0 && !isDead)
        {
            isDead = true;
            SceneManager.LoadScene(2, LoadSceneMode.Additive);
        }
        UpdateAnimationState();

        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);

   
}
    //hier checkt het of de player falt of iets dodelijks raakt
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FallDetector")
        {
            transform.position = respawnPoint;
            am.PlaySFX(am.death);
            LifeManager.health--;
        }
        if(collision.tag == "finish")
        {
            SceneManager.LoadScene(3, LoadSceneMode.Additive);
        }

        if (collision.tag == "Traps")
        {
            transform.position = respawnPoint;
            am.PlaySFX(am.death);
            LifeManager.health--;
            
        }
    }
    //dit check of de player op de grond staat
    private bool IsGrounded()
        
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
        return hit.collider != null;
    }
    //dit speelt de animation af als de player beweegt
    private void UpdateAnimationState()
    {
        if (dirX > 0f)
        {
            anim.SetBool("Running", true);
            sr.flipX = false;
            boxCollider.offset = new Vector2(0.141606f, -0.4531407f);
            circleCollider.offset = new Vector2(0.1557673f, 0.33949f);
        }
        else if (dirX < 0f)
        {
            anim.SetBool("Running", true);
            sr.flipX = true;
            boxCollider.offset = new Vector2(-0.1631088f, -0.4531407f);
            circleCollider.offset = new Vector2(-0.1581817f, 0.3394899f);
        }
        else
        {
            anim.SetBool("Running", false);
            
        }
    }
}