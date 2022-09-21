using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Parasite : MonoBehaviour
{
    public Transform playerz;
    NavMeshAgent agent;
    

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    private void Update()
    {
       
        agent.SetDestination(playerz.position);
    }
}
