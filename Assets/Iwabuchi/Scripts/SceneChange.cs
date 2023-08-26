using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public void OnClickReStartButton()
    {
        if (SceneManager.GetActiveScene().name == "Stage")
        {
            SceneManager.LoadScene("Stage");
        }
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            SceneManager.LoadScene("Stage1");
        }
        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            SceneManager.LoadScene("Stage2");
        }
        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            SceneManager.LoadScene("Stage3");
        }
        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            SceneManager.LoadScene("Stage4");
        }
        if (SceneManager.GetActiveScene().name == "Stage5")
        {
            SceneManager.LoadScene("Stage5");
        }
        if (SceneManager.GetActiveScene().name == "Stage6")
        {
            SceneManager.LoadScene("Stage6");
        }
        if (SceneManager.GetActiveScene().name == "Stage7")
        {
            SceneManager.LoadScene("Stage7");
        }
        if (SceneManager.GetActiveScene().name == "Stage8")
        {
            SceneManager.LoadScene("Stage8");
        }
        if (SceneManager.GetActiveScene().name == "Stage9")
        {
            SceneManager.LoadScene("Stage9");
        }
        if (SceneManager.GetActiveScene().name == "Stage10")
        {
            SceneManager.LoadScene("Stage10");
        }
    }
    public void OnClickClearButton()
    {
        SceneManager.LoadScene("Clear");
    }
    public void OnClickTitleButton()
    {
        SceneManager.LoadScene("Title");
    }

    public void OnClickQuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }


}
