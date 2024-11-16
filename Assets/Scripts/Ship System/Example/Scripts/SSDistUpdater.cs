using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSDistUpdater : MonoBehaviour
{
    [SerializeField] private int distance;
    [SerializeField] private int pressure;
    [SerializeField] private Ship ship;
    private void OnTriggerEnter(Collider other)
    {
        ship.currentDistance = distance;
        ship.currentPressure = pressure;
    }
}
