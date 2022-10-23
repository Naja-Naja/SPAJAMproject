using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AntMove : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] float speed;
    public bool catched = false;
    [SerializeField] AudioClip clip;

    GameObject clickedGameObject;

    void Start()
    {
        catched = false;
        CreateObject();
    }

    void CreateObject()
    {
        Player = GameObject.Find("Player");
    }

    void Move()
    {
        // 蟻オブジェクトがプレイヤーオブジェクトに群がる処理を書く
        this.transform.position = Vector2.MoveTowards(this.transform.position, new Vector2(Player.transform.position.x, Player.transform.position.y), speed * Time.deltaTime);
    }
    void Update()
    {
        if (catched == true) { return; }
        Move();
    }
    public void antfly()
    {
        float rnd = Random.Range(-5f, 5f);
        var tmp = new Vector3(rnd, 6, 0);
        DOTween.To(() => this.transform.position, x => transform.localPosition = x, tmp, 0.3f).SetEase(Ease.Linear).OnComplete(() => Destroy(this.gameObject));
        AudioManager.SE_Play(clip);
    }
}
