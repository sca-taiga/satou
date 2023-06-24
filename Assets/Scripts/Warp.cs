using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    [SerializeField] GameObject target;
    private Vector2 targetPos;

    private void Start()
    {
        targetPos = target.transform.position;
    }

    private void TriggerC()
    {
        target.GetComponent<Collider2D>().isTrigger = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
                GameObject.Find("Player").transform.position = targetPos + new Vector2(0, 2);
                target.GetComponent<Collider2D>().isTrigger = true;
                Invoke("TriggerC", 1f);
        }
    }
}
