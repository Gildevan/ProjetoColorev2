using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour {

	public void Restart(){

		SceneManager.LoadScene (1);
	}

	public void QuitGame(){

		SceneManager.LoadScene (0);
	}
}
