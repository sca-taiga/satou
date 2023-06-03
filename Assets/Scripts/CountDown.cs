using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] float CountDownTime;
    [SerializeField] private Text TextCountDown;
    [SerializeField] private GameObject StartPanel;
/*
    void Start()
    {
        CountDownTime = 4;
    }
*/
    // Update is called once per frame
    void Update()
    {
        if(CountDownTime > 0)
        {
            TextCountDown.text = (( int) (CountDownTime)).ToString("0");
            CountDownTime -= Time.deltaTime;
        }

        if(CountDownTime < 0)
        {
            StartPanel.SetActive(false);
        }
    }
}
