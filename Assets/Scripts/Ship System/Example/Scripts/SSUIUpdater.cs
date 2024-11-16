using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SSUIUpdater : MonoBehaviour
{
    [SerializeField] private Ship ship;
    [SerializeField] private TMP_Text distText;
    [SerializeField] private TMP_Text pressText;

    private void Update()
    {
        distText.text = "Distance: " + ship.currentDistance.ToString() + "m";
        pressText.text = "Pressure: " + ship.currentPressure.ToString();
    }
} 