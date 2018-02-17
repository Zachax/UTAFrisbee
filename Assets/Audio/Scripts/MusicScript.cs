/* This class plays and changes background music.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {

	public AudioClip musicClip1;
	public AudioClip musicClip2;

	public AudioSource musicSource;

	// Use this for initialization
	void Start () {
		musicSource.clip = musicClip1;
	}
	
	// If key M is pressed, music track is changed, or turned off if the last track.
	void Update () {
		if (Input.GetKeyDown (KeyCode.M)) {
			if (musicSource.clip == null) {
				musicSource.clip = musicClip1;
				musicSource.Play ();
			} else if (musicSource.clip == musicClip1) {
				musicSource.clip = musicClip2;
				musicSource.Play ();
			} else {
				musicSource.Stop ();
				musicSource.clip = null;
			}
		}
	}
}
