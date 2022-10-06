using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public List<GameObject> pointsLst = new List<GameObject>();
    private int destPoint;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent=GetComponent<NavMeshAgent>();
        agent.autoBraking = false;
        GotoNextPoint();
        AddPointstoList();
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
        if (pointsLst.Count == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = pointsLst[destPoint].transform.position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % pointsLst.Count;
    }
    void AddPointstoList()
    {
        for (int i = 0; i < pointsLst.Count; i++)
        {
            pointsLst.Add(GameObject.FindGameObjectWithTag("Point"));
        }
    
    }
}
