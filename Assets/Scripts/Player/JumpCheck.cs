using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCheck : MonoBehaviour
{
    private string cliffTag ="Jump";
    private bool canJump = false;
    private bool isJumpEnter, isJumpStay, isJumpExit;

    public bool CanJump()
    {
        if(isJumpEnter || isJumpStay)
        {
            canJump = true;
        }
        else if(isJumpExit)
        {
            canJump = false;
        }

        isJumpEnter = false;
        isJumpStay = false;
        isJumpExit = false;

        return canJump;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == cliffTag)
        {
            isJumpEnter = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == cliffTag)
        {
            isJumpStay = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == cliffTag)
        {
            isJumpExit = true;
        }
    }
}
