using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LvlSelect : MonoBehaviour
{
    [SerializeField]
    GameObject mainMenu, lvlMenu;
    [SerializeField]
    Button bLvl1, bLvl2, bLvl3;

    ColorBlock colorBlock = new ColorBlock();

    private void Start()
    {
        mainMenu.SetActive(true);
        lvlMenu.SetActive(false);
        bLvl2.interactable = false;
        bLvl3.interactable = false;
    }
    public void Lvls()
    {
        mainMenu.SetActive(false);
        lvlMenu.SetActive(true);
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
        if (PlayerPrefs.GetInt("lvl1") == 1)
        {
            bLvl1.GetComponent<Button>().colors = colorBlock;
            colorBlock.normalColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.pressedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.highlightedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.selectedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.colorMultiplier = 1;
            colorBlock.fadeDuration = 0.1f;
            
            bLvl2.interactable = true;
        }
        if (PlayerPrefs.GetInt("lvl2") == 1)
        {
            bLvl2.GetComponent<Button>().colors = colorBlock;
            colorBlock.normalColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.pressedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.highlightedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.selectedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.colorMultiplier = 1;
            colorBlock.fadeDuration = 0.1f;

            bLvl3.interactable = true;
        }
        if (PlayerPrefs.GetInt("lvl3") == 1)
        {
            bLvl3.GetComponent<Button>().colors = colorBlock;
            colorBlock.normalColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.pressedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.highlightedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.selectedColor = new Color(0.0f, 255f, 0.0f, 255f);
            colorBlock.colorMultiplier = 1;
            colorBlock.fadeDuration = 0.1f;
        }
    }
}
