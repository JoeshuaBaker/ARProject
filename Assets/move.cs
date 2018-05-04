using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	private Rigidbody rb;
	public float speed = 5;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 force = new Vector3 ();

		if (Input.GetKey (KeyCode.W)) {
			force += new Vector3 (0, 0, speed);
		}
		if (Input.GetKey (KeyCode.S)) {
			force += new Vector3 (0, 0, -speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			force += new Vector3 (-speed, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			force += new Vector3 (speed, 0, 0);
		}

		rb.AddForce (force);

	}
}
