using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpSO : ScriptableObject
{
    public FloatData Data;

    public void OnPowerUp(FloatData outsideData)
    {
        outsideData.value += Data.value;
    }
}