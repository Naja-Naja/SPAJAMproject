using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntGenerete : MonoBehaviour
{
    private List<float> timeList = new List<float>();
    [SerializeField]int split;
    [SerializeField] GameProperties properties;
    [SerializeField] GameObject ant;
    [SerializeField] GameObject player;
    [SerializeField] Utils utils;
    private void Start()
    {
        //floatlist‚ð“¾‚é
        timeList= utils.getAntCountPerSec(split, properties.calorie);
        //timeList.Add(0.5f);
        StartCoroutine("generate");
    }
    IEnumerator generate()
    {
        float spawnrate = 0;
        foreach (var item in timeList)
        {
            for (int i = 0; i < 60/split; i++)
            {
                spawnrate = spawnrate + item;
                Debug.Log(item);
                while (spawnrate > 1)
                {
                    Instantiate(ant, generatePos(), Quaternion.identity);
                    Debug.Log("generateant");
                    spawnrate--;
                }
                yield return new WaitForSeconds(1f);
            }
        }
        Debug.Log("gameend");
    }
    Vector3 generatePos()
    {
        int random = Random.Range(-1, 1);
        if (random == 0) { random = 1; }
        float rnd = Random.Range(-3f, 3f);
        var tmp = new Vector3(rnd, random*6, 0);
        return tmp;
    }
}
