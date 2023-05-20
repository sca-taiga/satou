
using System;
using System.Collections;
using UnityEngine;

public class State_SwitchFloorManage : MonoBehaviour
{

    // �t���A���X�C�b�`���J�E���g�ێ�
    protected uint _switchCount = 0;
    public uint SwitchCount
    {
        get { return _switchCount; }
        protected set { _switchCount = value; }
    }
    // �v���C���[�X�e�[�^�X�m�ۗp�ϐ�
    protected State_Player _State;

    // ���ޏ��Ԃ̔ԍ��Ƃ炵���킹�p�ϐ�
    protected int _flowSwitchNo = 0;
    public int FlowSwitchNo
    {
        get { return _flowSwitchNo; }
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        // ���񎞂ɃJ�E���g���Ă���
        checkAreaSwitches();
        // �v���C���[�X�e�[�^�X���擾
        _State = GameObject.FindGameObjectsWithTag("State_Manager")[0].GetComponent<State_Player>();

    }

    private void checkAreaSwitches()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
    }

    // �t���A���X�C�b�`���J�E���g
    private uint _checkAreaSwitches()
    {
        foreach (Transform child in transform)
        {
            SwitchCount += 1;
        }

        return SwitchCount;
    }


}