using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ColoreGM : MonoBehaviour {

	public static ColoreGM instance;
	public GameObject restartButton;
	public GameObject gameOverText;
	public GameObject quitButton;
	public bool gameOver = false;
	public int Score = 0;

	void Awake(){
		if (instance == null) {
			instance = this;

		}

		else if (instance != null) 
		{

			Destroy (gameObject);
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
		if (gameOver == true) {
			restartButton.SetActive (true);
			quitButton.SetActive (true);
		}

	}

	public void BallDied(){
		
		gameOverText.SetActive (true);
		gameOver = true;
	}
}
