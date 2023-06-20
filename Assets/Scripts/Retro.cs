using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retro : MonoBehaviour
{
    public AudioClip[] audioClips;
    public GameObject[] msg;
    public GameObject sc;
    public AudioSource audioSource;
    public delegate void AudioSequenceFinished();
    public event AudioSequenceFinished OnAudioSequenceFinished;
    private int currentClipIndex = 0;

    void Start () {
		PlayNextClip();
        sc.SetActive(false);
	}

    void PlayNextClip()
    {

        if (currentClipIndex < audioClips.Length)
        {
            if(currentClipIndex > 0){
                 msg[currentClipIndex - 1].SetActive(false);
            }
           
            msg[currentClipIndex].SetActive(true);
            audioSource.clip = audioClips[currentClipIndex];
            audioSource.Play();
            currentClipIndex++;
            Invoke("PlayNextClip", audioSource.clip.length);
        }
        else
        {
            if (OnAudioSequenceFinished != null)
                OnAudioSequenceFinished();
            SceneManager.LoadScene (8);
        }
    }
}

