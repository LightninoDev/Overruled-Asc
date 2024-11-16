 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSUpgrader : MonoBehaviour
{
    [SerializeField] private Ship ship;   
    [SerializeField] private ShipInfo bShip;
    [SerializeField] private ShipInfo U1Ship;
    [SerializeField] private ShipInfo U2Ship;

    [SerializeField] private Material shipMat;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(ship.shipInfo == bShip) { UpgraderBase(); }
            else if (ship.shipInfo == U1Ship) { Upgrader1(); }
            else if (ship.shipInfo == U2Ship) { Upgrader2(); }
        }
    }

    public void UpgraderBase()
    {
        ship.shipInfo = U1Ship; shipMat.color = Color.blue;
    }

    public void Upgrader1()
    {
        ship.shipInfo = U2Ship; shipMat.color = Color.red;
    }

    public void Upgrader2()
    {
        ship.shipInfo = bShip; shipMat.color = Color.green;
    }
}
