using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    bool setMenu;

    private void Start()
    {
        menu.SetActive(false);
        setMenu = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && setMenu == false)
        {
            Time.SetTime(0f);
            menu.SetActive(true);
            setMenu = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && setMenu == true)
        {
            Time.SetTime(1f);
            menu.SetActive(false);
            setMenu = false;
        }
    }

    public void OnClickBackButton()
    {
        Time.SetTime(1f);
        menu.SetActive(false);
        setMenu = false;
    }
}
