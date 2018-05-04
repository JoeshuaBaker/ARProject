using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveStylus : MonoBehaviour {
	private GameObject stylus;
	// Use this for initialization
	private float r = 0.0f;
	private float b = 0.35f;
	private float g = 0.75f;
	public float speed = 0.01f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (stylus != null) {
			TrailRenderer tr = stylus.GetComponent<TrailRenderer> ();
			Color old = tr.colorGradient.colorKeys [0].color;
			tr.colorGradient.SetKeys(new GradientColorKey[] {new GradientColorKey(new Color(r, g, b), 0), new GradientColorKey(new Color(r, g, b), 1) }, new GradientAlphaKey[] { new GradientAlphaKey(1,0), new GradientAlphaKey(1,1)});
		}
	}

	private void doRainbow()
	{
		r += speed;
		if (r >= 1.0f)
			r = 0;
		b += speed;
		if (b >= 1.0f)
			b = 0;
		g += speed;
		if (g >= 1.0f)
			g = 0;

	}

	public void setActive(GameObject newStylus)
	{
		stylus = newStylus;
	}

	public void removeActive()
	{
		TraceForward tf = stylus.GetComponent<TraceForward> ();
		tf.disable ();
		stylus = null;
	}
}
