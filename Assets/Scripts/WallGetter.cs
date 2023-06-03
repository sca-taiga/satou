using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGetter : MonoBehaviour
{
    private bool isWall = false;
    private bool isWallStay, isWallExit;

    public bool IsWall()
    {
        if (isWallStay)
        {
            isWall = true;
        }
        else if (isWallExit)
        {
            isWall = false;
        }

        isWallStay = false;
        isWallExit = false;

        return isWall;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isWallStay = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isWallExit = true;
        }
    }
}
