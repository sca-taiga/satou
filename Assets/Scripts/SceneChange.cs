using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Stage1");
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
