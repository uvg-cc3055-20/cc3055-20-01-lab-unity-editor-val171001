using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

	public float jumpForce = 10;

	// Use this for initialization
	void Start () {	
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			Debug.Log("Espacio");
		}

	}
}
