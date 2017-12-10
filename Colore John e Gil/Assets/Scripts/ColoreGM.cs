using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ColoreGM : MonoBehaviour {

	public static ColoreGM instance;
	public GameObject player;
	public GameObject restartButton;

	public GameObject gameOverText;
	public bool gameOver = false;

	public GameObject quitButton;
	public Text scoreText;
	public int points = 0;
	private int goldenPoints = 0;
	public GameObject gameOverImage;

	private TransparenceDinamic transDynamicscript;
	private Transparence transScript;


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
			gameOverImage.SetActive (true);
		}

	}

	public void BallDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	
	}

	public void BallScored(){
			points = points + 10;
		scoreText.text = "Score: " +  points.ToString ();
		}

	public void GoldenPoints(){
		goldenPoints = goldenPoints + 20;
		scoreText.text = "Score: " + goldenPoints.ToString ();
	}
}