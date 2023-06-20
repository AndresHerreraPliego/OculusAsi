using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public Animator Anim;

    public void FadeOut()
    {
        Anim.Play("FadeOut");
    }
}
