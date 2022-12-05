using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{

    public Scene cena;

    private void Update()
    {
        if (other.gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene("Final");
        }
    }
 

}


