using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGetter : MonoBehaviour
{
    private bool isWall = false;
    private bool isWallEnter, isWallStay, isWallExit;

    public bool IsWall()
    {
        if (isWallStay || isWallEnter)
        {
            isWall = true;
        }
        else if (isWallExit)
        {
            isWall = false;
        }

        isWallEnter = false;
        isWallStay = false;
        isWallExit = false;

        return isWall;
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
