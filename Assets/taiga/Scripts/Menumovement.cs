using UnityEngine;
using UnityEngine.SceneManagement;  //�u2�v

namespace Assets.taiga.Scripts
{
    public class Menumovement : MonoBehaviour
    {


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("menu");    
            }
        }
    }
}