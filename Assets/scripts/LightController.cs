using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light myLight;

    void Start()
    {
        // Assuming the script is attached to the same GameObject as the Light component
        myLight = GetComponent<Light>();
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0)) // 0 corresponds to the left mouse button
        {
            // Toggle the light state
            myLight.enabled = !myLight.enabled;
        }
    }
}
