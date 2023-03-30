using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallBehaviour : MonoBehaviour
{ 
    Rigidbody ballrigidbody;
    [SerializeField] float fuerza = 5f;
    TrailRenderer trail;
    [SerializeField] float ultraspeed = 10.0f;

    float lastSpeedY = 0.0f;
    private void Start()
    {
        trail = GetComponent<TrailRenderer>();
        ballrigidbody = GetComponent<Rigidbody>();
        trail.enabled = false;
    }

    private void Update()
    {
        lastSpeedY = ballrigidbody.velocity.y;
        if (lastSpeedY < -6f)
        {
            trail.enabled = true;
        }
        else
        {
            trail.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Basico")
        {
            if (lastSpeedY < -10f)
            {
                Debug.Log("Destruye plataforma Basico");
                Destroy(collision.gameObject);
            }
            else
            {
                ballrigidbody.velocity = Vector3.zero;
                ballrigidbody.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
                Debug.Log("Rebota");
            }
        }else if (collision.gameObject.tag == "Mortal")
        {
            if (lastSpeedY < -10f)
            {
                Debug.Log("Destruye plataforma mortal");
                Destroy(collision.gameObject);
            }
            else
            {
                Debug.Log("Muerte");
                Time.timeScale = 0.0f;
                SceneManager.LoadScene("LVL1");
            }
        }
    }
}
