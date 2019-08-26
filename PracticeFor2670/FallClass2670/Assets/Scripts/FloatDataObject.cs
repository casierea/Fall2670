using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class FloatDataObject : ScriptableObject
{
    public float value = 1f;

    public void UpdateValue(float number)
    {
        value += number;
    }
}
