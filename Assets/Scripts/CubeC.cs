using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CubeC : MonoBehaviour
{

    public GroundCheck ground;
    public WallCheckR wallCheckR;
    public WallCheckL wallCheckL;
    public PlayerController playercontroller;

    private bool isGround = false;
    public bool isWallR = false;
    public bool isWallL = false;
    private float Speed;

    private void FixedUpdate()
    {
        isGround = ground.IsGround();
        isWallL = wallCheckL.IsWallL();
        isWallR = wallCheckR.IsWallR();
        Gravity();
    }

    private void Update()
    {
//        transform.position += new Vector3(Speed, 0, 0);
    }
    private void Move()
    {
        Speed = playercontroller.PlayerSpeed;
        if(isWallL && Speed < 0)
        {
            Speed = 0;
        }
        if (isWallR && Speed > 0)
        {
            Speed = 0;
        }
        transform.position += new Vector3(Speed, 0, 0);
    }


    private void Gravity()
    {
        if (isGround == false)
        {
            transform.position += new Vector3(0, -0.2f, 0);
        }
    }
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Move();
            }
        }
    }
}
