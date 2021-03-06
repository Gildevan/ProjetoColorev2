﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparenceDinamic : MonoBehaviour {

	private Transparence transparenceDinamicScript;
	private Renderer rendererMaterial = new Renderer();

	// Use this for initialization
	void Start () {
		GameObject transp = GameObject.Find ("Main Camera");
		transparenceDinamicScript = transp.GetComponent<Transparence> ();

		rendererMaterial = gameObject.GetComponent<Renderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int m = 0; m < rendererMaterial.materials.Length; m++) {

			if (transparenceDinamicScript.hitpoint.transform == transform) {
				if (rendererMaterial.materials [m].color.a > 0.5f) {
			
					Color colorMat = rendererMaterial.materials [m].color;
					colorMat.a -= 0.02f;
					rendererMaterial.materials [m].color = colorMat;
				}
			}

			else if (rendererMaterial.materials [m].color.a < 1) {
				Color colorMat = rendererMaterial.materials [m].color;
				colorMat.a += 0.02f;
				rendererMaterial.materials [m].color = colorMat;
			}
		}
	}
}