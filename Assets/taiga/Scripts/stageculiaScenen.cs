using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stageculiaScenen : MonoBehaviour
{

	public GameObject[] GameObjectsTohidden;


	// Use this for initialization
	void Start()
	{
		//�V�[�����j�����ꂽ�Ƃ��ɌĂяo�����悤�ɂ���
		SceneManager.sceneUnloaded += OnSceneUnloaded;

	}

    //�T�u�{�^���������ꂽ
    [System.Obsolete]
    public void SubButton()
	{

		//�T�u�V�[�����Ăяo���Ă���Ƃ��ɔ�\���ɂ���Q�[���I�u�W�F�N�g
		foreach (GameObject obj in GameObjectsTohidden)
		{
			obj.SetActive(false);
		}
		//���C���V�[���ɃT�u�V�[����ǉ��\������
		Application.LoadLevelAdditive("stage1");

	}

	private void OnSceneUnloaded(Scene current)
	{
		//�V�[�����j�����ꂽ�Ƃ��ɌĂяo�����
		//����̗�ł́A�T�u�V�[�����j�����ꂽ��Ăяo�����悤�ɂȂ��Ă��܂�
		Debug.Log("OnSceneUnloaded: " + current.name);

		//�{���́A�ǂ̃V�[�����j�����ꂽ�̂��m�F���Ă��珈�����������ǂ���������Ȃ�

		//�Q�[���I�u�W�F�N�g��\������
		foreach (GameObject obj in GameObjectsTohidden)
		{
			obj.SetActive(true);
		}
	}

}
