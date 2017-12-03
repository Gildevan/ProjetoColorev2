using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {


	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")) {
			other.gameObject.SetActive (false);
		}
	
	}
}
