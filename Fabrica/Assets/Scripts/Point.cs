using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public int index;

    private void Start()
    {
        GetComponent<MeshRenderer>().enabled = false;
    }
}
