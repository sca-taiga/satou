using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGeter : MonoBehaviour
{
    [SerializeField] float Speed;

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            transform.position += new Vector3(Speed, 0, 0);
        }
    }
}
