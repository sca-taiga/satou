
using UnityEngine;
using UnityEngine.UI;
// 追加
using UnityEngine.SceneManagement;

class GameOver : MonoBehaviour
{
    public Text gameOverMessage;
    // ゲームオーバーしたかどうかを判断するための変数
    bool isGameOver = false;

    void Update()
    {
        // ゲームオーバーになっている、かつ、Submitボタンを押したら実行する
        if (isGameOver && Input.GetButtonDown("Submit"))
        {
            // Playシーンをロードする
            SceneManager.LoadScene("Play");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
        // isGameOverをtrueにする（フラグを立てる）
        isGameOver = true;
    }
}