using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CameraManager : MonoBehaviour {

	public GameObject Target;
	public GameObject[] Cameras;
	private Vector3 xy;       
	private Vector3 giroY;


	public void MoveCamera(string name)
	{
        GameObject camera = Array.Find(Cameras, x => x.name == name );

        if( camera == null ){
            
        }else{
			xy.x = camera.transform.position.x;
			xy.y = camera.transform.position.y;
			xy.z = camera.transform.position.z;
			giroY.x = camera.transform.eulerAngles.x;
			giroY.y = camera.transform.eulerAngles.y;
			giroY.z = camera.transform.eulerAngles.z;
								
			Target.transform.position = xy;
			Target.transform.eulerAngles=giroY;
        }

	}

}
