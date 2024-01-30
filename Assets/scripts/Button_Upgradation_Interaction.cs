using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Upgradation_Interaction : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] oldButtons;

    public void Upgrade()
    {
        foreach (var button in oldButtons)
        {
            if (button != null)
            {
                Destroy(button);
            }
        }
    }
}
