using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public void Reinicio()
    {
        SceneManager.LoadScene("LVL1");
        Time.timeScale = 1.0f;
    }
}
