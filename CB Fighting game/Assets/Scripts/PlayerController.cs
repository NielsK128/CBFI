using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private SkinManager skinManager;
    [SerializeField] private CosmeticManager cosmeticManager;

    public GameObject sprite;
    public GameObject cosmeticsprite;

    public float speed;
    public float jumpForce;
    private float moveInput;

    [HideInInspector] public bool facingRight = true;

    public Animator squashScretchAnimator;

    //public ParticleSystem jumpParticles;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    void Start()
    {
        extraJumpsValue = PlayerPrefs.GetInt("multijump");
        if (PlayerPrefs.GetInt("speed") < 10)
        {
            PlayerPrefs.SetInt("speed", 10);
        }
        speed = PlayerPrefs.GetInt("speed");
        if (PlayerPrefs.GetInt("jump") < 18)
        {
            PlayerPrefs.SetInt("jump", 18);
        }
        jumpForce = PlayerPrefs.GetInt("jump");
        sprite.GetComponent<SpriteRenderer>().sprite = skinManager.GetSelectedSkin().sprite;
        cosmeticsprite.GetComponent<SpriteRenderer>().sprite = cosmeticManager.GetSelectedCosmetic().sprite;
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && extraJumps > 0)
        {
            squashScretchAnimator.SetTrigger("Jump");
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            //jumpParticles.Play();
        }
        else if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && extraJumps == 0 && isGrounded == true)
        {
            squashScretchAnimator.SetTrigger("Jump");
            rb.velocity = Vector2.up * jumpForce;
           // jumpParticles.Play();
        }
        
    }
    public void OnCollisionEnter2D(Collision2D col)
    {
        //Landen Animation
        if (col.gameObject.tag == "ground")
        {
            squashScretchAnimator.SetTrigger("Landing");
        }
        if(col.gameObject.name.Equals("MovingPlatform")) {
            this.transform.parent = col.transform;
        }
    }

    public void OnCollisionExit2D(Collision2D col) {
        if(col.gameObject.name.Equals("MovingPlatform")) {
            this.transform.parent = null;
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        /*if (facingRight == false && moveInput > 0)
        {
            Flip();
            facingRight = true;
            Weapon.facingRight = true;
            Projectile.facingRight = true;
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
            facingRight = false;
            Weapon.facingRight = false;
            Projectile.facingRight = false;
        }*/
    }
    void Flip()
    {
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
