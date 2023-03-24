using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody ballrigidbody;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            Debug.Log("Chocó");
        }
    }

    private void Start()
    {
        ballrigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!Mathf.Approximately(ballrigidbody.velocity.y, 0.0f))
        {
            //Debug.Log("YOU LOOSE");
        }
    }
}
