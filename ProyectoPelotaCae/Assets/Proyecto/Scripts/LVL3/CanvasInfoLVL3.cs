using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasInfoLVL3 : MonoBehaviour
{
    public TextMeshProUGUI recordMax, recordActual;
    float distanciaTxt;
    public BallBehaviourLVL3 distanciaVar;
    private void Start()
    {
        distanciaVar = FindObjectOfType<BallBehaviourLVL3>();
    }
    private void Update()
    {
        distanciaTxt = distanciaVar.distancia;
        recordActual.text = ("Has recorrido una distancia de: " + distanciaTxt.ToString("0.00"));
        recordMax.text = ("El record máximo obtenido es de: " + PlayerPrefs.GetFloat("recordLVL3").ToString("0.00"));
    }
}
