using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheckR : MonoBehaviour
{
    private bool isWallR = false;
    private bool isWallEnter, isWallStay, isWallExit;
    private bool isBoxR = false;
    private bool isBoxEnter, isBoxStay, isBoxExit;

    public bool IsWallR()
    {
        if (isWallStay || isWallEnter)
        {
            isWallR = true;
        }
        else if (isWallExit)
        {
            isWallR = false;
        }

        isWallEnter = false;
        isWallStay = false;
        isWallExit = false;

        return isWallR;
    }
    
    public bool IsBoxR()
    {
        if(isBoxStay  || isBoxEnter)
        {
            isBoxR = true;
        }
        else if(isBoxExit)
        {
            isBoxR = false;
        }
        isBoxEnter = false;
        isBoxStay = false;
        isBoxExit = false;

        return isBoxR;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isWallEnter = true;
        }
        if(collision.gameObject.CompareTag("Box"))
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
        if(collision.gameObject.CompareTag("Box"))
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
