using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ResultManager : MonoBehaviour
{

    public void PushToTitleButton()
    {
        SceneManager.LoadScene("titleScene");
    }

    public void PushRetryButton()
    {
        SceneManager.LoadScene("MainGame");
    }

}
