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
        LeanTween.scaleY(gameObject, 0.4f, 0.05f).setOnComplete(() => { LeanTween.scaleY(gameObject, 0.57574f, 0.15f); });
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

}
