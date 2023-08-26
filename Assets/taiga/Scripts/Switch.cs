using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    float bottomY = -0.1f;
    float speed = 0.5f;
    bool active =false;
    //↑いる？
    //多分そっちで用意してたやつのスクリプトのままだから書き換えておいたby岩渕
    [SerializeField] private List<DoorScript> doors = new List<DoorScript>();//対応するドアのリスト
    void Update()
    {
        /*
        if (active && transform.position.y > bottomY)
        {
            transform.position -= Vector3.up * speed * Time.deltaTime;
        }
        */
        if(Input.GetKeyDown(KeyCode.O))
        {
            foreach (var door in doors)
            {
                door.isOpen = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foreach (var door in doors)
            {
                door.isOpen = true;
            }
            /*
            door.isOpen=true;
            active = true;
            Debug.Log("Door");
            */
        }
        if (collision.gameObject.CompareTag("Box"))
        {
            foreach (var door in doors)
            {
                door.isOpen = true;
            }
        }
    }
}