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
                SceneManager.LoadScene("Stage3");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage3")
            {
                SceneManager.LoadScene("Stage4");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage4")
            {
                SceneManager.LoadScene("Stage5");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage5")
            {
                SceneManager.LoadScene("Stage6");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage6")
            {
                SceneManager.LoadScene("Stage7");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage7")
            {
                SceneManager.LoadScene("Stage8");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage8")
            {
                SceneManager.LoadScene("Stage9");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage9")
            {
                SceneManager.LoadScene("Stage10");
                ClearFlag = false;
            }
            if (SceneManager.GetActiveScene().name == "Stage10")
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
