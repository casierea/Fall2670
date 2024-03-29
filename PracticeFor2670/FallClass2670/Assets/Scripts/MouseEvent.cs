﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvent : MonoBehaviour
{
    public UnityEvent MouseDown;
    public UnityEvent MouseUp;

    private void OnMouseDown()
    {
        MouseDown.Invoke();
    }

    private void OnMouseUp()
    {
        MouseUp.Invoke();
    }
}