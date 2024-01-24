using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TokenProgressBar : MonoBehaviour
{
    public int totalTokens = 500;
    public Slider slider;


    void Start()
    {
        UpdateTokenProgressBar();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTokenProgressBar();
    }

    void UpdateTokenProgressBar()
    {
        slider.maxValue = totalTokens;

        if(GPUSingleton.Instance != null)
        {
            slider.value = GPUSingleton.Instance.GPUS;
        }
    }
}
