using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEstate : MonoBehaviour
{
 
	//　スタートボタンを押したら実行する
	public void StartGame()
    {
        SceneManager.LoadScene("stage1");
    }
}