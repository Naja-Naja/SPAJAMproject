using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CreatePrefabPage : MonoBehaviour
{

    public GameObject PrefabPage;
    PageInAnimation pageAni;
    
    public void onClick()
    {
        Vector3 position = new Vector3(129f, 286.5f, 0f);
        var tmp = 
        Instantiate(PrefabPage, position, Quaternion.identity);
        //Debug.Log(tmp.name);
        ////Debug.Log(GameObject.Find("HowToPlayPrefab").transform.childCount);
        //GameObject child = transform.Find("GameObjectHTP").gameObject;
        //pageAni.Animation3(child);
    }
}
