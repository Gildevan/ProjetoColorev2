using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float playerVelocity = 10f;
	public bool onGround = true;
	private int allJumps = 2;
	public float jumpForce = 8;


	// Update is called once per frame
	void Start()
	{
		rb = GetComponent <Rigidbody> ();
	}


	void FixedUpdate () {
    //se não tem rigidebody, usar o update
	//se tiver fisica, usar o fixeupdate
	//usar o deltaTime para fazer o moviento ser em metros/segundo

		if (onGround == true) {
			allJumps = 2;
		}

		//jumping and double jumping

		if((Input.GetKeyDown(KeyCode.Space)) && (allJumps >= 1)){
			allJumps--;
			Vector3 vectJump = new Vector3 (0, jumpForce, 0) * playerVelocity;
			rb.AddForce (vectJump);
		
		}

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");


		Vector3 moviment = new Vector3 (moveHorizontal, 0, moveVertical) * playerVelocity;
		rb.AddForce (moviment);
	}

	private bool destroy = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
		}
	}


	//no chão

	void OnCollisionEnter(Collision other){ 						
		onGround = true;
	}
			
	//fora do chão

	void OnCollisionExit(Collision other){ 							
		onGround = false;
	}



}
