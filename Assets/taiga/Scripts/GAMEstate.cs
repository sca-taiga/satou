using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEstate : MonoBehaviour
{
 
	//�@�X�^�[�g�{�^��������������s����
	public void StartGame()
    {
        SceneManager.LoadScene("stage1");
    }
}