using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private MeshRenderer m_MeshRenderer;
    private Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_MeshRenderer = GetComponent<MeshRenderer>();
        m_MeshRenderer.enabled = false;
        m_Collider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
