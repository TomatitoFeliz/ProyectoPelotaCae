using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallBehaviourLVL2 : MonoBehaviour
{
    Rigidbody ballrigidbody;
    [SerializeField] float fuerza = 5f;
    TrailRenderer trail;
    [SerializeField] float ultraspeed = 10.0f;
    [SerializeField]
    GameObject restart;

    public float posInicial;
    public float posFinal;
    public float distancia;
    public float distanciaRecord = 0;
    float lastSpeedY = 0.0f;

    int lvl2Completed = 0;
    private void Start()
    {
        restart.SetActive(false);
        trail = GetComponent<TrailRenderer>();
        ballrigidbody = GetComponent<Rigidbody>();
        trail.enabled = false;
        posInicial = transform.position.y;
        Debug.Log("posInicial " + posInicial);
    }

    private void Update()
    {
        Debug.Log("es: " + PlayerPrefs.GetInt("lvl2"));
        if (PlayerPrefs.GetInt("lvl2") == 0)
        {
            PlayerPrefs.SetInt("lvl2", lvl2Completed);
        }

        lastSpeedY = ballrigidbody.velocity.y;
        if (lastSpeedY < -6f)
        {
            trail.enabled = true;
        }
        else
        {
            trail.enabled = false;
        }

        if (distancia > PlayerPrefs.GetFloat("recordLVL2"))
        {
            distanciaRecord = distancia;
            PlayerPrefs.SetFloat("recordLVL2", distanciaRecord);
        }
        Debug.Log("Record: " + PlayerPrefs.GetFloat("recordLVL2"));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Basico")
        {
            if (lastSpeedY < -10f)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                ballrigidbody.velocity = Vector3.zero;
                ballrigidbody.AddForce(Vector3.up * fuerza, ForceMode.Impulse);
            }
        }
        else if (collision.gameObject.tag == "Mortal")
        {
            if (lastSpeedY < -10f)
            {
                Destroy(collision.gameObject);
            }
            else
            {
                posFinal = transform.position.y;
                Debug.Log("posFinal " + posFinal);
                distancia = posInicial - posFinal;
                Debug.Log("distancia " + distancia);
                Time.timeScale = 0.0f;
                restart.SetActive(true);
            }
        }
        else if (collision.gameObject.tag == "Final")
        {
            lvl2Completed = 1;
            PlayerPrefs.SetInt("lvl2", lvl2Completed);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
