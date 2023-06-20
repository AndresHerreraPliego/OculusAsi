using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MenuManager : MonoBehaviour
{
    public GameObject[] Menus;

    public void Enabled(string name)
    {
        GameObject menu = Array.Find(Menus, x => x.name == name );
        if( menu == null ){
            
        }else{
            menu.SetActive (true);
        }
    }

}
