using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheckR : MonoBehaviour
{
    private bool isWallR = false;
    private bool isWallEnter, isWallStay, isWallExit;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Player"))
        {
            isWallStay = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Player"))
        {
            isWallEnter = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Player"))
        {
            isWallExit = true;
        }
    }
}
