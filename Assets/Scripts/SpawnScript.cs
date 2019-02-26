using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public GameObject enemy;

	public float spawnTime = 2.0f;

	Renderer rd;

	Vector2 spawnPoint;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("addEnemy", 0, spawnTime);
	}

	void addEnemy() {
		rd = GetComponent<Renderer> ();

		// Position of the left edge of the spawn object
		// It's: (position of the center) minus (half the width)
		var x1 = transform.position.x - rd.bounds.size.x/3;

		// Same for the right edge
		var x2 = transform.position.x + rd.bounds.size.x/3;

		// Randomly pick a point within the spawn object
		spawnPoint = new Vector2(Random.Range(x1, x2), transform.position.y);

		// Create an enemy at the 'spawnPoint' position
		Instantiate(enemy, spawnPoint, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
