using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour {

	public Animator Door;

	public void openDoor()
	{
		Door.SetTrigger ("Abrir");
	}

	public void closeDoor()
	{
		Door.SetTrigger ("Cerrar");
	}
		
}
