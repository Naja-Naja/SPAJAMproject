using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefabPage : MonoBehaviour
{

    public GameObject PrefabPage;
    
    public void onClick()
    {
        Vector3 position = new Vector3(129f, 286.5f, 0f);
        Instantiate(PrefabPage, position, Quaternion.identity);
    }
}
