using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    public Image blackImage;  // �����摜
    public float fadeSpeed = 2.5f;  // �t�F�[�h�̑���
    private bool isFading = false;  // �t�F�[�h�����ǂ���

    private void Start()
    {
        blackImage.canvasRenderer.SetAlpha(0.0f);  // ���߂͓����ɐݒ�
    }

    private void Update()
    {
        if (isFading)
        {
            blackImage.CrossFadeAlpha(1.0f, fadeSpeed, false);  // �����x��Z������
            Debug.Log(blackImage.canvasRenderer.GetAlpha());
            if (blackImage.canvasRenderer.GetAlpha() >= 0.8f)
            {
                Debug.Log("�����Ȃ�����[");
                SceneManager.LoadScene("StageSelect");  // �V�[���ړ�
            }
        }
    }

    public void OnButtonClicked()
    {
        isFading = true;
        Debug.Log("isFading: " + isFading); // �ǉ�
    }
}