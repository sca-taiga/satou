using Spine.Unity;
using UnityEngine;
using Spine;

/// <summary> Spine�A�j���[�V�����̍Đ����m�F�T���v���N���X </summary>
public class SpineMove : MonoBehaviour
{
    /// <summary> �Đ�����A�j���[�V������ </summary>
    [SerializeField]
    private string idleAnimation = "wait/taiki"; // ���A�j���[�V���������킩��₷���ύX����

    [SerializeField]
    private string jumpAnimation= "jump/jump"; // ���A�j���[�V���������킩��₷���ύX����

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

    // �A�j���[�V�����̏�ԕω��̂悤�ȉ���ނ���Ԃ�����p�^�[���ł�bool���enum�ŊǗ���������y�ł��B
    // ������������������������������������������������������������

    private State oldState = State.Idle; // 1f�O�̏��
    private State currentState = State.Idle; // ���݂̏��
    // ��Ԃ̗�
    private enum State
    {
        Idle,
        Jump,
        Walk,
        Interact
    }
    private Direction currentDirection = Direction.Right; // ���݂̌���
    // �����̗�
    private enum Direction
    {
        None,
        Right,
        Left
    }
    /// <summary>
    /// OnTrigger�Ƃ��Ŕ���\��
    /// </summary>
    [SerializeField] private InteractionState currentInteraction = InteractionState.Right; // ���݂̌𗬏��
    // �𗬏��(����\�I�u�W�F�N�g���߂��ɂ��邩�ۂ�)�̗�
    private enum InteractionState
    {
        None, // �Ȃ�
        Right,// �E�ɂ���
        Left  // ���ɂ���
    }
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
        if(isJump) return;
        //Space�L�[�ŃW�����v
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
            currentState = State.Jump; // ���݂̏�Ԃ��W�����v�ɐ؂�ւ���
        }
        //shift+A or D�L�[�ŕ�����������
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            // ���݂̏�Ԃ𑀍�ɐ؂�ւ���
            if (Input.GetKey(KeyCode.A))
            {
                currentDirection = Direction.Left; // ���݂̌��������ɐ؂�ւ���
                currentState = State.Interact;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                currentDirection = Direction.Right; // ���݂̌��������ɐ؂�ւ���
                currentState = State.Interact;
            }
            else currentState = State.Idle; // LShift�̂݉�����Ă��Ԃ̏ꍇ��Idle�ɐ؂�ւ���
        }
        //A�L�[�ō��ړ�
        else if (Input.GetKey(KeyCode.A))
        {
            currentState = State.Walk; // ���݂̏�Ԃ�����ɐ؂�ւ���
            currentDirection = Direction.Left; // ���݂̌��������ɐ؂�ւ���
        }
        //D�L�[�ŉE�ړ�
        else if (Input.GetKey(KeyCode.D))
        {
            currentState = State.Walk; // ���݂̏�Ԃ�����ɐ؂�ւ���
            currentDirection = Direction.Right; // ���݂̌������E�ɐ؂�ւ���
        }
        else
        {
            currentState = State.Idle; // �������Ԃ̏ꍇ��Idle�ɐ؂�ւ���
        }
        //��Ԃ̕ω����������ꍇ�A�j���[�V������؂�ւ���
        if (oldState != currentState)
        {
            PlayAnimation();
            oldState = currentState;
        }

        /// <summary>
        /// Spine�A�j���[�V�������Đ�
        /// testAnimationName�ɍĐ��������A�j���[�V���������L�ڂ��Ă��������B
        /// </summary>
        void PlayAnimation()
        {
            switch (currentState)
            {
                case State.Idle:
                    // �A�j���[�V�����uIdle�v���Đ�
                    spineAnimationState.SetAnimation(0, idleAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                    break;
                case State.Jump:
                    // �A�j���[�V�����uJump�v���Đ�
                    PlayAnimation2();
                    //spineAnimationState.SetAnimation(0, testAnimationName, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                    break;
                case State.Walk:
                    // �������ƂɃA�j���[�V�����𕪂���
                    if (currentDirection == Direction.Left)
                    {
                        // �A�j���[�V�����uWalkLeft�v���Đ�
                        spineAnimationState.SetAnimation(0, walkAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                    }
                    else
                    {
                        // �A�j���[�V�����uWalkRight�v���Đ�
                        spineAnimationState.SetAnimation(0, walkAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                    }
                    break;
                case State.Interact:
                    if (currentInteraction == InteractionState.Right)
                    {
                        if (currentDirection == Direction.Right)
                            // �A�j���[�V�����uPushRight�v���Đ�
                            spineAnimationState.SetAnimation(0, pushAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                        else if (currentDirection == Direction.Left)
                            // �A�j���[�V�����uPullLeft�v���Đ�
                            spineAnimationState.SetAnimation(0, pullAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                    }
                    else if (currentInteraction == InteractionState.Left)
                    {
                        if (currentDirection == Direction.Right)
                            // �A�j���[�V�����uPullRight�v���Đ�
                            spineAnimationState.SetAnimation(0, pullAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                        else if (currentDirection == Direction.Left)
                            // �A�j���[�V�����uPushLeft�v���Đ�
                            spineAnimationState.SetAnimation(0, pushAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                    }
                    else
                    {
                        // �A�j���[�V�����uIdle�v���Đ�
                        spineAnimationState.SetAnimation(0, jumpAnimation, true); // �A�j���[�V�����̖��O�͌�ŕς��܂�
                    }
                    break;
                default:
                    break;
            }
        }
    }

    void PlayAnimation2()
    {
        // �A�j���[�V�����utestAnimationName�v���Đ�
        TrackEntry trackEntry = spineAnimationState.SetAnimation(0, jumpAnimation, true);

        // �����ʒm���擾����
        trackEntry.Complete += OnSpineComplete;
    }

    void OnSpineComplete(TrackEntry trackEntry)
    {
        // �A�j���[�V�����������ɍs���������L��
        isJump = false;
    }
}