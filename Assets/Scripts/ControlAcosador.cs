using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAcosador : MonoBehaviour {

	public Animator Acosador;

	public void AcosadorAPuerta()
	{
		Acosador.SetTrigger ("Puerta");
	}
}
