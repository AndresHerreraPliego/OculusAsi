using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaFinal : MonoBehaviour {

	public GameObject ShowUI;
	public GameObject confettiFX;

	public void Confetti()
	{
		ShowUI.SetActive (true);
		GameObject ob = Instantiate (confettiFX);
		Destroy (ob,10.0f);
	}
}
