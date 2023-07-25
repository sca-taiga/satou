using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    private float nowPosi;
    void Start()
    {
        nowPosi = this.transform.position.y;
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPosi + Mathf.PingPong(Time.time, 1f), transform.position.z);
    }
}
