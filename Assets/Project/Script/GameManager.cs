using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameProperties properties;
    int maxHP = 100;
    private void Start()
    {
        properties.HP = maxHP;
    }
    private void Update()
    {
        properties.score = properties.calorie * (properties.HP / maxHP);
    }
}