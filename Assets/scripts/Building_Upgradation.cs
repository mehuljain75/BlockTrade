using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Building_Upgradation : MonoBehaviour
{
    public GameObject[] oldBuilding;
    public GameObject newBuildingPrefab;

    public void Upgrade()
    {
        foreach (var building in oldBuilding)
        {
            if (building != null) // Check if the object is not null
            {
                //building.SetActive(false);
                Destroy(building);
            }
        }
        newBuildingPrefab.SetActive(true);
        //button.interactable = false;
        gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}    