using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    float countTime = 0;

    public Time()
    {
    }

    private static float time;
    private static float time1;
    internal static float deltaTime;

    public static float Time1 { get; internal set; }

    public static float GetTime1()
    {
        return time1;
    }

    internal static void SetTime1(float value)
    {
        time1 = value;
    }

    public static float GetTime()
    {
        return time;
    }

    internal static void SetTime(float value)
    {
        time = value;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
