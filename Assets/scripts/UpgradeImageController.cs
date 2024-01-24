using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class UpgradeImageController : MonoBehaviour
{
    public GameObject[] oldImages;
    public GameObject newImage;
    public void Upgrade()
    {
        foreach (var building in oldImages)
        {
            if (building != null) // Check if the object is not null
            {
                building.SetActive(false);
                //Destroy(building);
            }
        }
        newImage.SetActive(true);
        //button.interactable = false;
        //gameObject.SetActive(false);
        //Destroy(gameObject);
    }
}