using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameProperties properties;
    [SerializeField] AntGenerete generete;
    int maxHP = 100;
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
        properties.score = properties.calorie * (properties.HP / maxHP);
        if (gameend == true && resultpop == false)
        {
            Instantiate(resultWindow, new Vector3(0, 0, 0), Quaternion.identity);
            resultpop = true;
        }
    }
}