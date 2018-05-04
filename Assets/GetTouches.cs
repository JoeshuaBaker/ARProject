using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetTouches : MonoBehaviour {

	public GameObject stylusContainer;
	public GameObject stylusPrefab;
	public GameObject camera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Touch myTouch = Input.GetTouch (0);
		switch (myTouch.phase) {
		case TouchPhase.Began:
			stylusPrefab.transform.position = camera.transform.position + (camera.transform.forward * stylusPrefab.GetComponent<TraceForward>().distance);
			GameObject newStylus = Instantiate (stylusPrefab, stylusContainer.transform);
			newStylus.GetComponent<TraceForward> ().setCamera (camera);
			stylusContainer.GetComponent<ActiveStylus>().setActive(newStylus);
			break;

		case TouchPhase.Ended:
		case TouchPhase.Canceled:
			stylusContainer.GetComponent<ActiveStylus> ().removeActive ();
			break;

		}
	}
}
