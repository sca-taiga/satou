using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
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
        //Lighting();
        SceneManager.LoadScene("Stage1");

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
