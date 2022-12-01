using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bocóFollow : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;

    void Update()
    {
        enemy.SetDestination(player.position);
    }
}
