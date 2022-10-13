using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public GameObject[] pointsAr;
    private int destPoint;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        GotoNextPoint();
        pointsAr = GameObject.FindGameObjectsWithTag("Point");
    }

    // Update is called once per frame
    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        GotoNextPoint();
        

    }

    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (pointsAr.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = pointsAr[destPoint].transform.position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % pointsAr.Length;
    }
    
}
