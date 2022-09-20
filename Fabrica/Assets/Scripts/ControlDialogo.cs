using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.AI;

public class ControlDialogo : MonoBehaviour
{
    public static ControlDialogo singleton;
    public static bool enDialogo = false;


    public GameObject dialogo;
    public TMP_Text txtdialogo;
    [Header("Config de teclado")]
    [Header("Ensyaos")]
    public Animator animator;
    NavMeshAgent agent;

    public ConfigDialogos configura;

    public Frase[] Dialogoensa;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
        }
        else
        {
            DestroyImmediate(gameObject);
        }
    }

    private void Start()
    {
        dialogo.SetActive(false);

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    public IEnumerator conversar(Frase[] _dialogo)
    {
        dialogo.SetActive(true);
        animator.SetBool("Falar", true);
        enDialogo = true;
        for (int i = 0; i < _dialogo.Length; i++)
        {
            txtdialogo.text = ""; 
            for (int j = 0; j < _dialogo[i].texto.Length + 1; j++)
            {
                if (Input.GetKey(configura.teclaSkip))
                {
                    j = _dialogo[i].texto.Length;
                }
                txtdialogo.text = _dialogo[i].texto.Substring(0, j);
                yield return new WaitForSeconds(configura.tempoLetra);
            }
            txtdialogo.text = _dialogo[i].texto;
            yield return new WaitForSeconds(0.5f);
            yield return new WaitUntil(() => Input.GetKeyDown(configura.TeclaSeguinteFrase));
        }
        dialogo.SetActive(false);
        animator.SetBool("Falar", false);
        enDialogo = false;
    }
    [ContextMenu("Ativar")]

    public void fala()
    {
        StartCoroutine (conversar(Dialogoensa));
    }
}
[System.Serializable]

public class Frase
{
    public string texto;

}

[System.Serializable]

public class EstadoDialogo
{
    public Frase[] frases;
}