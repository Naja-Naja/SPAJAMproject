using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject clickedGameObject;
    bool catchAnt;

    bool deleteAnt;

    GameObject Ant;

    Vector3 mousePositionCache;
    void Start()
    {
    }

    void JudgeTag()
    {
        // タップしたら
        if (Input.GetMouseButtonDown(0))
        {
            // clickedGameObject = null;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D isHit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (isHit.collider == null)
            {
                return;
            }
            if (isHit.collider.CompareTag("Ant"))
            {
                catchAnt = true;
                Debug.Log("antだよん");
                Ant = isHit.collider.gameObject;
                // この瞬間の座標を取得する
                mousePositionCache = Input.mousePosition;
            }
        }

    }
    void Update()
    {
        JudgeTag();
        if (catchAnt == true)
        {
            // Debug.Log(Ant.transform.position);
            // Debug.Log(Camera.main.gameObject.transform.position);
            Ant.transform.position = Camera.main.ScreenToWorldPoint(mousePositionCache);
            Ant.transform.position = new Vector3(Ant.transform.position.x, Ant.transform.position.y, 0);
            Debug.Log(Ant.transform.position);
            var nowPosition = Input.mousePosition;
            if (Vector3.Distance(nowPosition, mousePositionCache) > 0.2)
            {
                // カーソルの座標をとる
                // 現在座標とカーソル座礁を比較する
                //  一定以上ならremoveant=true
                deleteAnt = true;
            }

        }
        if (Input.GetMouseButtonUp(0) == true)
        {
            if (deleteAnt == true)
            {
                // TODO: 画面外に飛んでいく
                // Destroy(Ant);
                // キャッシュをクリア
            }
            Ant = null;
            mousePositionCache = new Vector3(0, 0, 0);
            catchAnt = false;

        }
    }
}