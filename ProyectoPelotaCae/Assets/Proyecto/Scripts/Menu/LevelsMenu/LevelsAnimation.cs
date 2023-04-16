using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsAnimation : MonoBehaviour
{
    [SerializeField]
    GameObject lvl1, lvl2, lvl3, ajustes;
    [SerializeField]
    Button blvl1, blvl2, blvl3;
    
    private void Awake()
    {
        LeanTween.moveLocalX(lvl1, 89.13f, 1.0f).setEaseInOutBack();
        LeanTween.moveLocalX(lvl2, -99.57f, 1.5f).setEaseInOutBack();
        LeanTween.moveLocalX(lvl3, 89.13f, 2.0f).setEaseInOutBack();
    }
    private void OnEnable()
    {
        LeanTween.scale(ajustes, new Vector3(1.7f, 1.7f, 1.7f), 2.0f).setOnComplete(() => {
            LeanTween.scale(ajustes, new Vector3(2.0f, 2.0f, 2.0f), 1.0f).setEaseInBounce();
        });
    }
}
