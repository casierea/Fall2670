using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBehaviour : MonoBehaviour
{
    public FloataDataObject data;

    private void OnTriggerEnter(Collider other)
    {
        data.UpdateValue(-1.0f);
    }
}
