using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour {

	public Transform player;
	public Vector3 position;


	void Update(){
		transform.position = player.position + position;
	}

}
