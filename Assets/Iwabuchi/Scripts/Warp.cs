using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Warp : MonoBehaviour
{
    [SerializeField] GameObject warp;
    [SerializeField] GameObject target;//ÉèÅ[ÉvêÊ
    [SerializeField] GameObject player;
    private Vector2 targetPos;
    private Vector2 warpPos;
    private Vector2 positioning = new Vector2 (0,0.32f);
    private bool isWarp;

    private SpriteRenderer spriteRenderer;
    private SpriteRenderer targetSpriteRenderer;
    public Sprite stopSprite; // 1Ç¬ñ⁄ÇÃâÊëú
    public Sprite bootSprite; // 2Ç¬ñ⁄ÇÃâÊëú
    private bool isSprite1Active = true;

    private void Start()
    {
        targetPos = target.transform.position;
        warpPos = warp.transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
        targetSpriteRenderer = target.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = stopSprite;
        targetSpriteRenderer.sprite = stopSprite;
        isWarp = false;
    }

    private void Update()
    {
        if (isWarp)
        {
            if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
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
            spriteRenderer.sprite = bootSprite;
            targetSpriteRenderer.sprite = bootSprite;
            //-2.5 -1.8
            warp.transform.position = warpPos + positioning;
            target.transform.position = targetPos + positioning;
            isWarp = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            spriteRenderer.sprite = stopSprite;
            targetSpriteRenderer.sprite = stopSprite;
            warp.transform.position = warpPos - positioning;
            target.transform.position = targetPos - positioning;
            isWarp = false;
        }
    }
}
