using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatterScript : MonoBehaviour {

	public int speed = -3;
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "laser(Clone)")
		{
			Destroy (col.gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
		rb2d.velocity = new Vector2(0.0f, speed);
	}

	void OnBecameInvisible() {
		Destroy (gameObject);
	}

}
