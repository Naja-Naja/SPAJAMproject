using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Utils : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     var test = this.getAntCountPerSec(60, 240);
    //     UnityEngine.Debug.Log(test);
    //     float sum = 0;
    //     for (int i = 0; i < test.Count; i++)
    //     {
    //         UnityEngine.Debug.Log(test[i]);
    //         sum += test[i];
    //     }
    //     UnityEngine.Debug.Log(sum);
    // }

    // Update is called once per frame
    void Update()
    {

    }

    public List<float> getAntCountPerSec(int divideCount, int antCount)
    {
        if (divideCount == 0)
        {
            throw new IndexOutOfRangeException("divideCountは1以上です。");
        }
        // 傾き調整変数 2
        int TILT_PARAM = 2;
        // 一定に出現擦る場合の出現数
        double CONSTANT_NUM = antCount / divideCount;

        double DELTA_Y = (double)CONSTANT_NUM;
        double DELTA_X = divideCount / TILT_PARAM;
        double TILT = (double)DELTA_Y / (double)DELTA_X;

        // 1秒間に出現する数
        var result = new List<float>();
        for (int i = 0; i < divideCount; i++)
        {
            double n = (double)TILT * i;
            result.Add((float)n);
        }
        return result;
    }
}
