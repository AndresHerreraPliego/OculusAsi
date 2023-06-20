using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class gameManager : MonoBehaviour {

	public Sprite[] cardFace;
	public Sprite cardBack;
	public GameObject[] cards;
	public GameObject gameTime;

	private bool _init  = false;
	private int _matches = 5;

	public Sound[] Clips;
    public AudioSource ClipSource;


	// Update is called once per frame
	void Update () {
		if (!_init)
			initializeCards ();

		//if (Input.GetMouseButtonUp (0))
		checkCards ();

	}

	void initializeCards() {
		for (int id = 0; id < 2; id++) {
			for (int i = 1; i < 6; i++) {

				bool test = false;
				int choice = 0;
				while (!test) {
					choice = UnityEngine.Random.Range (0, cards.Length);
					test = !(cards [choice].GetComponent<cardScript> ().initialized);
				}
				cards [choice].GetComponent<cardScript> ().cardValue = i;
				cards [choice].GetComponent<cardScript> ().initialized = true;
			}
		}

		foreach (GameObject c in cards)
			c.GetComponent<cardScript> ().setupGraphics ();

		if (!_init)
			_init = true;
	}

	public Sprite getCardBack() {
		return cardBack;
	}

	public Sprite getCardFace(int i) {
		return cardFace[i - 1];
	}

	void checkCards() {
		List<int> c = new List<int> ();

		for (int i = 0; i < cards.Length; i++) {
			if (cards [i].GetComponent<cardScript> ().state == 1)
				c.Add (i);
		}

		if (c.Count == 2)
			cardComparison (c);
	}

	void cardComparison(List<int> c){
		cardScript.DO_NOT = true;

		int x = 0;
		int time = 0;

		if (cards [c [0]].GetComponent<cardScript> ().cardValue == cards [c [1]].GetComponent<cardScript> ().cardValue) {
			

			switch ( cards [c[1]].GetComponent<cardScript>()._cardFace.name) 
			{
				case "atencion":
					PlayClip("ma");
					time = 7;
					break;
				case "discriminacion":
					PlayClip("md");
					time = 4;
					break;
				case "escuela":
					PlayClip("me");
					time = 7;
					break;
				case "familia":
					PlayClip("mf");
					time = 5;
					break;
				case "violencia":
					PlayClip("mv");
					time = 6;
					break;
			}
			
			x = 2;
			_matches--;
			if (_matches == 0){
				StartCoroutine(MyDelayFunction(time));
			}

		}


		for (int i = 0; i < c.Count; i++) {
			cards [c [i]].GetComponent<cardScript> ().state = x;
			cards [c [i]].GetComponent<cardScript> ().falseCheck ();
		}
	
	}

	public void reGame(){
		SceneManager.LoadScene ("gameScene");
	}

	public void reMenu(){
		SceneManager.LoadScene ("menuScene");
	}

	public void PlayClip(string name){
        Sound s = Array.Find(Clips, x => x.name == name );
        if( s == null ){
        }else{
            ClipSource.clip = s.clip;
            ClipSource.Play();
        }
    }

	IEnumerator MyDelayFunction(int time) {
        yield return new WaitForSeconds(time);
        PlayScene();
    }

	public void PlayScene () 
	{
		SceneManager.LoadScene (9);
	}
}
