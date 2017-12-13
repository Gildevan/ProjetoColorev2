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
	public GameObject gameOverImage;
	public Text totalScoreText;


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

	void Start(){
		
	}



	void Update () {


	}

	public void BallDied(){
		
			restartButton.SetActive (true);
			quitButton.gameObject.SetActive (true);
			gameOverImage.SetActive (true);
		totalScoreText.enabled = true;
		scoreText.enabled = false;


		gameOverText.SetActive (true);
		gameOver = true;
	
	}

	public void BallScored(){
			points = points + 10;
		totalScoreText.text = "Total Score: " + points.ToString();
		scoreText.text = "Score: " +  points.ToString ();
		}
		
	public void DecreaseHealth(){
	}
}
