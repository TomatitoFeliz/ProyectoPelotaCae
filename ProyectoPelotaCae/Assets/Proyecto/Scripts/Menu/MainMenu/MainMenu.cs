using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenu;

    public void Lvls()
    {
        SceneManager.LoadScene("LevelsMenu");
    }
}
