using UnityEngine;
using UnityEngine.UI;

public class Refill : MonoBehaviour
{
    public Slider slider;
    public GpuController1 gpuController;
    public float refillSpeed = 1.0f;


    void Start()
    {
        UpdateRefill();
    }

    void Update()
    {
        if (slider.value < slider.maxValue)
        {
            slider.value += refillSpeed * Time.deltaTime;

            // Ensure the slider doesn't exceed its maximum value
            slider.value = Mathf.Clamp(slider.value, 0f, slider.maxValue);
        }
    }

    public void UpdateRefill()
    {
        slider.maxValue = gpuController.capacity4;

        slider.value -= 1f;

        slider.value = Mathf.Clamp(slider.value, 0f, slider.maxValue);
    }
}
