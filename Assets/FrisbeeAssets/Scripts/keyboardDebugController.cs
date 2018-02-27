using UnityEngine;
using System.Collections;

public class keyboardDebugController : MonoBehaviour
{
    private GameObject frisbee;
    public float moveSpeed = 3f;
    private Rigidbody rb_frisbee;
   
    // Use this for initialization
    void Start()
    {
        frisbee = GameObject.Find("DebugFrisbee");
        rb_frisbee = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right"))
        {
            frisbee.transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0), Space.World);
        }
        if (Input.GetKey("left"))
        {
            frisbee.transform.Translate(new Vector3(-moveSpeed * Time.deltaTime, 0, 0), Space.World);
        }
        if (Input.GetKey("z"))
        {
            frisbee.transform.Translate(new Vector3(0, moveSpeed * Time.deltaTime, 0), Space.World);
        }
        if (Input.GetKey("x"))
        {
            frisbee.transform.Translate(new Vector3(0, -moveSpeed * Time.deltaTime, 0), Space.World);
        }
        if (Input.GetKey("down"))
        {
            frisbee.transform.Translate(new Vector3(0, 0, -moveSpeed * Time.deltaTime), Space.World);
        }
        if (Input.GetKey("up"))
        {
            frisbee.transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime), Space.World);
        }

        /* Attempt at more refined movement, does not work
         * 
         *  
        
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
      

        Vector3 movement = new Vector3(moveX, 0.0f, moveZ);
        rb_frisbee.AddForce(movement * speed);

        if (Input.GetKey("z"))
        {
            rb_frisbee.transform.position.y += 0.5 * Time.deltaTime;
        }
        if (Input.GetKey("x"))
        {
            rb_frisbee.transform.position.y -= 0.5 * Time.deltaTime;
        }
        */
    }   
}
