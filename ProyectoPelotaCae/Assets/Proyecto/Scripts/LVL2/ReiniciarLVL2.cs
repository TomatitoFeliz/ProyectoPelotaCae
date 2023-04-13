using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarLVL2 : MonoBehaviour
{
    public void Reinicio()
    {
        SceneManager.LoadScene("LVL2");
        Time.timeScale = 1.0f;
    }
}
