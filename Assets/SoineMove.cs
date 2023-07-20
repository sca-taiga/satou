using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;

/// <summary> Spineアニメーションの再生を確認サンプルクラス </summary>
public class SoineMove : MonoBehaviour
{

	/// <summary> 再生するアニメーション名 </summary>
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
	/// <summary> ゲームオブジェクトに設定されているSkeletonAnimation </summary>
	private SkeletonAnimation skeletonAnimation = default;

	/// <summary> Spineアニメーションを適用するために必要なAnimationState </summary>
	private Spine.AnimationState spineAnimationState = default;
	//var 
	

	private void Start()
	{
		// ゲームオブジェクトのSkeletonAnimationを取得
		skeletonAnimation = GetComponent<SkeletonAnimation>();

		// SkeletonAnimationからAnimationStateを取得
		spineAnimationState = skeletonAnimation.AnimationState;
	}

	private void Update()
	{

		//Spaceキーでジャンプ
		if (Input.GetKeyDown(KeyCode.Space))
		{
			JumpFlagg = true;
			PlayAnimation();
		}
		//Aキーで左移動
        else if (Input.GetKeyDown(KeyCode.A))
        {
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			//WorkAnimation();
			WoakFlagg = true;
			PlayAnimation();
		}
		//shift+Aキーで物を押す引く
		else if (Input.GetKeyDown(KeyCode.LeftShift))
		{
		PushpullFlagg = true;
			PlayAnimation();
		}
		//shift+Dキーで物を押す引く
		if (Input.GetKeyDown(KeyCode. D))
		{
			//WorkAnimation();
			pushFlagg = true;
			PlayAnimation();
		}

	/// <summary>
	/// Spineアニメーションを再生
	/// testAnimationNameに再生したいアニメーション名を記載してください。
	/// </summary>
	  void PlayAnimation()
	{
		if(JumpFlagg)
        {
			// アニメーション「testAnimationName」を再生
			spineAnimationState.SetAnimation(0, testAnimationName, true);
			JumpFlagg = false;
		}
		if(WoakFlagg)
        {
			// アニメーション「testAnimationName」を再生
			spineAnimationState.SetAnimation(0, testAnimationName2, true);
			WoakFlagg = false;
		}
		if (WoakFlagg)
		{
			// アニメーション「testAnimationName」を再生
			spineAnimationState.SetAnimation(0, testAnimationName3, true);
			WoakFlagg = false;
		}
		if (PushpullFlagg)
			// アニメーション「testAnimationName」を再生
			spineAnimationState.SetAnimation(0, testAnimationName4, true);
		PushpullFlagg = false;
	}
		if (pushFlagg)
			// アニメーション「testAnimationName」を再生
			spineAnimationState.SetAnimation(0, testAnimationName5, true);
		pushFlagg = false;
	}

		/*
		private void WorkAnimation()
		{
			// アニメーション「testAnimationName」を再生
			spineAnimationState.SetAnimation(0, testAnimationName2, true);
		}
		*/
		 void PlayAnimation2()
	{
		// アニメーション「testAnimationName」を再生
		TrackEntry trackEntry = spineAnimationState.SetAnimation(0, testAnimationName, true);

		// 完了通知を取得準備
		trackEntry.Complete += OnSpineComplete;
	}

	 void OnSpineComplete(TrackEntry trackEntry)
	{
		// アニメーション完了時に行う処理を記載
		spineAnimationState.SetAnimation(0, testAnimationName, true);
	}

}


