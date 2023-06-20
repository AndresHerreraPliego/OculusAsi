using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialManager : MonoBehaviour
{
    public GameObject Pablo;
    public Material RopaPablo;

    public GameObject Sofia;
    public Material RopaSofia;

    
    void ChangeMaterial(string personaje)
    {

        if( personaje == "pablo"){
            Renderer renderer = Pablo.GetComponent<Renderer>();
            renderer.material = RopaPablo;
        }else{
            Renderer renderer = Sofia.GetComponent<Renderer>();
            renderer.material = RopaSofia;
        }
        
    }

  
}
