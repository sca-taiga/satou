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

    private float MoveSpeed;

    public GroundCheck ground;

    [SerializeField] float setSpeed;
    [SerializeField] float setJumpPower;
    [SerializeField] int gravityPower;

    private bool isGround = false;

    public float PlayerSpeed
    {
        get { return this.MoveSpeed;}
        private set { this.MoveSpeed = value;}
    }

    private void Start()
    {
        playerSpeed = setSpeed * 0.01f;
        PushSpeed = playerSpeed * 0.5f;
        Speed = playerSpeed;
    }

    private void FixedUpdate()
    {
        isGround = ground.IsGround();
        Move();
        Gravity();
    }
    

    private void Move()
    {
        if(isGround)
        {
            Hori = Input.GetAxisRaw("Horizontal");
            MoveSpeed = Speed * Hori;
            transform.position += new Vector3(MoveSpeed, 0, 0);
        }
    }

    private void Gravity()
    {
        if (isGround == false)
        {
            Ver = Input.GetAxisRaw("Vertical");
            transform.position += new Vector3(0, -0.2f, 0);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Box"))
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("������");
                Speed = PushSpeed;
            }
            if(Input.GetKeyUp(KeyCode.Space))
            {
                Debug.Log("������");
                Speed = setSpeed;
            }
        }
    }

}
