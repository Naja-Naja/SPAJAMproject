using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceholderValue : MonoBehaviour
{
    public Text TextFrame;
    public GameProperties gameProperties;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextFrame.text = gameProperties.calorie.ToString();
    }
}
