using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Enemies")) {
			ColoreGM.instance.DecreaseHealth();
		}
		if (ColoreGM.instance.healthPoints == 0) {
			player.gameObject.SetActive (true);
			ColoreGM.instance.BallDied ();
		}

	}
}
