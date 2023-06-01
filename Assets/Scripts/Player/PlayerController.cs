using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Hori;
    private float Ver;
    private float playerSpeed;
    private float PushSpeed;
    private float Speed;

    public float MoveSpeed;

    public GroundCheck ground;
    public JumpCheck jump;
    public LadderCon ladder;
    public WallCheckR wallCheckR;
    GameObject gameManagerObj;
    Stop gameManager;
    private Rigidbody2D rb;

    [SerializeField] float setSpeed;
    [SerializeField] float jumpForce;

    public bool isGround = false;
    public bool isCatch = false;
    public bool isWallR = false;
    public bool isWallL = false;
    public bool canJump = false;
    public bool onLadder = false;

    public float PlayerSpeed
    {
        get { return this.MoveSpeed;}
        private set { this.MoveSpeed = value;}
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
            if (isWallR)
            {
                transform.position -= new Vector3(MoveSpeed * 0.05f, 0, 0);
            }
    }

    private void FixedUpdate()
    {
        isGround = ground.IsGround();
        canJump = jump.CanJump();
        onLadder = ladder.OnLadder();

        Move();
        Gravity();
    }
    
    private void Move()
    {
        if(isGround)
        {
            Hori = Input.GetAxisRaw("Horizontal");
            MoveSpeed = Speed * Hori;
            if (!isWallR)
            {
                transform.position += new Vector3(MoveSpeed, 0, 0);
            }
        }


    }

    private void Gravity()
    {
        if (isGround == false)
        {
            transform.position -= new Vector3(0, 0.15f, 0);
        }
    }

    private void Jump()
    {/*
        if(canJump)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0, jumpForce));
                
                
                isGround = false;
                Debug.Log("ƒWƒƒƒ“ƒv");
            }
        }*/
    }

    private void Climp()
    {
        if (onLadder)
        {
            Ver = Input.GetAxisRaw("Vertical");
            transform.position += new Vector3(0, Ver * 0.01f, 0);
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            transform.position += new Vector3(0, 0.15f, 0);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Push"))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = PushSpeed;
                isCatch = true;
            }
        }
    }

}
