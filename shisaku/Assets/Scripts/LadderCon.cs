using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class LadderCon : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] Sprite sprite;

    private void LadderTile()
    {
        foreach(var pos in tilemap.cellBounds.allPositionsWithin)
        {

        }
    }
}
//éQçl
//https://walkable-2020.com/unity/tilema-script/
