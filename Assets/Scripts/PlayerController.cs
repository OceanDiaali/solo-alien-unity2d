using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public GameObject laserRing;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Vector2 position = this.transform.position;
			position.x--;
			this.transform.position = position;
		} else if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Vector2 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			SoundManagerScript.PlaySound ("lazerzap");
			Instantiate (laserRing, transform.position, Quaternion.identity);
		}
	}


}
