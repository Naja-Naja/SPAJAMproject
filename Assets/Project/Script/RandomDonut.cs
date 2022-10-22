using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class RandomDonut : MonoBehaviour
{
    private Image image;
    public Sprite[] sprite;
    // Start is called before the first frame update
    void Start()
    {
        var random = new System.Random();

        image = this.gameObject.GetComponent<Image>();
        image.sprite = sprite[random.Next(0, 4)];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
