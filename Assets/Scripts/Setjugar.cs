using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setjugar : MonoBehaviour {

	public Animator[] SetAnimaciones;
	public GameObject MenuOpciones;

	public void SetAnim()
	{
		foreach (var Animator in SetAnimaciones) 
		{
			Animator.SetTrigger ("Set"); 
		}
	}

	public void SetAnimOut()
	{
		foreach (var Animator in SetAnimaciones) 
		{
			Animator.SetTrigger ("Set3");  //Siempre llamar Set3 a la posición fuera de camara y del escenario.
		}
	}
	public void SetAnim2()
	{
		foreach (var Animator in SetAnimaciones) 
		{
			Animator.SetTrigger ("Set2");  
		}
		MenuOpciones.SetActive (true);

	}

}
