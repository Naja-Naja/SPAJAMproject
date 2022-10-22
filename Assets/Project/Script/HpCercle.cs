using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class HpCercle : MonoBehaviour
{
    public GameProperties properties;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        var hp = properties.HP;

        image = this.gameObject.GetComponent<Image>();
        image.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        var hp = properties.HP;
        float n = (float)hp / (float)100;
        image.fillAmount = n;
    }
}
