using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloataDataObject : ScriptableObject
{
    
    private float value = 1f;
    

    
    public void UpdateValue(float number)
    {
        value += number;
    }
}
