using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPostProcess : SingletonClass<UIPostProcess>
{
    Canvas canvas;
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.worldCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }
}
