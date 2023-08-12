using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject player;
    private Vector2 targetPos;
    private bool isWarp;
    SpriteRenderer sr;
    float cla;
    float speed = 0.01f;

    private void Start()
    {
        targetPos = target.transform.position;
        sr = player.GetComponent<SpriteRenderer>();
        isWarp = false;
    }

    private void Update()
    {
        if (isWarp)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {

                GameObject.Find("Player").transform.position = targetPos + new Vector2(0, 2);
                target.GetComponent<Collider2D>().isTrigger = true;
                Invoke("TriggerC", 1f);
                isWarp = false;
            }
        }
    }

    private void TriggerC()
    {
        target.GetComponent<Collider2D>().isTrigger = false;
    }

    
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isWarp = true;

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            isWarp = false;
        }
    }
    /*
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isWarp = true;

        }
    }*/
}