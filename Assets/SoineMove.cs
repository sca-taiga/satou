using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> Spineアニメーションの再生を確認サンプルクラス </summary>
public class SoineMove : MonoBehaviour
{

	/// <summary> 再生するアニメーション名 </summary>
	[SerializeField]
	private string testAnimationName = "jump/jump";
	[SerializeField]
	private string testAnimationName2 = "walk/aruku";

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

			PlayAnimation();

		}
		//Aキーで左移動
        else if (Input.GetKeyDown(KeyCode.A))
        {
			PlayAnimation();
        }

        
    }

	/// <summary>
	/// Spineアニメーションを再生
	/// testAnimationNameに再生したいアニメーション名を記載してください。
	/// </summary>
	private void PlayAnimation()
	{
		// アニメーション「testAnimationName」を再生
		spineAnimationState.SetAnimation(0, testAnimationName, true);
		// アニメーション「testAnimationName」を再生
		spineAnimationState.SetAnimation(0, testAnimationName2, true);
	}
}

