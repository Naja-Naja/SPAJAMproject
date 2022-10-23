using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class resultScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GameProperties properties;
    void Start()
    {
        text.text = "Score:\n"+properties.score.ToString()+"/"+properties.calorie.ToString();
    }
}
