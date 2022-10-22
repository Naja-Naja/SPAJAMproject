using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] GameProperties gameProperties;
    public void onClickBtn()
    {
        if (gameProperties.visualmode == GameVisualMode.spanyan)
        {
            gameProperties.visualmode = GameVisualMode.ant;
            //Debug.Log("spa -> ant");
        }
        else if(gameProperties.visualmode == GameVisualMode.ant)
        {
            gameProperties.visualmode = GameVisualMode.spanyan;
            //Debug.Log("ant -> spa");
        }
        
    }
}
