using UnityEngine;
using UnityEngine.UI;

public class CapacityBar : MonoBehaviour
{
    public Slider slider;
    public GpuController1 gpuController;
    public FarmCapacity[] farmCapacity;

    void Start()
    {
        // Initialize the slider value based on the initial count
        UpdateCapacityBar();
        slider.maxValue = gpuController.capacity1;
    }

    void Update()
    {
        // Check for changes in the count and update the capacity bar accordingly
        UpdateCapacityBar();
    }

    void UpdateCapacityBar()
    {
        float totalSize = 0f;

        for (int i = 0; i < farmCapacity.Length; i++)
        {
            if (farmCapacity[i].size > 0)
            {
                totalSize += farmCapacity[i].size;
            }
        }
        slider.value = totalSize;
    }

    // Change for testing purposes
    public void OnButton2()
    {

        slider.maxValue = gpuController.capacity2;
    }

    public void OnButton3()
    {
        slider.maxValue = gpuController.capacity3;
    }

    public void OnButton4()
    {
        slider.maxValue = gpuController.capacity4;
    }

    public void OnButton5()
    {
        slider.maxValue = gpuController.capacity5;
    }

    public void OnButton6()
    {
        slider.maxValue = gpuController.capacity6;
    }

    public void OnButton7()
    {
        slider.maxValue = gpuController.capacity7;
    }

    public void OnButton8()
    {
        slider.maxValue = gpuController.capacity8;
    }

    public void OnButton9()
    {
        slider.maxValue = gpuController.capacity9;
    }

    public void OnButton10()
    {
        slider.maxValue = gpuController.capacity10;
    }
}