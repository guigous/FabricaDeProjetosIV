using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu()]
public class ConfigDialogos : ScriptableObject
{
    public float tempoLetra = 0.1f;
    public KeyCode teclaSkip = KeyCode.Space;

    public KeyCode TeclaSeguinteFrase;
    public KeyCode TeclaInicioDialogo = KeyCode.F;
}
