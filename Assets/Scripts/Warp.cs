using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    [SerializeField] float posx;
    [SerializeField] float posy;
    [SerializeField] float posz;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Player").transform.position = new Vector3(posx, posy, posz);
        }
    }
}
