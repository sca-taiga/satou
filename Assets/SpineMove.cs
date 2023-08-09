using Spine.Unity;
using UnityEngine;
using Spine;

/// <summary> Spineアニメーションの再生を確認サンプルクラス </summary>
public class SpineMove : MonoBehaviour
{
    /// <summary> 再生するアニメーション名 </summary>
    [SerializeField]
    private string idleAnimation = "wait/taiki"; // ←アニメーション名をわかりやすく変更する

    [SerializeField]
    private string jumpAnimation= "jump/jump"; // ←アニメーション名をわかりやすく変更する

    [SerializeField]
    private string walkAnimation = "walk/aruku";

    [SerializeField]
    private string walkAnimation1 = "walk/aruku";

    [SerializeField]
    private string pullAnimation = "pushpull/pull";

    [SerializeField]
    private string pushAnimation = "pushpull/push";

    private bool isJump = false;
    //private bool JumpFlagg = false;
    //private bool WoakFlagg = false;
    //private bool PushpullFlagg = false;
    //private bool pushFlagg = false;

    // アニメーションの状態変化のような何種類も状態があるパターンではboolよりenumで管理する方が楽です。
    // ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

    private State oldState = State.Idle; // 1f前の状態
    private State currentState = State.Idle; // 現在の状態
    // 状態の列挙
    private enum State
    {
        Idle,
        Jump,
        Walk,
        Interact
    }
    private Direction currentDirection = Direction.Right; // 現在の向き
    // 向きの列挙
    private enum Direction
    {
        None,
        Right,
        Left
    }
    /// <summary>
    /// OnTriggerとかで判定予定
    /// </summary>
    [SerializeField] private InteractionState currentInteraction = InteractionState.Right; // 現在の交流状態
    // 交流状態(操作可能オブジェクトが近くにあるか否か)の列挙
    private enum InteractionState
    {
        None, // ない
        Right,// 右にある
        Left  // 左にある
    }
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
        if(isJump) return;
        //Spaceキーでジャンプ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
            currentState = State.Jump; // 現在の状態をジャンプに切り替える
        }
        //shift+A or Dキーで物を押す引く
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            // 現在の状態を操作に切り替える
            if (Input.GetKey(KeyCode.A))
            {
                currentDirection = Direction.Left; // 現在の向きを左に切り替える
                currentState = State.Interact;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                currentDirection = Direction.Right; // 現在の向きを左に切り替える
                currentState = State.Interact;
            }
            else currentState = State.Idle; // LShiftのみ押されてる状態の場合はIdleに切り替える
        }
        //Aキーで左移動
        else if (Input.GetKey(KeyCode.A))
        {
            currentState = State.Walk; // 現在の状態を歩くに切り替える
            currentDirection = Direction.Left; // 現在の向きを左に切り替える
        }
        //Dキーで右移動
        else if (Input.GetKey(KeyCode.D))
        {
            currentState = State.Walk; // 現在の状態を歩くに切り替える
            currentDirection = Direction.Right; // 現在の向きを右に切り替える
        }
        else
        {
            currentState = State.Idle; // 無操作状態の場合はIdleに切り替える
        }
        //状態の変化があった場合アニメーションを切り替える
        if (oldState != currentState)
        {
            PlayAnimation();
            oldState = currentState;
        }

        /// <summary>
        /// Spineアニメーションを再生
        /// testAnimationNameに再生したいアニメーション名を記載してください。
        /// </summary>
        void PlayAnimation()
        {
            switch (currentState)
            {
                case State.Idle:
                    // アニメーション「Idle」を再生
                    spineAnimationState.SetAnimation(0, idleAnimation, true); // アニメーションの名前は後で変えます
                    break;
                case State.Jump:
                    // アニメーション「Jump」を再生
                    PlayAnimation2();
                    //spineAnimationState.SetAnimation(0, testAnimationName, true); // アニメーションの名前は後で変えます
                    break;
                case State.Walk:
                    // 向きごとにアニメーションを分ける
                    if (currentDirection == Direction.Left)
                    {
                        // アニメーション「WalkLeft」を再生
                        spineAnimationState.SetAnimation(0, walkAnimation, true); // アニメーションの名前は後で変えます
                    }
                    else
                    {
                        // アニメーション「WalkRight」を再生
                        spineAnimationState.SetAnimation(0, walkAnimation, true); // アニメーションの名前は後で変えます
                    }
                    break;
                case State.Interact:
                    if (currentInteraction == InteractionState.Right)
                    {
                        if (currentDirection == Direction.Right)
                            // アニメーション「PushRight」を再生
                            spineAnimationState.SetAnimation(0, pushAnimation, true); // アニメーションの名前は後で変えます
                        else if (currentDirection == Direction.Left)
                            // アニメーション「PullLeft」を再生
                            spineAnimationState.SetAnimation(0, pullAnimation, true); // アニメーションの名前は後で変えます
                    }
                    else if (currentInteraction == InteractionState.Left)
                    {
                        if (currentDirection == Direction.Right)
                            // アニメーション「PullRight」を再生
                            spineAnimationState.SetAnimation(0, pullAnimation, true); // アニメーションの名前は後で変えます
                        else if (currentDirection == Direction.Left)
                            // アニメーション「PushLeft」を再生
                            spineAnimationState.SetAnimation(0, pushAnimation, true); // アニメーションの名前は後で変えます
                    }
                    else
                    {
                        // アニメーション「Idle」を再生
                        spineAnimationState.SetAnimation(0, jumpAnimation, true); // アニメーションの名前は後で変えます
                    }
                    break;
                default:
                    break;
            }
        }
    }

    void PlayAnimation2()
    {
        // アニメーション「testAnimationName」を再生
        TrackEntry trackEntry = spineAnimationState.SetAnimation(0, jumpAnimation, true);

        // 完了通知を取得準備
        trackEntry.Complete += OnSpineComplete;
    }

    void OnSpineComplete(TrackEntry trackEntry)
    {
        // アニメーション完了時に行う処理を記載
        isJump = false;
    }
}