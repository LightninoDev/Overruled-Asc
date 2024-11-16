using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Ship System/Ship Info")]
public class ShipInfo : ScriptableObject
{
    public string shipName;
    public int shipLevel;
    public int maxPressure;
}