using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ResultViewAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Animationhoge();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Animation1() // ägëÂÇµÇƒÇ≠ÇÈÇ‚Ç¬
    {
        this.transform.localScale = new Vector3(0, 0, 1f);
        transform.DOScale(new Vector3(7.5f, 15f, 1f), 1f).SetEase(Ease.InOutSine);
    }

    public void Animation2() // è„Ç©ÇÁåªÇÍÇÈ
    {
        this.transform.localPosition = new Vector3(0, 670f, 1f);
        transform.DOLocalMove(new Vector3(-17.88045f, 11.05548f, -0.5673293f), 1f).SetEase(Ease.OutSine);
    }

    public void Animation3() // â∫Ç©ÇÁåªÇÍÇÈ
    {
        this.transform.localPosition = new Vector3(0, -670f, 1f);
        transform.DOLocalMove(new Vector3(-17.88045f, 11.05548f, -0.5673293f), 1f).SetEase(Ease.OutSine);
    }
}