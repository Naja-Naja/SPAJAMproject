using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] AudioMixer Audiomixer;
    [SerializeField] Scrollbar BGM_slider;
    [SerializeField] Scrollbar SE_slider;
    private void Start()
    {
        Audiomixer.GetFloat("BGM", out float vol);
        BGM_slider.value = (vol + 80) / 80;
        BGM_slider.onValueChanged.AddListener(delegate { BgmVolChange(); });
        Audiomixer.GetFloat("SE", out float vol2);
        SE_slider.value = (vol2 + 80) / 80;
        SE_slider.onValueChanged.AddListener(delegate { SEVolChange(); });
    }
    public void BgmVolChange()
    {
        Audiomixer.SetFloat("BGM", (BGM_slider.value * 80) - 80);
    }
    public void SEVolChange()
    {
        Audiomixer.SetFloat("SE", (SE_slider.value * 80) - 80);
    }

}
