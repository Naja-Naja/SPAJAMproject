using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingPopupManager : MonoBehaviour
{
    public void PushToTitleButton()
    {
        SceneManager.LoadScene("titleScene");
    }
}
