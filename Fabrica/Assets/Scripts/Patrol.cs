using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public List<Point> lstPoints;
    NavMeshAgent agent;
    Animator animator;

    int indexSorteado = 0;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        agent.SetDestination(lstPoints[indexSorteado].transform.position);

        for (int x = 0; x < lstPoints.Count; x++)
        {
            lstPoints[x].index = x;
        }
    }

    private void Update()
    {
       //nimator.SetFloat("Speed", agent.velocity.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Point"))
        {
            while (other.GetComponent<Point>().index == indexSorteado)
            {
                indexSorteado++;
                if (indexSorteado >= lstPoints.Count)
                {
                    indexSorteado = 0;
                }
            }
            agent.SetDestination(lstPoints[indexSorteado].transform.position);
        }
    }
}
