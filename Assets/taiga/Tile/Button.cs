using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private bool firstPush = false;
    public void PressStart()
    { 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Press Start!");
            if(!firstPush)
            { 
    }

            // Update is called once per frame
            Debug.Log("Go Next Scene!");
            {
                firstPush = true;
    }
}
}
}