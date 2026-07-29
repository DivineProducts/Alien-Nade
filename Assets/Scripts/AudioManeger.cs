using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    [Header("============Surse Aduio===========")]
    [SerializeField] AudioSource sursaSFX;

    [Header("============Clipuri Aduio===========")]
    public AudioClip Cut;
    public AudioClip stors;
    public AudioClip sell;


    public void Start()
    {
        sursaSFX.volume = 0.5f;
    }

    public void SFXVolumePlus()
    {
        sursaSFX.volume += 0.1f;
    }
    public void SFXVolumeMinus()
    {
        sursaSFX.volume -= 0.1f;
    }
    public void SFX(AudioClip clip)
    {
        sursaSFX.clip = clip;
        sursaSFX.Play();
    }

}
