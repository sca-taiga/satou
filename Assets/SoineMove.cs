using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary> Spine�A�j���[�V�����̍Đ����m�F�T���v���N���X </summary>
public class SoineMove : MonoBehaviour
{

	/// <summary> �Đ�����A�j���[�V������ </summary>
	[SerializeField]
	private string testAnimationName = "jump/jump";

	/// <summary> �Q�[���I�u�W�F�N�g�ɐݒ肳��Ă���SkeletonAnimation </summary>
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spine�A�j���[�V������K�p���邽�߂ɕK�v��AnimationState </summary>
	private Spine.AnimationState spineAnimationState = default;
	//var 

	private void Start()
	{
		// �Q�[���I�u�W�F�N�g��SkeletonAnimation���擾
		skeletonAnimation = GetComponent<SkeletonAnimation>();

		// SkeletonAnimation����AnimationState���擾
		spineAnimationState = skeletonAnimation.AnimationState;
	}

	private void Update()
	{
		// Space�L�[�̓��͂ŃA�j���[�V������؂�ւ���e�X�g
		if (Input.GetKeyDown(KeyCode.Space))
		//A�L�[�̓��͂Ł����Ɉړ�����A�j���[�V��������肽��
		if (Input.GetKeyDown(KeyCode.A))

			{
			
			PlayAnimation();

		}
	}

	/// <summary>
	/// Spine�A�j���[�V�������Đ�
	/// testAnimationName�ɍĐ��������A�j���[�V���������L�ڂ��Ă��������B
	/// </summary>
	private void PlayAnimation()
	{
		// �A�j���[�V�����utestAnimationName�v���Đ�
		spineAnimationState.SetAnimation(0, testAnimationName, true);
	}

}

