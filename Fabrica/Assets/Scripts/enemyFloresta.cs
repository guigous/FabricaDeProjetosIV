using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFloresta : MonoBehaviour
{
    public GameObject enemy;
    public float tempoSpawn;
    public Transform[] pontosSpawn;

  
    public void Spawn()
    {
        int PontosSpawnIndex = Random.Range(0, pontosSpawn.Length);
        Instantiate(enemy, pontosSpawn[PontosSpawnIndex].position, pontosSpawn[PontosSpawnIndex].rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Parede"))
        {
            Destroy(gameObject);

            print("colidiu");
        }
    }
}
