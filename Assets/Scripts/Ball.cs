using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
public float launchSpeed;
private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.velocity = new Vector3 (0,0, launchSpeed);

	}
	
	// Update is called once per frame
	void Update () {
	/*if(Input.GetKeyDown("Fire1")){

		}*/
	}
}