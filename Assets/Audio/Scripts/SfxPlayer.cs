/* This class plays sound effects when called.
 * 
 * When you want to add a sound effect, add the following line to the triggering event script
 * (with "SoundNameHere" changed to name of the Sound object):
   FindObjectOfType<SfxPlayer>().Play("SoundNameHere");
 */

using UnityEngine.Audio;
using UnityEngine;
using System;

public class SfxPlayer : MonoBehaviour {

	public Sound[] sounds;

	public static SfxPlayer instance;

	// Scrolls through the list of sounds when invoken, and sets the sound settings
	void Awake() {
		if (instance == null) {
			instance = this;
		} else {
			Destroy (gameObject);
			return;
		}

		DontDestroyOnLoad (gameObject);

		if (sounds != null) {
			foreach(Sound s in sounds) {
				s.source = gameObject.AddComponent<AudioSource> ();
				s.source.clip = s.clip;

				s.source.volume = s.volume;
				s.source.pitch = s.pitch;
				s.source.loop = s.loop;
				print (s.name);
			}
		}
	}

	// Plays a sound according 
	public void Play(string name) {
		if (sounds != null && name != null) {
			Sound s = Array.Find (sounds, sound => sound.name == name);
			s.source.Play ();

			print ("SfxPlayer plays: " + name + " at volume " + s.volume);
		} else {
			Debug.LogWarning ("Sound '" + name + "' not found!");
		}
	}
}
