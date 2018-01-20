using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	// GameObjects and variables to used
	public float jumpForce;
	public Rigidbody2D rb;
	public float forwardSpeed;
	public GameObject cam;
	public bool dead;

	// Use this for initialization
	void Start () {	
		// Force used to jump
		jumpForce = 300f;

		// Getting the character
		rb = GetComponent<Rigidbody2D> ();
		// Freezing character rotation
		rb.freezeRotation = true;

		// Level speed
		forwardSpeed = 2f;

		// Starts alive
		dead = false;
	}
	
	// Update is called once per frame
	void Update () {
		// Verify player is alive
		if (dead.Equals (false)) {
			// Horizontal movement
			rb.transform.Translate (new Vector3 (1, 0, 0) * forwardSpeed * Time.deltaTime);

			// Camera follows character
			cam.transform.Translate (new Vector3 (1, 0, 0) * forwardSpeed * Time.deltaTime);

			// Jump by pressing the space bar
			if (Input.GetButtonDown ("Jump")) {
				rb.velocity = Vector2.zero;
				rb.AddForce (Vector2.up * jumpForce);
			}
		}

		// Dead at the end of the level
		if (rb.position.x >= 42.5) {
			dead = true;
		}

	}

	// Defeat & collision function
	private void OnCollisionEnter2D(Collision2D collision){
		// If player collide with a coin
		if (collision.gameObject.tag == "coin") {
			Destroy (collision.gameObject);
		} else { // Player collide with other object
			dead = true;
		}
	}
		

}
