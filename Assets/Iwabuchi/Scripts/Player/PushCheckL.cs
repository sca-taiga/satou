using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCheckL : MonoBehaviour
{
    private bool isPushL = false;
    private bool isWallEnter, isWallStay, isWallExit;

    public bool IsPushL()
    {
        if (isWallStay || isWallEnter)
        {
            isPushL = true;
        }
        else if (isWallExit)
        {
            isPushL = false;
        }

        isWallEnter = false;
        isWallStay = false;
        isWallExit = false;

        return isPushL;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Box"))
        {
            isWallStay = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Box"))
        {
            isWallEnter = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Box"))
        {
            isWallExit = true;
        }
    }
}
