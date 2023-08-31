using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class sutegecleatima : MonoBehaviour
{

	private Text timerText;
	private int minute;
	private float seconds;
	private float oldSeconds;
	//�@�ŏ��̎���
	private float startTime;

	void Start()
	{
		timerText = GetComponentInChildren<Text>();
		oldSeconds = 0;
		startTime = Time.realtimeSinceStartup;
	}

	void Update()
	{

		//�@Time.time�ł̎��Ԍv��
		seconds = Time.realtimeSinceStartup - startTime;
		//�@�~�܂��Ă��邩�ǂ������R���\�[���ɕ\��
		Debug.Log("Time.timeScale: " + Time.timeScale);


		minute = (int)seconds / 60;

		if ((int)seconds != (int)oldSeconds)
		{
			timerText.text = minute.ToString("00") + ":" + ((int)(seconds % 60)).ToString("00");
		}
		oldSeconds = seconds;

		//�@�}�E�X�̍��{�^�������ňꎞ��~
		if (Input.GetMouseButtonDown(0))
		{
			Time.timeScale = Mathf.Approximately(Time.timeScale, 0f) ? 1f : 0f;
		}
	}
}