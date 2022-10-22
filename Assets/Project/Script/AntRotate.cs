using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AntRotate : MonoBehaviour
{
    GameObject[] player;
    // Start is called before the first frame update
    void Start()
    {
        var antTransform = this.gameObject.GetComponent<Transform>();
        player = GameObject.FindGameObjectsWithTag("Player");
        UnityEngine.Debug.Log(player[0].transform.localPosition);
        antTransform.rotation = Quaternion.FromToRotation(Vector3.up, player[0].transform.position - this.transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
