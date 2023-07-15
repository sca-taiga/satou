using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private bool ClearFlag;
    // Start is called before the first frame update
    void Start()
    {
        ClearFlag = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ClearFlag)
        {
            if (SceneManager.GetActiveScene().name == "Stage1")
            {
                SceneManager.LoadScene("Stage2");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage2")
            {
                SceneManager.LoadScene("Clear");
                ClearFlag = false;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("ƒNƒŠƒA‚¾‚æ");
            ClearFlag = true;
        }
    }
}
