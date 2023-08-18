using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    private int nowPage;
    [SerializeField] GameObject PageOne;
    [SerializeField] GameObject PageTwo;
    [SerializeField] GameObject PageThree;

    private void Start()
    {
        nowPage = 1;
        //PageOne.SetActive(true);
        //PageTwo.SetActive(false);
        //PageThree.SetActive(false);

    }

    public void OnClickRightButton()
    {
        if(nowPage == 1)
        {
            PageOne.SetActive(false);
            PageTwo.SetActive(true);
            nowPage = 2;
            Debug.Log("�X�e�[�W�P����Q�ֈړ� nowPage:" + nowPage);
            return;
        }
        if(nowPage == 2)
        {
            PageTwo.SetActive(false);
            PageThree.SetActive(true);
            nowPage = 3;
            Debug.Log("�X�e�[�W�Q����R�ֈړ� nowPage:" + nowPage);
            return;
        }
        if(nowPage == 3)
        {
            PageThree.SetActive(false);
            PageOne.SetActive(true);
            nowPage = 1;
            Debug.Log("�X�e�[�W�R����P�ֈړ� nowPage:" + nowPage);
            return;
        }
    }
/**
    public void OnClickLeftButton()
    {
        if(nowPage == 2)
        {
            PageTwo.SetActive(false);
            PageOne.SetActive(true);
            nowPage = 1;
            Debug.Log("�X�e�[�W�Q����P�ֈړ� nowPage: " + nowPage);
            return;
        }
        else if(nowPage == 3)
        {
            PageThree.SetActive(false);
            PageTwo.SetActive(true);
            nowPage = 2;
            Debug.Log("�X�e�[�W�R����Q�ֈړ� nowPage:" + nowPage);
            return;
        }
    }
**/
}
