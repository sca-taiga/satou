
using System;
using System.Collections;
using UnityEngine;

public class State_SwitchFloorManage : MonoBehaviour
{

    // フロア内スイッチ数カウント保持
    protected uint _switchCount = 0;
    public uint SwitchCount
    {
        get { return _switchCount; }
        protected set { _switchCount = value; }
    }
    // プレイヤーステータス確保用変数
    protected State_Player _State;

    // 踏む順番の番号照らし合わせ用変数
    protected int _flowSwitchNo = 0;
    public int FlowSwitchNo
    {
        get { return _flowSwitchNo; }
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        // 初回時にカウントしておく
        checkAreaSwitches();
        // プレイヤーステータスを取得
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

    // フロア内スイッチをカウント
    private uint _checkAreaSwitches()
    {
        foreach (Transform child in transform)
        {
            SwitchCount += 1;
        }

        return SwitchCount;
    }


}