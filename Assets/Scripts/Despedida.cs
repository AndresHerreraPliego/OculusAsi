using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Despedida : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public delegate void AudioSequenceFinished();
    public event AudioSequenceFinished OnAudioSequenceFinished;
    private int currentClipIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        PlayNextClip();
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
            SceneManager.LoadScene (0);
            
        }
    }

 
}