using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    private IEnumerator Inoperable(float stopTime)
    {
        GameObject player = GameObject.Find("Player");
        PlayerController playerController = player.GetComponent<PlayerController>();
        playerController.enabled = false;

        yield return new WaitForSeconds(stopTime);
        playerController.enabled = true;
        yield break;
    }

    public void CallInoperable(float stopTime)
    {
        StartCoroutine("Inoperable", stopTime);
    }
}




