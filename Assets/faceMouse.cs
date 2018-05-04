using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faceMouse : MonoBehaviour {
	private float cameraDif;
	private Vector3 worldPos;

	// Use this for initialization
	void Start () {
		cameraDif = Camera.main.transform.position.y - this.transform.position.y;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate()
	{
		lookAtMouse ();
	}

	void lookAtMouse()
	{
		float mouseX = Input.mousePosition.x;
		float mouseY = Input.mousePosition.y; 
		worldPos = Camera.main.ScreenToWorldPoint (new Vector3 (mouseX, mouseY, cameraDif));

		Vector3 lookDirection = new Vector3 (worldPos.x, this.transform.position.y, worldPos.z);
		this.transform.LookAt (lookDirection);
	}
}
