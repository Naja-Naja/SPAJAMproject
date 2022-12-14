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
        if (button == null) { return; }
        button.onClick.AddListener(ClickScenechange);
    }
    public void ClickScenechange()
    {
        SceneManager.LoadScene(changeScene);
    }
}
