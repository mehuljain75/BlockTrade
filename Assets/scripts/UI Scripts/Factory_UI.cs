using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Factory_UI : MonoBehaviour
{
    public TMP_Text FactorySpeed;
    public GPU_Speed Speed;

    void Start()
    {
        FactorySpeed.text = "1x";
    }

    private void Update()
    {
        Speed.button[0].onClick.AddListener(FactoryLevel2);
        Speed.button[1].onClick.AddListener(FactoryLevel3);
        Speed.button[2].onClick.AddListener(FactoryLevel4);
        Speed.button[3].onClick.AddListener(FactoryLevel5);
        Speed.button[4].onClick.AddListener(FactoryLevel6);
        Speed.button[5].onClick.AddListener(FactoryLevel7);
        Speed.button[6].onClick.AddListener(FactoryLevel8);
        Speed.button[7].onClick.AddListener(FactoryLevel9);
        Speed.button[8].onClick.AddListener(FactoryLevel10);
    }
    public void FactoryLevel2()
    {
        FactorySpeed.text = "2x";
    }

    public void FactoryLevel3()
    {
        FactorySpeed.text = "3x";
    }

    public void FactoryLevel4()
    {
        FactorySpeed.text = "4x";
    }

    public void FactoryLevel5()
    {
        FactorySpeed.text = "5x";
    }

    public void FactoryLevel6()
    {
        FactorySpeed.text = "6x";
    }

    public void FactoryLevel7()
    {
        FactorySpeed.text = "7x";
    }

    public void FactoryLevel8()
    {
        FactorySpeed.text = "8x";
    }

    public void FactoryLevel9()
    {
        FactorySpeed.text = "9x";
    }

    public void FactoryLevel10()
    {
        FactorySpeed.text = "10x";
    }
}
