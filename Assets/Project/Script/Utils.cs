using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Utils : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 150匹が X 分を60分割して1分割あたりで出現する数
        var test = this.getAntCountPerSec(60, 1000);
        UnityEngine.Debug.Log(test);
        double sum = 0;
        for (int i = 0; i < test.Count; i++)
        {
            UnityEngine.Debug.Log(test[i]);
            sum += test[i];
        }
        UnityEngine.Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {

    }

    List<float> getAntCountPerSec(int divideCount, int antCount)
    {
        if (divideCount == 0)
        {
            throw new IndexOutOfRangeException("divideCountは1以上です。");
        }
        // 一定に出現擦る場合の出現数
        double CONSTANT_NUM = antCount / divideCount;

        double DELTA_Y = CONSTANT_NUM;
        double DELTA_X = divideCount / 2;
        double TILT = DELTA_Y / DELTA_X;

        // 1秒間に出現する数
        var result = new List<float>();
        for (int i = 0; i < divideCount; i++)
        {
            double n = TILT * i;
            float n1 = (float)Math.Ceiling(n);
            result.Add(n1);
        }
        return result;
    }
}
