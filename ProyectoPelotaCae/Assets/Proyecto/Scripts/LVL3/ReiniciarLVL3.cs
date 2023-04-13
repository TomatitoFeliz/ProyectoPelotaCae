using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarLVL3 : MonoBehaviour
{
    public void Reinicio()
    {
        SceneManager.LoadScene("LVL3");
        Time.timeScale = 1.0f;
    }
}
