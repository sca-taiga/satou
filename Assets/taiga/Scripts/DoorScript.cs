using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{
//    float defaultY;     // ���̏�����Y���W
//    float openY = 5f;   // ���̃I�[�v������Y���W
//    float speed = 1f;   // ���̊J�̃X�s�[�h

    public bool isOpen; // �����J���邩�߂邩�̃t���O
    private Collider2D col;
    [SerializeField] private GameObject door;
    private SpriteRenderer spriteRenderer;

    public Sprite ClauseSprite; // 1�ڂ̉摜
    public Sprite OpenSprite; // 2�ڂ̉摜
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