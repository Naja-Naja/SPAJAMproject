using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSE : MonoBehaviour
{
    [SerializeField] AudioClip SE;

    public void onClick()
    {
        AudioManager.SE_Play(SE);
    }
}
