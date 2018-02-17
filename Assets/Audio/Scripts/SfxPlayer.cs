/* This class plays sound effects when called.
 */

using UnityEngine;

public class SfxPlayer : MonoBehaviour {

	public AudioClip discGo;
	public AudioClip discHit;

	public AudioSource source;

	// Receives audio source from the invoking object
	void Awake() {
		source = gameObject.AddComponent<AudioSource> ();
		if (source != null) {
			source.rolloffMode = AudioRolloffMode.Linear;
			source.spatialBlend = 1f;
			source.maxDistance = 50;
		}
	}

	// Plays frisbee start moving sound
	public void PlayGo() {
		if (source != null) {
			source.clip = discGo;
			source.Play ();
		}
	}

	// Plays frisbee normal hit sound
	public void PlayHit() {
		if (source != null) {
			source.clip = discHit;
			source.Play ();
		}
	}
}
