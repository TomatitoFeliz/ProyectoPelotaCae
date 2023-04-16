using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject ajustes;
    public void Ajustes()
    {
        if (ajustes.activeInHierarchy == true)
        {
            ajustes.SetActive(false);
            //ajustes.transform.localScale = Vector3.zero;
        }
        else if (ajustes.activeInHierarchy == false)
        {
            ajustes.SetActive(true);
        }
    }
    public void Salir()
    {
        Application.Quit();
    }
}
