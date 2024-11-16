using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public ShipInfo shipInfo;

    public int currentDistance;

    public int currentPressure;

    private void FixedUpdate()
    {
        if(currentPressure > shipInfo.maxPressure)
        {
            Debug.LogError("BANG!!!!");
            SceneManager.LoadScene("ShipSystemExample");
        }
    }
}