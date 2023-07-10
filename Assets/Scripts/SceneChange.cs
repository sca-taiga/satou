using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneChange : MonoBehaviour
{
    Color color;
    float cla;
    float speed = 0.01f;
    [SerializeField] GameObject target;
    private void Start()
    {
        color = target.GetComponent<Image>().color;
    }

    public void OnClickStartButton()
    {
        Lighting();
        //SceneManager.LoadScene("Stage");
        
    }
    public void OnClickReStartButton()
    {
        SceneManager.LoadScene("Title");
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

    IEnumerator Display()
    {
        while (cla > 0f)
        {
            cla -= speed;
            color.a = cla;
            yield return null;
        }
    }
    IEnumerator Restore()
    {
        while (cla < 1f)
        {
            cla += speed;
            color.a = cla;
            yield return null;
        }
    }
    private void Lighting()
    {
        while (cla < 255f)
        {
            cla += speed;
            color.a = cla;
        }
    }
}
