using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] float jumpForce = 3f;
    [SerializeField] float ultraSpeed = 5.0f;
    Rigidbody ballRigidbody;
    [SerializeField] TrailRenderer trail; 
    [SerializeField] GameObject reset;
    
    public int nivel = 0;
    
    public TextMeshProUGUI recordMax, recordActual;

    float initialPosition;
    float endPosition;
    float distancia;

    float velocity;
    void Awake()
    {
        Time.timeScale = 1.0f;
        reset.SetActive(false);
        ballRigidbody = GetComponent<Rigidbody>();
        trail.enabled = (false);
        initialPosition = transform.position.y;
    }

    void Update()
    {
        velocity = ballRigidbody.velocity.y;
        distancia = initialPosition - endPosition;
        trail.enabled = (velocity < -ultraSpeed);

        float metrosRecorridos = initialPosition - transform.position.y;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (velocity < -ultraSpeed)
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Mortal"))
        {
            GuardarDatos(false);
            Time.timeScale = 0.0f;

            float metrosRecorridos = initialPosition - endPosition;
            string keyLevel = "MetrosNivel" + nivel.ToString();

            reset.SetActive(true);
            recordMax.text = ("El record máximo saddas es de: " + PlayerPrefs.GetFloat(keyLevel).ToString("0.00"));
            recordActual.text = ("Has recorrido una distancia de: " + metrosRecorridos.ToString("0.00"));
        }
        else if (collision.gameObject.CompareTag("Final"))
        {
            GuardarDatos(true);
        }
        else
        {
            LeanTween.scaleY(gameObject, 0.4f, 0.05f).setOnComplete(() => { LeanTween.scaleY(gameObject, 0.57574f, 0.15f); });
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void GuardarDatos(bool hasWon)
    {
        endPosition = transform.position.y; 

        float metrosRecorridos = initialPosition - endPosition;
        string keyLevel = "MetrosNivel" + nivel.ToString();


        if (PlayerPrefs.GetFloat(keyLevel, 0.0f) < metrosRecorridos)
        {
            PlayerPrefs.SetFloat(keyLevel, metrosRecorridos);
        }
        if (hasWon == true)
        {
            PlayerPrefs.SetInt("NivelSuperado" + nivel.ToString(), 1);
            SceneManager.LoadScene("LevelsMenu");
        }
        PlayerPrefs.Save();

    }
}