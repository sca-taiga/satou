using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheckL : MonoBehaviour
{
    private bool isWallL = false;
    private bool isWallEnter, isWallStay, isWallExit;
    private bool isBoxL = false;
    private bool isBoxEnter, isBoxStay, isBoxExit;

    public bool IsWallL()
    {
        if (isWallStay || isWallEnter)
        {
            isWallL = true;
        }
        else if (isWallExit)
        {
            isWallL = false;
        }

        isWallEnter = false;
        isWallStay = false;
        isWallExit = false;

        return isWallL;
    }
    public bool IsBoxL() 
    {
        if(isBoxStay || isBoxEnter)
        {
            isBoxL = true;
        }
        else if (isBoxExit)
        {
            isBoxL = false;
        }
        isBoxEnter = false;
        isBoxStay = false;
        isBoxExit = false;

        return isBoxL;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isWallEnter = true;
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            isBoxEnter = true;
        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isWallStay = true;
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            isBoxStay = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isWallExit = true;
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            isBoxExit = true;
        }
    }
}
