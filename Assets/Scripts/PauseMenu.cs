using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public static bool EstaEnPausa = false;
	public GameObject PauseMenuUI;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (EstaEnPausa) 
			{
				Continuar ();
			}
			else
			{
				Pausar ();
			}
		}
	}

	public void Continuar ()
	{
		PauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		EstaEnPausa = false;
		AudioListener.pause = false;
	}

	public void Pausar()
	{
		PauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		EstaEnPausa = true;
		AudioListener.pause = true;

	}

	public void RegresarInicio()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}

	public void Salir()
	{
		Application.Quit ();
	}

}
