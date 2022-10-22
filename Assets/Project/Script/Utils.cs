using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Utils : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
    //     var test = this.getAntCountPerSec(10, 100);
    //     UnityEngine.Debug.Log(test);
    //     for (int i = 0; i < test.Count; i++)
    //     {
    //         UnityEngine.Debug.Log(test[i]);
    //     }
    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }

    List<float> getAntCountPerSec(int divideCount, int antCount)
    {
        if (divideCount == 0)
        {
            throw new IndexOutOfRangeException("divideCountは1以上です。");
        }
        // 傾き調整変数 2
        int TILT_PARAM = 2;
        // 最低出現数
        int MIN_ANT_COUNT = 1;
        // 一定に出現擦る場合の出現数
        float CONSTANT_NUM = antCount / divideCount;

        float DELTA_Y = CONSTANT_NUM - MIN_ANT_COUNT;
        float DELTA_X = divideCount / TILT_PARAM;
        float TILT = DELTA_Y / DELTA_X;

        // 1秒間に出現する数
        var result = new List<float>();
        for (int i = 0; i < divideCount; i++)
        {
            float n = TILT * i + MIN_ANT_COUNT;
            result.Add(n);
        }
        return result;
    }
}
