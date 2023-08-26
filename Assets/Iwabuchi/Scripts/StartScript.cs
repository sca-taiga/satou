using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StartScript : MonoBehaviour
{
    public Image blackImage;  // 黒い画像
    public float fadeSpeed = 2.5f;  // フェードの速さ
    private bool isFading = false;  // フェード中かどうか

    private void Start()
    {
        blackImage.canvasRenderer.SetAlpha(0.0f);  // 初めは透明に設定
    }

    private void Update()
    {
        if (isFading)
        {
            blackImage.CrossFadeAlpha(1.0f, fadeSpeed, false);  // 透明度を濃くする
            Debug.Log(blackImage.canvasRenderer.GetAlpha());
            if (blackImage.canvasRenderer.GetAlpha() >= 0.8f)
            {
                Debug.Log("黒くなったよー");
                SceneManager.LoadScene("StageSelect");  // シーン移動
            }
        }
    }

    public void OnButtonClicked()
    {
        isFading = true;
        Debug.Log("isFading: " + isFading); // 追加
    }
}