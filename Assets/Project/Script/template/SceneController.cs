using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private AudioClip bgm;
    void Start()
    {
        SceneManager.sceneLoaded += SceneLoaded;

        var tmp = GameObject.FindGameObjectWithTag("SceneData");
        if (tmp == null) { return; }
        var tmp2 = tmp.GetComponent<SceneData>();
        bgm = tmp2.SceneBGM;
        AudioManager.BGM_Play(bgm);
    }
    void SceneLoaded(Scene nextScene, LoadSceneMode mode)
    {
        Debug.Log("SceneLoad");
        var tmp = GameObject.FindGameObjectWithTag("SceneData");
        Debug.Log(tmp);
        if (tmp == null) 
        {
            Debug.LogWarning("bgm is not found. Give a SceneData component to an object with a SceneData tag and place it on the scene.");
            return;
        }
        var tmp2 = tmp.GetComponent<SceneData>();
        bgm = tmp2.SceneBGM;
        AudioManager.BGM_Play(bgm);
    }
}
