using UnityEngine;

public class AudioManeger : MonoBehaviour
{
    [Header("============Surse Aduio===========")]
    [SerializeField] AudioSource sursaSFX;
    [SerializeField] AudioSource sursaSong;

    [Header("============Clipuri Aduio===========")]
    public AudioClip Cut;
    public AudioClip stors;
    public AudioClip sell;
    public AudioClip muzic;


    public void Start()
    {
        sursaSFX.volume = 0.4f;
        sursaSong.volume= 0.4f;
        sursaSong.Play();
    }

    public void SFXVolumePlus()
    {
        sursaSFX.volume += 0.1f;
    }


    public void SFXVolumeMinus()
    {
        sursaSong.volume -= 0.1f;
    }

    public void SongVolumePlus()
    {
        sursaSong.volume += 0.1f;
    }


    public void SongVolumeMinus()
    {
        sursaSong.volume -= 0.1f;
    }
    public void SFX(AudioClip clip)
    {
        sursaSFX.clip = clip;
        sursaSFX.Play();
    }

   
}
