
using UnityEngine;
using UnityEngine.UI;
// �ǉ�
using UnityEngine.SceneManagement;

class GameOver : MonoBehaviour
{
    public Text gameOverMessage;
    // �Q�[���I�[�o�[�������ǂ����𔻒f���邽�߂̕ϐ�
    bool isGameOver = false;

    void Update()
    {
        // �Q�[���I�[�o�[�ɂȂ��Ă���A���ASubmit�{�^��������������s����
        if (isGameOver && Input.GetButtonDown("Submit"))
        {
            // Play�V�[�������[�h����
            SceneManager.LoadScene("Play");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
        // isGameOver��true�ɂ���i�t���O�𗧂Ă�j
        isGameOver = true;
    }
}