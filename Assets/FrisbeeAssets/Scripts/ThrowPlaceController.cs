using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ThrowPlaceController : MonoBehaviour {
    public GameObject goal;
    public GameObject frisbee;
    NavMeshAgent place;

    void Start()
    {
        place = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        place.transform.LookAt(goal.transform);
    }

    public void MoveThrowPlace()
    {
        place.destination = frisbee.transform.position;
        // Give the new position to ThrowController class
        ThrowController.throwStartPos = place.destination;

    }

    public void ResetThrowPlace()
    {
        place.destination = new Vector3(0, 0, 0);
        frisbee.transform.position = new Vector3(0, 1, 0);
    }

}
