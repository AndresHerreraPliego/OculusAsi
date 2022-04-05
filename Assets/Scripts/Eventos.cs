using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventos : MonoBehaviour {
	[SerializeField]
	UnityEvent OnMunecaEvent;

	[SerializeField]
	UnityEvent OnCarEvent;

	[SerializeField]
	UnityEvent OnTeEvent;


	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "MunecaTakeObj") 
		{
			OnMunecaEvent.Invoke();
			Debug.Log("Muneca");
		}

		if (col.gameObject.name == "CarTakeObj") 
		{
			OnCarEvent.Invoke();
			Debug.Log("Car");

		}

		if (col.gameObject.name == "TeTakeObj") 
		{
			OnTeEvent.Invoke();
			Debug.Log("Te");

		}
	}
}
