using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour
{
	private float time = 120;
	public ballScript BallScript;
    private static float deltaTime;

    void Start()
	{
		//�����l60��\��
		//float�^����int�^��Cast���AString�^�ɕϊ����ĕ\��
		GetComponent<Text>().text = ((int)time).ToString("HH:DD:SS");
	}

	void Update()
	{
		//1�b��1�����炵�Ă���
		time -= Time.deltaTime;
		//�}�C�i�X�͕\�����Ȃ�
		if (time < 0) time = 0;
		GetComponent<Text>().text = ((int)time).ToString("hh:dd:ss");
	}
}