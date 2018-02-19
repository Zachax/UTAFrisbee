using UnityEngine;
using System.Collections;

/* Frisbee interactions with other objects. Main purpose is to determine if a throw hit
 * the target.
 * 
 * 
 * 
 */

public class CollisionHandler : MonoBehaviour {

<<<<<<< HEAD
	//public SfxPlayer frisbeeSounds;

    // Checks for collision event (ie. hitting something)
    void OnCollisionEnter(Collision collisionDetails) {
       // Debug.Log("Frisbee hit something" + collisionDetails.collider);

=======
    // Checks for collision event (ie. hitting something)
    //collisionDetails = the target that was hit by this object ?
    void OnCollisionEnter(Collision collisionDetails) {
      
        //Debug.Log("Frisbee hit something" + collisionDetails.collider);
       
>>>>>>> 14cdf650a254524869a0c1368739d74d0246d762
        if (collisionDetails.gameObject.name == "Target")
        {
            Destroy(collisionDetails.gameObject);
            print("HIT!");
<<<<<<< HEAD
			// Plays a sound on impact
			FindObjectOfType<SfxPlayer>().PlayHit ();
        }
    

    }
    

=======
        }        
        
        //Activates when the frisbee is in the goal basket
        if (collisionDetails.gameObject.name == "Goal_HitBox_InsideBasketCheck")
        {
            Debug.Log("Frisbee in basket!");
        }

        //Could also play a simple animation and/or metallic sound here by using
        //Goal_Hitbox_MetalChains as the activator;
        if (collisionDetails.gameObject.name == "Goal_Hitbox_MetalChains")
        {
            Debug.Log("Metallic cling!!");
        }

        
    }
>>>>>>> 14cdf650a254524869a0c1368739d74d0246d762
}
