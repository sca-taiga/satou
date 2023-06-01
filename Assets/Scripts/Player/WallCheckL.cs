using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheckL : MonoBehaviour
{
    private bool isWallL = false;
    private bool isWallEnter, isWallStay, isWallExit;

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
