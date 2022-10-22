using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntMove : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] float speed;
    public bool catched = false;

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
}
