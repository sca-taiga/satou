using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
//    float defaultY;     // 扉の初期のY座標
//    float openY = 5f;   // 扉のオープン時のY座標
//    float speed = 1f;   // 扉の開閉のスピード

    public bool isOpen; // 扉を開けるか閉めるかのフラグ
    private Collider2D col;
    [SerializeField] private GameObject door;
    private SpriteRenderer spriteRenderer;

    public Sprite ClauseSprite; // 1つ目の画像
    public Sprite OpenSprite; // 2つ目の画像
    private bool isSprite1Active = true;

    private void Start()
    {
        isOpen = false;
        col = door.GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = ClauseSprite;
    }

    private void Update()
    {
        if(isOpen)
        {
            col.isTrigger = false;
            spriteRenderer.sprite = OpenSprite;

        }
    }

}
/*
void Start()
{
//        defaultY = transform.position.y;
}

void Update()
{
    if (isOpen && transform.position.y < openY)
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }
    else if (!isOpen && transform.position.y > defaultY)
    {
        transform.position -= Vector3.up * speed * Time.deltaTime;
    }
    if (isOpen)
    {
        animator
    }
}
*/