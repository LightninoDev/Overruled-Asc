using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ShipSave : MonoBehaviour
{
    private string saveFilePath;
    [SerializeField] private Ship ship;
    [SerializeField] private SSUpgrader shipUpgrade;
    [SerializeField] private List<ShipInfo> shipInfos = new List<ShipInfo>();
    private void Awake()
    {
        saveFilePath = Application.persistentDataPath + "/ShipData.json";
        if (File.Exists(saveFilePath))
        {
            string loadedShipData = File.ReadAllText(saveFilePath);
            ShipInfoData data = JsonUtility.FromJson<ShipInfoData>(loadedShipData);
            File.Delete(saveFilePath);
            foreach(ShipInfo ships in shipInfos)
            {
                if(ships.shipName == data.shipName)
                {
                    ship.shipInfo = ships;
                    // Change this later
                    if(ships.shipName == "Base Ship")
                    {
                        shipUpgrade.Upgrader2();
                    }
                    else
                    {
                        if (ships.shipName == "Up: 1")
                        {
                            shipUpgrade.Upgrader1();
                        }
                        else
                        {
                            if (ships.shipName == "Up: 2")
                            {
                                shipUpgrade.UpgraderBase();
                            }
                        }
                    }
                }
            }
        }
    }

    private void OnApplicationQuit()
    {
        ShipInfoData shipInfoData = new ShipInfoData();
        shipInfoData.shipName = ship.shipInfo.shipName;
        string saveShipData = JsonUtility.ToJson(shipInfoData);
        File.WriteAllText(saveFilePath, saveShipData);
    }
}