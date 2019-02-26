using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour {

	public float currentTime = 0f;
	public float startTime = 30f;

	[SerializeField] Text countdownText;

	// Use this for initialization
	void Start () {
		currentTime = startTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (currentTime > 0) {
			currentTime -= 1 * Time.deltaTime;
			if (currentTime < 10) {
				countdownText.color = Color.red;
			}
			countdownText.text = currentTime.ToString ("0");
		} else {
				countdownText.text = "Time Up!";
		}
			
	}
}
