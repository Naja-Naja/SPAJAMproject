using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AudioManager : MonoBehaviour
{
    [SerializeField] public AudioSource BGM = null;
    [SerializeField] public AudioSource SE = null;
    static AudioSource BGM_audio = null;
    static AudioSource SE_audio = null;
    static Sequence seq;

    void Awake()
    {
        SE_audio = SE;
        BGM_audio = BGM;
    }
    /// <summary>
    /// Audioclip�Ƃ��ēn���ꂽ���ʉ��𑦍��ɍĐ�����
    /// TODO�@�Ă΂ꂽ�ۂɑ��̌��ʉ����Đ����ł����AudioSource��AddCompornent���Ă����ōĐ�����
    /// </summary>
    /// <param name="clip"></param>
    public static void SE_Play(AudioClip clip)
    {
        SE_audio.clip = clip;
        SE_audio.Play();
    }
    /// <summary>
    /// Audioclip�Ƃ��ēn���ꂽBGM��1�b�����ăt�F�[�h���čĐ�����
    /// </summary>
    /// <param name="clip"></param>
    public static void BGM_Play(AudioClip clip)
    {
        if (clip == null) { Debug.LogWarning("BGM was not found. Please set AudioClip."); }
        if (seq != null && DOTween.IsTweening(seq))
        {
            // �������Ă��Ȃ�����Restart����
            seq.Restart();
            Debug.Log("AudioManager:BGMrestart");
        }
        else
        {
            var tweenFadeOut = DOTween.To(() => BGM_audio.volume, x => BGM_audio.volume = x, 0f, 1f);
            var tweenFadeIn = DOTween.To(() => BGM_audio.volume, x => BGM_audio.volume = x, 0.5f, 1f).OnStart(() => changeBGM(clip));
            seq = DOTween.Sequence().Append(tweenFadeOut).Append(tweenFadeIn);
        }
        Debug.Log("AudioManager:playBGM");
    }
    private static void changeBGM(AudioClip clip)
    {
        BGM_audio.clip = clip;
        BGM_audio.Play();
    }
}
