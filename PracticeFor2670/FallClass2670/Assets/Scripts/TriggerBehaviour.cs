using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Triggerbehaviour : MonoBehaviour
{
    public FloatDataObject data;
    private void OnTriggerEnter(Collider other)
    {
        data.UpdateValue( -.1f);
    }
}
