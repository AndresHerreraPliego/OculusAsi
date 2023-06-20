using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour {

	public void PlayScene (int num) 
	{
		SceneManager.LoadScene (num);
	}

	
	public void QuitGame ()
	{
		Application.Quit ();
	}

}