
using UnityEngine;

public class Switch: MonoBehaviour
{
    bool Depature = false;
    private void Update()
    {
        if (Depature)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 5, Space.World);
        }
    }

}