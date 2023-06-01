using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    float bottomY = -0.1f;
    float speed = 0.5f;

    bool active =false;

    void Update()
    {
        /*
        if (active && transform.position.y > bottomY)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Door");
        if (collision.gameObject.CompareTag("Player"))
        {
            active = true;
            Debug.Log("Door");
        }
    }
}