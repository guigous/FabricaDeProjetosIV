using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public float tempoSpawn;
    public Transform[] pontosSpawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Parede"))
        {
            InvokeRepeating("Spawn", tempoSpawn, tempoSpawn);


            print("colidiu");
        }
    }
    
}
