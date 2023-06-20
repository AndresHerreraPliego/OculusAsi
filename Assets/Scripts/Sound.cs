using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound  {
    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume = 1f;

}