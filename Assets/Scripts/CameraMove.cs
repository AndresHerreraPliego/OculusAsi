using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
	public GameObject target;
	public GameObject Cam;
	private Vector3 xy;        // Variables to warp camera by code
	private Vector3 giroY;

	public Animator ScreenFade;
	public GameObject[] ObjectsToFadeIn;
	public Animator Acosador;
	public Animator Sofia;

	//public Animator CamaraWarp; variable to warp camera by animation

	public void MoveCamera()
	{
		//Warp Camera by code
		xy.x = target.transform.position.x;
		xy.y = target.transform.position.y;
		xy.z = target.transform.position.z;
		giroY.x = target.transform.eulerAngles.x;
		giroY.y = target.transform.eulerAngles.y;
		giroY.z = target.transform.eulerAngles.z;
							
		Cam.transform.position = xy;
		Cam.transform.eulerAngles=giroY;

		//Warp Camera by animation
		//CamaraWarp.SetTrigger ("Warp");
	}

	public void ChangeCameraAndObjects()
	{
		ScreenFade.SetTrigger ("FadeIn");
		foreach (var GameObject in ObjectsToFadeIn) 
		{
			GameObject.SetActive (true);
		}

		Acosador.SetTrigger ("Entra");
		Sofia.SetTrigger ("Entra");
	}
}
