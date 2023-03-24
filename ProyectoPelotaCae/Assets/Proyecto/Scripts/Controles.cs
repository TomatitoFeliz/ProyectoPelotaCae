using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    [SerializeField]
    GameObject Escenario;

    public float velocidad = 10;

    void Start()
    {

    }

    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        Escenario.transform.Rotate(new Vector3 (0f, Horizontal, 0f) * velocidad * Time.deltaTime);
    }
}
