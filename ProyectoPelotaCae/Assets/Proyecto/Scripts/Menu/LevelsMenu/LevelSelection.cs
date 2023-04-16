using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    [SerializeField]
    Button bLvl2, bLvl3;
    [SerializeField]
    Image iLvl1, iLvl2, iLvl3;

    void Start()
    {
        bLvl2.interactable = false;
        bLvl3.interactable = false;
    }
    public void LVL1()
    {
        SceneManager.LoadScene("LVL1");
    }
    public void LVL2()
    {
        SceneManager.LoadScene("LVL2");
    }
    public void LVL3()
    {
        SceneManager.LoadScene("LVL3");
    }
    private void Update()
    {
        if (PlayerPrefs.GetInt("NivelSuperado1") == 1)
        {
            iLvl1.color = Color.green;
            bLvl2.interactable = true;
        }
        if (PlayerPrefs.GetInt("NivelSuperado2") == 1)
        {
            iLvl2.color = Color.green;
            bLvl3.interactable = true;
        }
        if (PlayerPrefs.GetInt("NivelSuperado3") == 1)
        {
            iLvl3.color = Color.green;
        }
    }
}
