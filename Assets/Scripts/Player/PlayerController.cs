using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Hori;
    private float Ver;
    private float playerSpeed;
    private float PushSpeed;
    private float Speed;

    public float moveSpeed;

    public GroundCheck ground;
    public JumpCheck jump;
    public LadderCon ladder;
    public WallCheckR wallCheckR;
    public WallCheckL wallCheckL;
    public PushCheckR pushCheckR;
    public PushCheckL pushCheckL;
    GameObject gameManagerObj;
    Stop gameManager;
    private Rigidbody2D rb;

    [SerializeField] float setSpeed;
    [SerializeField] float jumpForce;

    public bool isGround = false;
    public bool isCatch = false;
    public bool isWallR = false;
    public bool isWallL = false;
    public bool isBoxR = false;
    public bool isBoxL = false;
    public bool isPushR = false;
    public bool isPushL = false;
    public bool canJump = false;
    public bool onLadder = false;

    public bool isWall = false;

    public float PlayerSpeed
    {
        get { return this.moveSpeed;}
        private set { this.moveSpeed = value;}
    }

    private void Start()
    {
        playerSpeed = setSpeed * 0.1f;
        PushSpeed = playerSpeed * 0.5f;
        Speed = playerSpeed;

        rb = this.GetComponent<Rigidbody2D>();
        gameManagerObj = GameObject.Find("GameManager");
        gameManager = gameManagerObj.GetComponent<Stop>();
        gameManager.CallInoperable(4.0f);
    }

    private void Update()
    {
        
        Jump();
        Climp();
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if(isCatch)
            {
                Speed = playerSpeed;
                isCatch = false;
            }
        }

    }

    private void FixedUpdate()
    {
        isGround = ground.IsGround();
        canJump = jump.CanJump();
        onLadder = ladder.OnLadder();
        isWallL = wallCheckL.IsWallL();
        isWallR = wallCheckR.IsWallR();
        isBoxL = wallCheckL.IsBoxL();
        isBoxR = wallCheckR.IsBoxR();
        isPushL = pushCheckL.IsPushL();
        isPushR = pushCheckR.IsPushR();

        Move();
        Gravity();
    }
    
    private void Move()
    {
        Hori = Input.GetAxisRaw("Horizontal");
        moveSpeed = Speed * Hori;

        if (!isGround)
        {
            Speed = PushSpeed;
        }
        if(isGround)
        {
            if(!isCatch)
            {
                if (isWallR || isBoxR)
                {
                    if(Hori > 0)
                    {
                        moveSpeed = 0;
                    }
                }
                if (isWallL || isBoxL)
                {
                    if(Hori < 0)
                    {
                        moveSpeed = 0;
                    }
                }
            }
            if(isCatch)
            {
                Speed = PushSpeed;

                if (isPushR && isBoxR)
                {
                    if(Hori > 0)
                    {
                        moveSpeed = 0;
                    }
                }
                if (isPushL && isBoxL)
                {
                    if(Hori < 0)
                    {
                        moveSpeed = 0;
                    }

                }
            }
        }

        transform.position += new Vector3(moveSpeed, 0, 0);
    }

    private void Gravity()
    {
        if (isGround == false)
        {
            transform.position -= new Vector3(0, 0.15f, 0);
        }
    }

    private void Jump()
    {
        if(canJump)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                canJump = false;
                rb.velocity += (Vector2.up * jumpForce) * Time.fixedDeltaTime / rb.mass;
                isGround = false;
            }
        }
    }

    private void Climp()
    {
        if (onLadder)
        {
            Ver = Input.GetAxisRaw("Vertical");
            transform.position += new Vector3(0, Ver * 0.01f, 0);
        }
        else if(Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, 0.15f, 0);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Goal"))
        {
            SceneManager.LoadScene("Clear");
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Push"))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                isCatch = true;
            }
        }
    }
    /*
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Push"))
        {
            isCatch = false;
        }
    }
    */
}
