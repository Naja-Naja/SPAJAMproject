using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpaOrAnt : MonoBehaviour
{
    public GameProperties properties;
    public Sprite[] sprite;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        var mode = properties.visualmode;
        UnityEngine.Debug.Log(mode);
        if (mode == GameVisualMode.spanyan)
        {
            var random = new System.Random();
            spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite[random.Next(1, 6)];
            this.transform.localScale = new Vector3(0.1f, 0.1f, 1);
        }
        else
        {
            spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite[0];
        }
    }
}
