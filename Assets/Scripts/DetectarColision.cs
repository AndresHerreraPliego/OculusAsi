using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour
{
    public GameObject menu;
    public Animator anim;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {

        switch (collision.gameObject.name) 
        {
            case "btn_car":
                anim.SetTrigger("JC");
                break;
            case "btn_te":
                anim.SetTrigger("JT");
                break;

            case "btn_mun":
                anim.SetTrigger("JM");
                break;
        }
        menu.SetActive (false);
    }
}
