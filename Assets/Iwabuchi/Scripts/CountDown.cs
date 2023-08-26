using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] float initialCountDownTime;
    private float countDownTime;
    [SerializeField] private Text textCountDown;
    [SerializeField] private GameObject startPanel;

    private bool isCounting = true;

    private void Start()
    {
        ResetCountDown();
    }

    void Update()
    {
        if(countDownTime > 0)
        {
            textCountDown.text = (( int) (countDownTime)).ToString("0");
            countDownTime -= Time.deltaTime;
        }
        else
        {
            isCounting = false;
            startPanel.SetActive(false);
        }
    }

    public void ResetCountDown()
    {
        countDownTime = initialCountDownTime;
        textCountDown.text = ((int)(countDownTime + 1)).ToString("0");
        isCounting = true;
        startPanel.SetActive(true);
    }
}
