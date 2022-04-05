using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventosanimacion : MonoBehaviour {

	public Texture[] textures;
	public int currentTexture;
	Renderer textureRenderer;

	public void changeTexture(int textura)
	{
		GameObject pablo = GameObject.Find ("PabloCuerpo");
		textureRenderer = pablo.GetComponent<SkinnedMeshRenderer>();
		textureRenderer.material.mainTexture = textures[textura];
	}

	public void AudioEscena1()
	{
		AudioSource audioE1;

		audioE1 = GetComponent<AudioSource> ();
		audioE1.Play (0);
	}
}
