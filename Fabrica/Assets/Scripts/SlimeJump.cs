using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeJump : MonoBehaviour
{
    public Quaternion originalRotation;
    public float timeBetweenWait;
    public float rotationForce;
    public float jumpForce;

    void Start()
    {
        StartCoroutine(startTime());
        originalRotation = transform.rotation;
    }

    IEnumerator startTime()
    {
        
        Debug.Log("Start wait");
        yield return new WaitForSeconds(timeBetweenWait);
        Debug.Log("End wait");
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(getRandomValue(), jumpForce, getRandomValue());
        StartCoroutine(startTime());
    }
    float getRandomValue()
    {
        return Random.Range(-5, 5);
    }

    private void Update()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, originalRotation, rotationForce * Time.deltaTime);
    }


}
