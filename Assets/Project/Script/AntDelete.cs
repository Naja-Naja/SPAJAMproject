using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntDelete : MonoBehaviour
{
    GameObject clickedGameObject;
    bool catchAnt;

    bool deleteAnt;

    GameObject Ant;

    Vector3 mousePositionCache;

    void JudgeTag()
    {
        // �^�b�v������
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
                //Debug.Log("ant�����");
                Ant = isHit.collider.gameObject;
                // ���̏u�Ԃ̍��W���擾����
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
            var nowPosition = Input.mousePosition;
            // Debug.Log(Camera.main.ScreenToWorldPoint(nowPosition));
            Ant.transform.position = Camera.main.ScreenToWorldPoint(nowPosition);
            Ant.transform.position = new Vector3(Ant.transform.position.x, Ant.transform.position.y, 0);
            Debug.Log(Vector3.Distance(nowPosition, mousePositionCache));

            if (Vector3.Distance(nowPosition, mousePositionCache) > 40)
            {
                // �J�[�\���̍��W���Ƃ�
                // ���ݍ��W�ƃJ�[�\�����ʂ��r����
                //  ���ȏ�Ȃ�removeant=true
                deleteAnt = true;
            }

        }
        if (Input.GetMouseButtonUp(0) == true)
        {
            if (deleteAnt == true)
            {
                // TODO: ��ʊO�ɔ��ł���
                Destroy(Ant);
                // �L���b�V�����N���A
            }
            Ant = null;
            mousePositionCache = new Vector3(0, 0, 0);
            catchAnt = false;
            deleteAnt = false;

        }
    }
}
