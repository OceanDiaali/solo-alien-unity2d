using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip laserFireSound, matterHitSound;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {
		laserFireSound = Resources.Load<AudioClip> ("lazerzap");
		matterHitSound = Resources.Load<AudioClip> ("matterHit");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound(string clip) {
		switch (clip) {
		case "lazerzap":
			audioSrc.PlayOneShot (laserFireSound);
			break;
		case "matterHit":
			audioSrc.PlayOneShot (matterHitSound);
			break;
		}
	}
}
