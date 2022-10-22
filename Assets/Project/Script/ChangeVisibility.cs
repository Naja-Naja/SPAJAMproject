using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVisibility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField] GameProperties gameProperties;
    [SerializeField] private GameObject ant;
    [SerializeField] private GameObject spanyan;
    void Update()
    {
        if (gameProperties.visualmode == GameVisualMode.spanyan)
        {
            spanyan.SetActive(true);
            ant.SetActive(false);
            //Debug.Log(gameProperties.visualmode);
        }
        else if(gameProperties.visualmode == GameVisualMode.ant)
        {
            spanyan.SetActive(false);
            ant.SetActive(true);
            //Debug.Log(gameProperties.visualmode);
        }
    }


}
