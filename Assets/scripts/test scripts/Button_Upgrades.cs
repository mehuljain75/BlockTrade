using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Upgrades : MonoBehaviour
{
    public GpuController1 gpuController1;
    public Clicker clicker;
    public Building_Upgradation building_Upgradation;

    public GameObject[] buttons;

    public void Update()
    {
        Level1();
        Level2();
        Level3();
    }

    public void Level1()
    {
        if (gpuController1.count >= gpuController1.capacity1 && gpuController1.count < gpuController1.capacity2)
        {
            if (clicker.CurrentScore >= clicker.farm1prize && buttons[0] != null)
            {
                buttons[0].SetActive(true);
            }
        }
        else if (gpuController1.count >= gpuController1.capacity2 && gpuController1.count < gpuController1.capacity3)
        {
            if (clicker.CurrentScore >= clicker.farm1prize && buttons[1] != null)
            {
                buttons[1].SetActive(true);
            }
        }
        else if (gpuController1.count >= gpuController1.capacity3 && gpuController1.count < gpuController1.capacity4)
        {
            if (clicker.CurrentScore >= clicker.farm1prize && buttons[2] != null)
            {
                buttons[2].SetActive(true);
            }
        }
        else if (gpuController1.count >= gpuController1.capacity4 && gpuController1.count < gpuController1.capacity5)
        {
            if (clicker.CurrentScore >= clicker.farm1prize && buttons[3] != null)
            {
                buttons[3].SetActive(true);
            }
        }
        else if (gpuController1.count >= gpuController1.capacity5 && buttons[4] != null)
        {
            if (clicker.CurrentScore >= clicker.farm1prize)
            {
                buttons[4].SetActive(true);
            }
        }
    }

    public void Level2()
    {
        if (gpuController1.count >= gpuController1.capacity5 && gpuController1.count < gpuController1.capacity6)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[5] != null)
            {
                buttons[5].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity6 && gpuController1.count < gpuController1.capacity7)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[6] != null)
            {
                buttons[6].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity7 && gpuController1.count < gpuController1.capacity8)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[7] != null)
            {
                buttons[7].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity8 && gpuController1.count < gpuController1.capacity9)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[8] != null)
            {
                buttons[8].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity9 && gpuController1.count < gpuController1.capacity10)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[9] != null)
            {
                buttons[9].SetActive(true);
            }
        }
    }

    public void Level3()
    {
        if (gpuController1.count >= gpuController1.capacity10 && gpuController1.count < gpuController1.capacity11)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[10] != null)
            {
                buttons[10].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity11 && gpuController1.count < gpuController1.capacity12)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[11] != null)
            {
                buttons[11].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity12 && gpuController1.count < gpuController1.capacity13)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[12] != null)
            {
                buttons[12].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity13 && gpuController1.count < gpuController1.capacity14)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[13] != null)
            {
                buttons[13].SetActive(true);
            }
        }

        else if (gpuController1.count >= gpuController1.capacity14 && gpuController1.count < gpuController1.capacity15)
        {
            if (clicker.CurrentScore >= clicker.farm2prize && buttons[14] != null)
            {
                buttons[14].SetActive(true);
            }
        }
    }
}
