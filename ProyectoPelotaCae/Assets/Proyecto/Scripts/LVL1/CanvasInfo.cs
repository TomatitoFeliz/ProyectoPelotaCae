using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasInfo : MonoBehaviour
{
    public TextMeshProUGUI recordMax, recordActual;
    float distanciaTxt;
    public BallBehaviour distanciaVar;
    private void Start()
    {
        distanciaVar = FindObjectOfType<BallBehaviour>();
    }
    private void Update()
    {
        distanciaTxt = distanciaVar.distancia;
        recordActual.text = ("Has recorrido una distancia de: " + distanciaTxt.ToString("0.00"));
        recordMax.text = ("El record máximo obtenido es de: " + PlayerPrefs.GetFloat("record").ToString("0.00"));
    }
}
