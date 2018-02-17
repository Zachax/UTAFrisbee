using UnityEngine;
using System.Collections;

/* Frisbee interactions with other objects. Main purpose is to determine if a throw hit
 * the target.
 * 
 * 
 * 
 */

public class CollisionHandler : MonoBehaviour {

	//public SfxPlayer frisbeeSounds;

    // Checks for collision event (ie. hitting something)
    void OnCollisionEnter(Collision collisionDetails) {
       // Debug.Log("Frisbee hit something" + collisionDetails.collider);

        if (collisionDetails.gameObject.name == "Target")
        {
            Destroy(collisionDetails.gameObject);
            print("HIT!");
			// Plays a sound on impact
			FindObjectOfType<SfxPlayer>().PlayHit ();
        }
    

    }
    

}
