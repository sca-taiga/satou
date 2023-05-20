using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeC : MonoBehaviour
{

    public GroundCheck ground;
    public PlayerController playercontroller;

    private bool isGround = false;
    private float Speed;

    private GameObject WallL;
    private GameObject WallR;

    private void FixedUpdate()
    {
        Speed = playercontroller.PlayerSpeed;
        isGround = ground.IsGround();
        Gravity();
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
        
        if(other.gameObject.tag == "Wall")
        {
            transform.position += new Vector3(-Speed, 0,0);
        }
    }


}
