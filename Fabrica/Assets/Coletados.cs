using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class Coletados : MonoBehaviour
{
    private int sludgies_coletatos = 0;

    public TextMeshProUGUI ScoreTXT;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponentInParent<SlimeJump>().enabled = false;
           
            AddPoints();
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponentInParent<SlimeJump>().enabled = true;
            RemovePoints();
        }
    }


    void RemovePoints()
    {
        sludgies_coletatos--;
        ScoreTXT.text = sludgies_coletatos.ToString();
        Debug.Log("REMOVEPOINTS");
    }
    void AddPoints()
    {
        sludgies_coletatos++;
        ScoreTXT.text = sludgies_coletatos.ToString();
        Debug.Log("ADDPOINTS");
    }
    private void Update()
    {
        if (sludgies_coletatos >= 4)
        {
            SceneManager.LoadScene("Final");
        }
    }
}
