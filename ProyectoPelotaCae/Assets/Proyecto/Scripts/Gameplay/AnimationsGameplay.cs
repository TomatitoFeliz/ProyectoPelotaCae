using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationsGameplay : MonoBehaviour
{
    [SerializeField]
    GameObject pelota, reset;
    [SerializeField]
    CanvasGroup resetear;
    private void OnEnable()
    {
        if (reset.activeInHierarchy == true)
        {
            LeanTween.alphaCanvas(resetear, 1.0f, 5.0f);
        }
    }
}
