using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
    private List<AudioSource> activeAudioSources = new List<AudioSource>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            AudioSource curAudioSource = other.GetComponent<AudioSource>();

            if(curAudioSource != null && activeAudioSources.Contains(curAudioSource))
            {
                activeAudioSources.Add(curAudioSource);

                curAudioSource.volume = 1;
                DontDestroyOnLoad(curAudioSource.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Platform"))
        {
            AudioSource curAudioSource = other.GetComponent<AudioSource>();

            if (curAudioSource != null && activeAudioSources.Contains(curAudioSource))
            {
                activeAudioSources.Add(curAudioSource);

                curAudioSource.volume = 0;
                DontDestroyOnLoad(curAudioSource.gameObject);
            }
        }
    }


}
 



