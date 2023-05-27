using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LadderCon : MonoBehaviour
{
//    [SerializeField] Tilemap tilemap;
//    [SerializeField] Sprite sprite;
    private bool onLadder = false;
    private bool LadderEnter, LadderExit;


    private string ladderTag = "Ladder";


    public bool OnLadder()
    {
        if (LadderEnter)
        {
            onLadder = true;
        }
        else if(LadderExit)
        {
            onLadder = false;
        }

        LadderEnter = false;
        LadderExit = false;
        return onLadder;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ladderTag)
        {
            LadderEnter = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ladderTag)
        {
            LadderExit = true;
        }
    }

    /*
    private void LadderTile()
    {
        foreach(var pos in tilemap.cellBounds.allPositionsWithin)
        {

        }
    }*/
}
//éQçl
//https://walkable-2020.com/unity/tilema-script/
