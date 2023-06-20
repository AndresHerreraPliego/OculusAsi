using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] Menus;

    public void EnabledObject(string name)
    {
        GameObject menu = Array.Find(Menus, x => x.name == name );
        if( menu == null ){
            
        }else{
            menu.SetActive (true);
        }
    }

    public void DisabledObject(string name)
    {
        GameObject menu = Array.Find(Menus, x => x.name == name );
        if( menu == null ){
            
        }else{
            menu.SetActive (false);
        }
    }
}
