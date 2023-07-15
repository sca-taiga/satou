using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushCheckR : MonoBehaviour
{
    private bool isPushR = false;
    private bool isWallEnter, isWallStay, isWallExit;

    public bool IsPushR()
    {
        if (isWallStay || isWallEnter)
        {
            isPushR = true;
        }
        else if (isWallExit)
        {
            isPushR = false;
        }

        isWallEnter = false;
        isWallStay = false;
        isWallExit = false;

        return isPushR;
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
