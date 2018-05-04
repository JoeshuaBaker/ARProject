using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceForward : MonoBehaviour {

	public GameObject camera;
	private bool enabled = true;
	public float distance = 3.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
		if (enabled) {
			this.transform.position = camera.transform.position + (camera.transform.forward * distance);
		}

	}

	public void setCamera(GameObject _camera)
	{
		camera = _camera;
	}

	public void disable()
	{
		enabled = false;
	}
}
