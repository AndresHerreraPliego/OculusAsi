using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] Clips;
    public AudioSource ClipSource;

    public void PlayClip(string name){

        Sound s = Array.Find(Clips, x => x.name == name );

        if( s == null ){
            
        }else{
            ClipSource.clip = s.clip;
            ClipSource.Play();
        }

    }
}
