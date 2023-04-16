using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndRotate : MonoBehaviour
{
    private float SceneWith;
    private Vector3 firstclick;
    private Quaternion rotation;
    private void Start()
    {
        SceneWith = Screen.width;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstclick = Input.mousePosition;
            rotation = transform.rotation;
        }
        else if (Input.GetMouseButton(0))
        {
            float diferencia = (Input.mousePosition - firstclick).x;
            transform.rotation = rotation * Quaternion.Euler(Vector3.down * (diferencia / SceneWith) * 360);
        }
    }
}
