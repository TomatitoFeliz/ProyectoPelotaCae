using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaMenu : MonoBehaviour
{
    Rigidbody ballRigidbody;
    public float jumpForce;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {  
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
