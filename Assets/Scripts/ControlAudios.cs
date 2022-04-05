using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAudios : MonoBehaviour {

	public AudioSource Dialogo;
	public AudioClip[] DialogoClips;
	int audioanterior=7; //El valor de 7 es arbitrario es diferente al primer valor esperado en LlamarDialogo

	void Start () {
		Dialogo = GetComponent<AudioSource> ();
	} 
		
	public void LlamarDialogo(int dialogonum)
	{
		Dialogo.clip = DialogoClips [dialogonum];
		Debug.Log("" + dialogonum + " - " + dialogonum); //Mensaje de seguimiento en la consola

	
		if ((Dialogo.isPlaying == false)&&(dialogonum!=audioanterior))
		{
			Dialogo.Play();
			audioanterior = dialogonum;
		}
	}

}
 