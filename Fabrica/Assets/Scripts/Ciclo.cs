using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Ciclo : MonoBehaviour
{
    [SerializeField] private Transform luzDirecional;
    [SerializeField]
    [Tooltip("Duração do Dia em Segundos")]
    private int duracaoDoDia;
    [SerializeField] private TextMeshProUGUI horarioText;


    private float segundos;
    private float multiplacador;

    private void Start()
    {
        multiplacador = 86400 / duracaoDoDia;
    }

    private void Update()
    {
        segundos += Time.deltaTime * multiplacador;

        if(segundos >= 86400)
        {
            segundos = 0;
        }

        ProcessarCeu();
        CalcularHorario();
    }

    private void ProcessarCeu()
    {
        float rotacaoX = Mathf.Lerp(-90, 270, segundos / 86400);
        luzDirecional.rotation = Quaternion.Euler(rotacaoX, 0, 0);
    }

    private void CalcularHorario()
    {
        horarioText.text = TimeSpan.FromSeconds(segundos).ToString(@"hh\:mm");
    }
}
