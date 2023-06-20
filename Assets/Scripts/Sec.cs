using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sec : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public delegate void AudioSequenceFinished();
    public event AudioSequenceFinished OnAudioSequenceFinished;
    private int currentClipIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(MyDelayFunction());
    }

    
        void PlayNextClip()
    {

        if (currentClipIndex < audioClips.Length)
        {
            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();
            currentClipIndex++;
            Invoke("PlayNextClip", audioSource.clip.length);
        }
        else
        {
            if (OnAudioSequenceFinished != null)
                OnAudioSequenceFinished();
            
        }
    }

    IEnumerator MyDelayFunction() {
        Debug.Log("Inicio de la función");
        yield return new WaitForSeconds(3);
        Debug.Log("Pasaron 2 segundos");
        PlayNextClip();
    }
}
