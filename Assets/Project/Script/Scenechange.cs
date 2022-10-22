using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
    private Button button;
    [SerializeField] string changeScene;
    void Start()
    {
        button= this.gameObject.GetComponent<Button>();
        button.onClick.AddListener(ClickScenechange);
    }
    void ClickScenechange()
    {
        SceneManager.LoadScene(changeScene);
    }
}
