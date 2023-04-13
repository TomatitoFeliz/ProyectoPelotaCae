using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasInfoLVL2 : MonoBehaviour
{
    public TextMeshProUGUI recordMax, recordActual;
    float distanciaTxt;
    public BallBehaviourLVL2 distanciaVar;
    private void Start()
    {
        distanciaVar = FindObjectOfType<BallBehaviourLVL2>();
    }
    private void Update()
    {
        distanciaTxt = distanciaVar.distancia;
        recordActual.text = ("Has recorrido una distancia de: " + distanciaTxt.ToString("0.00"));
        recordMax.text = ("El record máximo obtenido es de: " + PlayerPrefs.GetFloat("recordLVL2").ToString("0.00"));
    }
}
