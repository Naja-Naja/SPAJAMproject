using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameProperties properties;
    [SerializeField] AntGenerete generete;
    public int maxHP = 100;
    public bool gameend = false;
    public bool resultpop = false;
    [SerializeField] GameObject resultWindow;
    private void Start()
    {
        properties.HP = maxHP;
        generete.CountStart();
        gameend = false;
    }
    private void Update()
    {
       
        var tmp= (float)properties.calorie * ((float)properties.HP / (float)maxHP);
        properties.score = (int)tmp;
        if (gameend == true && resultpop == false)
        {
            Instantiate(resultWindow, new Vector3(0, 0, 0), Quaternion.identity);
            resultpop = true;
        }
    }
}