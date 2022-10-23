using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalorieValueCtrl : MonoBehaviour
{
    public Text text;
    public GameProperties gameProperties;
    [SerializeField] private InputField TestInputField;
    // Start is called before the first frame update
    void Start()
    {
        gameProperties.calorie = 60;
    }

    // Update is called once per frame
    public void GetText()
    {
        text = text.GetComponent<Text>();
        gameProperties.calorie = int.Parse(text.text);
        if(gameProperties.calorie > 1000)
        {
            gameProperties.calorie = 1000; 
            TestInputField.text = gameProperties.calorie.ToString();
            //text.text = gameProperties.calorie.ToString();
        }
        else if(gameProperties.calorie < 60)
        {
            gameProperties.calorie = 60;
            TestInputField.text = gameProperties.calorie.ToString();
            //text.text = gameProperties.calorie.ToString();
        }
        
    }
    void Update()
    {
        //Debug.Log(text.text);
        //Debug.Log(gameProperties.calorie);

    }
}
