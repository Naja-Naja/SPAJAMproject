using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class CountDownSE : MonoBehaviour
{
    public GameProperties properties;
    [SerializeField] AudioClip SE;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var time = properties.time;
        if (time <= 5)
        {
            var task = soundDireySec();
            task.Wait();
        }
    }

    Task soundDireySec()
    {
        AudioManager.SE_Play(SE);
        return Task.Delay(1000);
    }
}
