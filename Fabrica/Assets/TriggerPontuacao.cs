using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TriggerPontuacao : MonoBehaviour
{
    public GameObject pontuacao;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            Debug.Log(pontuacao.gameObject.name);
            
            
        }
    }




    void Start()
    {
        
       pontuacao = GameObject.Find("Pontuacao");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
