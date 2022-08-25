using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_SCENA : MonoBehaviour
{
    public GameObject camera;
    public GameObject menu;
    
    public void Enabled()
    {
        menu = GameObject.Find("Menu_Scenas");
        menu.SetActive(true);
    }

    
    public void Disabled()
    {
        menu = GameObject.Find("Menu_Scenas");
        menu.SetActive(false);
    }
}
