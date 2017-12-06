using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ColoreGM : MonoBehaviour {

	public static ColoreGM instance;
	public GameObject restartButton;
	public GameObject gameOverText;
	public bool gameOver = false;
	public int Score = 0;
	public GameObject quitButton;

	void Awake ()
	{
		if (instance != this) {
			Destroy (instance);
		}

		if (instance == null) {
			instance = this;
		}
	}

	// Update is called once per frame
	void Update () {
		
		if (gameOver == true) {
			restartButton.SetActive (true);
			quitButton.gameObject.SetActive (true);
		}

	}

	public void BallDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
