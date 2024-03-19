using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public AudioClip bassClip;
    public AudioClip synthClip;
    public AudioClip snareClip;

    private AudioSource[] audioSources;

    private void Start()
    {
        audioSources = GetComponents<AudioSource>();
    }

    public void PlayBass()
    {
        audioSources[0].clip = bassClip;
        audioSources[0].Play();
    }

    public void PlaySynth()
    {
        audioSources[1].clip = synthClip;
        audioSources[1].Play();
    }

    public void PlaySnare()
    {
        audioSources[2].clip = snareClip;
        audioSources[2].Play();
    }
}

