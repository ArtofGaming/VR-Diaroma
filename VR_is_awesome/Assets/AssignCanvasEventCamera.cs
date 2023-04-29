using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCanvasEventCamera : MonoBehaviour
{
    public Canvas canvas;
    void Start() 
    { 
        Canvas canvas = GetComponent<Canvas>(); 
        if (canvas && canvas.worldCamera == null) 
        { 
            canvas.worldCamera = Camera.main; 
        } 
    }
}
