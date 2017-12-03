using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {
	public Camera[] cameras;
	public int numeroCameras;
	public int NumeroMaximo;

	// Use this for initialization
	void Start () {
		
		NumeroMaximo = cameras.Length;
		numeroCameras = 1;
		foreach (Camera obj in cameras) {
			obj.gameObject.SetActive (false);
		}
		cameras [numeroCameras - 1].gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C) && numeroCameras < NumeroMaximo) {
			foreach (Camera obj in cameras) {
				obj.gameObject.SetActive (false);
			}

			cameras [numeroCameras - 1].gameObject.SetActive (true);
		}
	}
}
