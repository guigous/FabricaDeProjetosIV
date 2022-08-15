using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogodor : MonoBehaviour
{
    public int estadoActual = 0;
    public EstadoDialogo[] estados;

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(ControlDialogo.singleton.TeclaInicioDialogo))
            {
                StartCoroutine(ControlDialogo.singleton.conversar(estados[estadoActual].frases));
            }
        }
    }
}
