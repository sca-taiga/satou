using UnityEngine;
using UnityEngine.SceneManagement;  //Åu2Åv

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