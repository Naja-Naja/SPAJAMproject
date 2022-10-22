using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameProperties properties;

    private int hp;

    bool isHit;
    void Start()
    {
        hp = 100;// properties.HP;
        isHit = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isHit == true) { return; }

        if (collision.gameObject.tag == "Ant")
        {
            isHit = true;
            if (hp > 0)
            {
                hp = hp - 10;
                Debug.Log("ant:" + hp);
                properties.HP = hp;
                // ダメージを1秒受けない
                Debug.Log("call");
                StartCoroutine("WaitDamage");
            }
            else
            {
                // TODO: ゲームオーバー演出
            }
        }
    }

    IEnumerator WaitDamage()
    {
        yield return new WaitForSeconds(1);
        isHit = false;
    }
    void loop()
    {
        // タップしたら
    }
    private void Update()
    {
        Debug.Log("ishit  "+isHit);
    }

}