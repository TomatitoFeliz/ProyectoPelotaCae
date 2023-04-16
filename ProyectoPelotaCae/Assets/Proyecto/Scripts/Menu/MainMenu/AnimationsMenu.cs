using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationsMenu : MonoBehaviour
{
    [SerializeField]
    GameObject helix, jump, start, ajustes;
    [SerializeField]
    CanvasGroup startcanvas;

    private void Awake()
    {
        LeanTween.moveLocalY(helix, 164, 2.0f).setEaseInOutBack().setOnComplete(() => {
            LeanTween.moveLocalX(jump, 141, 2.0f).setEaseInCirc().setOnComplete(() => {
                LeanTween.alphaCanvas(startcanvas, 1, 3.0f);
                LeanTween.scale(start, new Vector3(1.0f, 1.0f, 1.0f), 2.0f);
            });  
        });
    }
    private void OnEnable()
    {
        LeanTween.scale(ajustes, new Vector3(1.7f, 1.7f, 1.7f), 2.0f).setOnComplete(AjustesRelevo);
    }
    void AjustesRelevo()
    {
        LeanTween.scale(ajustes, new Vector3(2.0f, 2.0f, 2.0f), 1.0f).setEaseInBounce();
    }
}
