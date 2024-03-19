using UnityEngine;

public class PlatformAudioManager : MonoBehaviour
{
    public AudioSource drum1Source;
    public AudioSource drum2Source;
    public AudioSource drum3Source;

    private void Start()
    {
        // Stelle sicher, dass die Audioquellen initialisiert wurden
        if (drum1Source == null || drum2Source == null || drum3Source == null)
        {
            Debug.LogError("One or more audio sources are not assigned!");
        }
    }

    public void PlayBass()
    {
        if (drum1Source != null)
        {
            drum1Source.Play();
        }
        else
        {
            Debug.LogError("Bass audio source is not assigned!");
        }
    }

    public void PlaySynth()
    {
        if (drum2Source != null)
        {
            drum2Source.Play();
        }
        else
        {
            Debug.LogError("Synth audio source is not assigned!");
        }
    }

    public void PlaySnare()
    {
        if (drum3Source != null)
        {
            drum3Source.Play();
        }
        else
        {
            Debug.LogError("Snare audio source is not assigned!");
        }
    }
}


