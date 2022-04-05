using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosSofia1 : MonoBehaviour {

	public Texture[] texturesSofia;
	public int currentTextureSofia;
	public GameObject falda;
	Renderer textureRendererSofia;
	public Animator ScreenFade;
	public GameObject[] ObjectsToFade;

	public void changeTexture(int texturaSofia)
	{
		GameObject sofia = GameObject.Find ("SofiaCuerpo");
		textureRendererSofia = sofia.GetComponent<SkinnedMeshRenderer>();
		textureRendererSofia.material.mainTexture = texturesSofia[texturaSofia];
		if (texturaSofia == 1) {
			falda.SetActive(false);
		} else {
			falda.SetActive(true);
		}
	}
		
	public void ChangeCameraAndObjects()
	{
		ScreenFade.SetTrigger ("FadeOut");
		foreach (var GameObject in ObjectsToFade) 
		{
			GameObject.SetActive (false);
		}
	}
		
}
