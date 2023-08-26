using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageManager2 : MonoBehaviour
{
    private int nowPage;
    [SerializeField] GameObject PageOne;
    [SerializeField] GameObject PageTwo;
    [SerializeField] GameObject PageThree;

    private void Start()
    {
        nowPage = 1;
        UpdatePageVisibility();
    }

    private void UpdatePageVisibility()
    {
        PageOne.SetActive(nowPage == 1);
        PageTwo.SetActive(nowPage == 2);
        PageThree.SetActive(nowPage == 3);
    }

    public void OnClickRightButton()
    {
        nowPage = (nowPage % 3) + 1; // ページ番号を1から3までループ
        UpdatePageVisibility();
    }
}
