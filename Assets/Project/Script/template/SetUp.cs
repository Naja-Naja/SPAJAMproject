using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUp : Singleton
{
    [SerializeField] GameObject Audio;
    [SerializeField] GameObject sceneController;

    private void Start()
    {
        var tmp = Instantiate(Audio);
        DontDestroyOnLoad(tmp);
        tmp = Instantiate(sceneController);
        DontDestroyOnLoad(tmp);
    }
}
