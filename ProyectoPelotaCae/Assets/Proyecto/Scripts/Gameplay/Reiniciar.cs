using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public float lvl = 0;
    public void ReinicioLVL()
    {
        SceneManager.LoadScene("LVL" + lvl.ToString());
        Time.timeScale = 1.0f;
    }

    public void Salir()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("LevelsMenu");
    }
}
