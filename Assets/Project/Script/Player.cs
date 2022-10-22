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
        hp = properties.HP;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isHit = true;
        if (collision.gameObject.tag == "Ant")
        {
            if (hp > 0)
            {
                hp = hp - 10;
                Debug.Log("ant:" + hp);
                // ダメージを1秒受けない
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

}