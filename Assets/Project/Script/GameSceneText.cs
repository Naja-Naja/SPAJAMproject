using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSceneText : MonoBehaviour
{
    [SerializeField] GameProperties properties;
    [SerializeField] TextMeshProUGUI uGUI;
    void Start()
    {
        uGUI.text = "Loading";
    }
    private void Update()
    {
        string score = "Score:";
        int scorenum = properties.score;
        string time = "\nTime:";
        int timenum = properties.time;
        string text = score + scorenum.ToString() + time + timenum.ToString();
        uGUI.text = text;
    }
}
