using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    [SerializeField]
    GameObject Escenario;

    public float velocidad = 10;

    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        Escenario.transform.Rotate(new Vector3 (0f, Horizontal, 0f) * velocidad * Time.deltaTime);
        float moves = Mathf.Clamp(Input.mousePosition.x, -1, 1);
        Debug.Log(moves);
    }
    private void OnMouseDrag()
    {
        Debug.Log("click");
        float moves = Mathf.Clamp(Input.mousePosition.x, -1, 1);
        Escenario.
            transform.Rotate(new Vector3(0f, moves, 0f) * velocidad * Time.deltaTime);
    }
}
