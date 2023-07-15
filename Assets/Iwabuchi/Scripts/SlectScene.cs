using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlectScene : MonoBehaviour
{
    [SerializeField] private GameObject backObj1;
    [SerializeField] private GameObject backObj2;
    [SerializeField] private GameObject backObj3;
    private int rnd;
    // Start is called before the first frame update
    void Start()
    {
        RandomObj();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RandomObj()
    {

        rnd = Random.Range(1,3);
        if(rnd == 1)
        {
            backObj1.SetActive(true);
        }
        if (rnd == 2)
        {
            backObj2.SetActive(true);
        }
        if (rnd == 3)
        {
            backObj3.SetActive(true);
        }

    }
}
