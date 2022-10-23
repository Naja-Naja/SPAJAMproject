using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;


public class PlayerDelete : MonoBehaviour
{
    bool catchPlayer;

    bool deleteAnt;

    GameObject Player;
    GameObject Ant;
    [SerializeField] GameObject deletefield;

    Vector3 mousePositionCache;
    private MeshCollider meshCollider;
    void JudgeTag()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D isHit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (isHit.collider == null)
            {
                return;
            }
            if (isHit.collider.CompareTag("Player"))
            {
                catchPlayer = true;
                Debug.Log("playerだよん");
                Player = isHit.collider.gameObject;
                // この瞬間の座標を取得する
                // mousePositionCache = Input.mousePosition;
            }
        }

    }
    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ant")
    //    {
    //        Ant.gameObject.tag = collision.gameObject.tag;
    //        Debug.Log("Collision Stay");

    //        // TODO:タップした瞬間にプレイヤーの範囲に見えないコリジョンを発生させて
    //        // コリジョンにenterしてきたオブジェクトを見る
    //        // Destroyの引数にthis.1 いち
    //        // それに触れたアントを
    //    }
    //}

    void Update()
    {
        JudgeTag();

        if (catchPlayer == true)
        {
            var tmp = Instantiate(deletefield, this.transform.position, Quaternion.identity);
            Destroy(tmp, 0.1f);
            catchPlayer = false;
            // TODO: プレイヤーと接触しているオブジェクトを取得し、
            // AntだったらAntのtransform.positionを現在位置から-x(?)する
            //if (Player.transform.position == Ant.transform.position)
            //{
            //    Player.transform.position = new Vector3(0, 0, 0);
            //}

            //     var nowPosition = Input.mousePosition;
            //     Player.transform.position = Camera.main.ScreenToWorldPoint(nowPosition);
            //     Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);

            //     if (Vector3.Distance(nowPosition, mousePositionCache) > 40)
            //     {
            //         deleteAnt = true;
            //     }

        }

        //if (Input.GetMouseButtonUp(0) == true)
        //{
        //    if (deleteAnt == true)
        //    {
        //        Destroy(Player);
        //        // キャッシュをクリア
        //    }
        //    Player = null;
        //    mousePositionCache = new Vector3(0, 0, 0);
        //    catchPlayer = false;
        //    deleteAnt = false;
        //}
    }

}