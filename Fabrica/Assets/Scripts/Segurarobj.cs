using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segurarobj : MonoBehaviour
{
    public string[] tags;
    public GameObject objsegurando;
    [Space(20)]
    public float DistanciaMax;
    public bool Segurando;
    public GameObject Local;
    public LayerMask Layer;


    void Start()
    {

    }
    void Update()
    {
        if (Segurando == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Segurando = false;
                objsegurando.transform.parent = null;
                objsegurando.GetComponent<Rigidbody>().isKinematic = false;
                objsegurando = null;
                return;

            }
        }

        if (Segurando == false)
        {
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(transform.position, transform.forward, out hit, DistanciaMax, Layer, QueryTriggerInteraction.Ignore))
            {
                Debug.DrawLine(transform.position, hit.point, Color.green);

                for (int x = 0; x < tags.Length; x++)
                {
                    if (hit.transform.gameObject.tag == tags[x])
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            Segurando = true;
                            objsegurando = hit.transform.gameObject;
                            if (objsegurando.GetComponent<Rigidbody>())
                            {
                                objsegurando.GetComponent<Rigidbody>().isKinematic = true;
                                objsegurando.transform.position = Local.transform.position;
                                objsegurando.transform.rotation = Local.transform.rotation;
                                objsegurando.transform.parent = Local.transform;
                            }
                            return;
                        }
                    }
                }

            }
        }
    }

}

