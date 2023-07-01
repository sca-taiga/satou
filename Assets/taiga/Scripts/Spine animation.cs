using Spine.Unity;
using UnityEngine;
using Spine;


/// <summary> Spine�A�j���[�V�����̍Đ����m�F�T���v���N���X </summary>
public class SampleSpineAnimationController : MonoBehaviour
{

	/// <summary> �Đ�����A�j���[�V������ </summary>
	[SerializeField]
	private string testAnimationName = "jump";

	/// <summary> �Q�[���I�u�W�F�N�g�ɐݒ肳��Ă���SkeletonAnimation </summary>
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spine�A�j���[�V������K�p���邽�߂ɕK�v��AnimationState </summary>
	private Spine.AnimationState spineAnimationState = default;

	private void Start()
	{
		// �Q�[���I�u�W�F�N�g��SkeletonAnimation���擾
		skeletonAnimation = GetComponent<SkeletonAnimation>();

		// SkeletonAnimation����AnimationState���擾
		spineAnimationState = skeletonAnimation.AnimationState;
	}

	private void Update()
	{
		// A�L�[�̓��͂ŃA�j���[�V������؂�ւ���e�X�g
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
