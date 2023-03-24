using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody ballrigidbody;
    public float fuerza = 5;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            ballrigidbody.velocity = Vector3.zero;
            ballrigidbody.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
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

        if (ballrigidbody.velocity.y > 2)
        {
            //TrailRenderer()
        }
    }
}
