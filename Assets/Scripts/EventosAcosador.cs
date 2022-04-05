using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosAcosador : MonoBehaviour {
	
	public Animator[] SofiaToSet2;
	public Animator[] AcosadorToSet1;
	public GameObject[] Menus;
	public Animator CameraMove;

	public void ShowUI(int menu)
	{
		Menus [menu].SetActive (true);
	}

	public void TriggerAnim()
	{
		foreach (var Animator in SofiaToSet2) 
		{
			Animator.SetTrigger ("MirarUser"); 
		}
	}

	public void SetAnimAcosador()
	{
		foreach (var Animator in AcosadorToSet1) 
		{
			Animator.SetTrigger ("Set1"); 
		}
	}

	/*public void AnimarCamara()
	{
		CameraMove.SetTrigger ("Move");
	}*/

	public void ZoomCamera()
	{
		CameraMove.SetTrigger ("Zoom");
	}
}
