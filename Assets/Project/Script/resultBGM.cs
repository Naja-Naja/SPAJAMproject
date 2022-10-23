using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resultBGM : MonoBehaviour
{
    [SerializeField] AudioClip clip;
    private void Start()
    {
        AudioManager.BGM_Play(clip);
    }
}
