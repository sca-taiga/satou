using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;

/// <summary> Spine�A�j���[�V�����̍Đ����m�F�T���v���N���X </summary>
public class SoineMove : MonoBehaviour
{

	/// <summary> �Đ�����A�j���[�V������ </summary>
	[SerializeField]
	private string testAnimationName = "jump/jump";

	[SerializeField]
	private string testAnimationName2 = "walk/aruku";

	[SerializeField]
	private string testAnimationName3 = "walk/aruku";

	[SerializeField]
	private string testAnimationName4 = "pushpull/pull";

	[SerializeField]
	private string testAnimationName5 = "pushpull/push";

	private bool JumpFlagg = false;
	private bool WoakFlagg = false;
	private bool PushpullFlagg = false;
	private bool pushFlagg = false;
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

		//Space�L�[�ŃW�����v
		if (Input.GetKeyDown(KeyCode.Space))
		{
			JumpFlagg = true;
			PlayAnimation();
		}
		//A�L�[�ō��ړ�
        else if (Input.GetKeyDown(KeyCode.A))
        {
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			//WorkAnimation();
			WoakFlagg = true;
			PlayAnimation();
		}
		//shift+A�L�[�ŕ�����������
		else if (Input.GetKeyDown(KeyCode.LeftShift))
		{
		PushpullFlagg = true;
			PlayAnimation();
		}
		//shift+D�L�[�ŕ�����������
		if (Input.GetKeyDown(KeyCode. D))
		{
			//WorkAnimation();
			pushFlagg = true;
			PlayAnimation();
		}

	/// <summary>
	/// Spine�A�j���[�V�������Đ�
	/// testAnimationName�ɍĐ��������A�j���[�V���������L�ڂ��Ă��������B
	/// </summary>
	  void PlayAnimation()
	{
		if(JumpFlagg)
        {
			// �A�j���[�V�����utestAnimationName�v���Đ�
			spineAnimationState.SetAnimation(0, testAnimationName, true);
			JumpFlagg = false;
		}
		if(WoakFlagg)
        {
			// �A�j���[�V�����utestAnimationName�v���Đ�
			spineAnimationState.SetAnimation(0, testAnimationName2, true);
			WoakFlagg = false;
		}
		if (WoakFlagg)
		{
			// �A�j���[�V�����utestAnimationName�v���Đ�
			spineAnimationState.SetAnimation(0, testAnimationName3, true);
			WoakFlagg = false;
		}
		if (PushpullFlagg)
			// �A�j���[�V�����utestAnimationName�v���Đ�
			spineAnimationState.SetAnimation(0, testAnimationName4, true);
		PushpullFlagg = false;
	}
		if (pushFlagg)
			// �A�j���[�V�����utestAnimationName�v���Đ�
			spineAnimationState.SetAnimation(0, testAnimationName5, true);
		pushFlagg = false;
	}

		/*
		private void WorkAnimation()
		{
			// �A�j���[�V�����utestAnimationName�v���Đ�
			spineAnimationState.SetAnimation(0, testAnimationName2, true);
		}
		*/
		 void PlayAnimation2()
	{
		// �A�j���[�V�����utestAnimationName�v���Đ�
		TrackEntry trackEntry = spineAnimationState.SetAnimation(0, testAnimationName, true);

		// �����ʒm���擾����
		trackEntry.Complete += OnSpineComplete;
	}

	 void OnSpineComplete(TrackEntry trackEntry)
	{
		// �A�j���[�V�����������ɍs���������L��
		spineAnimationState.SetAnimation(0, testAnimationName, true);
	}

}


