using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;


public class OnCollisionAudio : MonoBehaviour
{

    public Sound[] Clips;
    public AudioSource ClipSource;

    void OnCollisionEnter(Collision collision)
    {
        string name = "recoger";

        Sound s = Array.Find(Clips, x => x.name == name );
        if( s == null ){
            
        }else{
            ClipSource.clip = s.clip;
            ClipSource.Play();
        }

    }
}
