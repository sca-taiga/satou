using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeC : MonoBehaviour
{

    public GroundCheck ground;
    public WallGetter wallgetter;
    public PlayerController playercontroller;

    private bool isGround = false;
    public bool isWall = false;
    private float Speed;

    private void FixedUpdate()
    {
        isGround = ground.IsGround();
        isWall = wallgetter.IsWall();
        Gravity();
    }

    private void Update()
    {
        if(!isWall)
        {
            Speed = playercontroller.PlayerSpeed;
        }
        else
        {
            transform.position -= new Vector3(Speed * 1.1f, 0, 0);
            Speed = 0;
        }

        
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
                transform.position += new Vector3(Speed, 0, 0);
            }
        }
    }


}
