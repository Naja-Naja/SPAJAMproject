using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHTP : MonoBehaviour
{

    PageInAnimation pageInAni;
    [SerializeField]  GameObject gameObj;
    // Start is called before the first frame update
    void Start()
    {
        pageInAni.Animation3(gameObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
