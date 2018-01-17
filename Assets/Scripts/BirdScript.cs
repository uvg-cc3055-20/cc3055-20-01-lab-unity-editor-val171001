using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	public float jumpForce;
	public Rigidbody2D rb;
	public float forwardSpeed;
	public GameObject cam;

	// Use this for initialization
	void Start () {	
		jumpForce = 300f;
		rb = GetComponent<Rigidbody2D> ();
		forwardSpeed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
		// Moverse horizontalmente
		rb.transform.Translate(new Vector3(1,0,0) * forwardSpeed * Time.deltaTime);

		// Camara siga al personaje
		cam.transform.Translate(new Vector3(1,0,0) * forwardSpeed * Time.deltaTime);

		// Saltar al presionar la barra espaciadora
		if(Input.GetButtonDown("Jump")){
			rb.velocity = Vector2.zero;
			rb.AddForce (Vector2.up * jumpForce);
		}

	}
}
