using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BallBehaviour : MonoBehaviour
{
    [SerializeField] float jumpForce = 3f;
    [SerializeField] float ultraSpeed = 10.0f;
    Rigidbody ballRigidbody;
    [SerializeField] TrailRenderer trail; 
    [SerializeField]GameObject reset;
    [SerializeField] int nivel = 1;
    public TextMeshProUGUI recordMax, recordActual;

    public float initialPosition;
    public float endPosition;
    public float distancia;
    void Awake()
    {
        Time.timeScale = 1.0f;
        reset.SetActive(false);
        ballRigidbody = GetComponent<Rigidbody>();
        trail.enabled = (false);
        initialPosition = transform.position.y;
        //string keyLevel = "MetrosNivel" + nivel.ToString();

        // Debug.Log("Record actual = " + PlayerPrefs.GetFloat(keyLevel, 0.0f));
        //Debug.Log("Nivel superado = " + PlayerPrefs.GetInt("NivelSuperado" + nivel.ToString(), 0));

    }

    void Update()
    {
        distancia = initialPosition - endPosition;
        trail.enabled = (ballRigidbody.velocity.y < -ultraSpeed);

        float metrosRecorridos = initialPosition - transform.position.y;
        //Debug.Log("Has recorrido " + metrosRecorridos + "metros");
        Debug.Log(metrosRecorridos);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ballRigidbody.velocity.y < -ultraSpeed)
        {
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Mortal"))
        {
            //Final de partida/muerte
            GuardarDatos(false);
            Time.timeScale = 0.0f;

            float metrosRecorridos = initialPosition - endPosition;
            string keyLevel = "MetrosNivel" + nivel.ToString();

            reset.SetActive(true);
            recordMax.text = ("El record máximo saddas es de: " + PlayerPrefs.GetFloat(keyLevel).ToString("0.00"));
            recordActual.text = ("Has recorrido una ansdnadnsa de: " /*+ metrosRecorridos.ToString("0.00")*/);
        }
        else if (collision.gameObject.CompareTag("Final"))
        {
            //Victoria
            GuardarDatos(true);
        }
        else
        {
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void GuardarDatos(bool hasWon)
    {
        endPosition = transform.position.y;
        ballRigidbody.constraints = RigidbodyConstraints.FreezeAll;

        float metrosRecorridos = initialPosition - endPosition;
        string keyLevel = "MetrosNivel" + nivel.ToString();


        if (PlayerPrefs.GetFloat(keyLevel, 0.0f) < metrosRecorridos)
        {
            PlayerPrefs.SetFloat(keyLevel, metrosRecorridos);

        }
        if (hasWon == true)
        {
            PlayerPrefs.SetInt("NivelSuperado" + nivel.ToString(), 1);
            SceneManager.LoadScene("MainMenu");
        }
        PlayerPrefs.Save();

    }
}