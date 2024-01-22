using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[Serializable]
public class Serializable2DList
{
    public GameObject[] farmButtons;

    public Serializable2DList(int size)
    {
        farmButtons = new GameObject[size];
    }
}

public class Panel_Button_Upgrades : MonoBehaviour
{
    // Calling other scripts
    public GpuController1 gpuController1;
    public Clicker clicker;
    public Building_Upgradation building_Upgradation;

    // GameObject array for my buttons
    //public GameObject[] buttons;

    public Serializable2DList[] farm;

    void Update()
    {
        Level2();
        Level3();
        Level4();
        Level5();
        Level6();
        Level7();
        Level8();
        Level9();
        Level10();
    }

    public void Level2()
    {
        if (clicker.CurrentScore >= clicker.farm1prize)
        {
            farm[0].farmButtons[0].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[0].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[0].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[0].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[0].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm1prize)
            {
                farm[0].farmButtons[0].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[0].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[0].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[0].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[0].GetComponent<Button>().interactable = false;
            }
        }
    }

    public void Level3()
    {
        if (clicker.CurrentScore >= clicker.farm2prize)
        {
            farm[0].farmButtons[1].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[1].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[1].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[1].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[1].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm2prize)
            {
                farm[0].farmButtons[1].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[1].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[1].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[1].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[1].GetComponent<Button>().interactable = false;
            }
        }
    }

    public void Level4()
    {
        if (clicker.CurrentScore >= clicker.farm3prize)
        {
            farm[0].farmButtons[2].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[2].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[2].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[2].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[2].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm3prize)
            {
                farm[0].farmButtons[2].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[2].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[2].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[2].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[2].GetComponent<Button>().interactable = false;
            }
        }
    }

    public void Level5()
    {
        if (clicker.CurrentScore >= clicker.farm4prize)
        {
            farm[0].farmButtons[3].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[3].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[3].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[3].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[3].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm4prize)
            {
                farm[0].farmButtons[3].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[3].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[3].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[3].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[3].GetComponent<Button>().interactable = false;
            }
        }
    }

    public void Level6()
    {
        if (clicker.CurrentScore >= clicker.farm5prize)
        {
            farm[0].farmButtons[4].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[4].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[4].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[4].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[4].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm5prize)
            {
                farm[0].farmButtons[4].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[4].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[4].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[4].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[4].GetComponent<Button>().interactable = false;
            }
        }
    }

    public void Level7()
    {
        if (clicker.CurrentScore >= clicker.farm6prize)
        {
            farm[0].farmButtons[5].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[5].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[5].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[5].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[5].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm6prize)
            {
                farm[0].farmButtons[5].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[5].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[5].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[5].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[5].GetComponent<Button>().interactable = false;
            }
        }
    }


    public void Level8()
    {
        if (clicker.CurrentScore >= clicker.farm7prize)
        {
            farm[0].farmButtons[6].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[6].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[6].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[6].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[6].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm7prize)
            {
                farm[0].farmButtons[6].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[6].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[6].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[6].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[6].GetComponent<Button>().interactable = false;
            }
        }
    }


    public void Level9()
    {
        if (clicker.CurrentScore >= clicker.farm8prize)
        {
            farm[0].farmButtons[7].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[7].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[7].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[7].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[7].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm8prize)
            {
                farm[0].farmButtons[7].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[7].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[7].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[7].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[7].GetComponent<Button>().interactable = false;
            }
        }
    }


    public void Level10()
    {
        if (clicker.CurrentScore >= clicker.farm9prize)
        {
            farm[0].farmButtons[8].GetComponent<Button>().interactable = true;
            farm[1].farmButtons[8].GetComponent<Button>().interactable = true;
            farm[2].farmButtons[8].GetComponent<Button>().interactable = true;
            farm[3].farmButtons[8].GetComponent<Button>().interactable = true;
            farm[4].farmButtons[8].GetComponent<Button>().interactable = true;
        }
        else
        {
            if (clicker.CurrentScore <= clicker.farm9prize)
            {
                farm[0].farmButtons[8].GetComponent<Button>().interactable = false;
                farm[1].farmButtons[8].GetComponent<Button>().interactable = false;
                farm[2].farmButtons[8].GetComponent<Button>().interactable = false;
                farm[3].farmButtons[8].GetComponent<Button>().interactable = false;
                farm[4].farmButtons[8].GetComponent<Button>().interactable = false;
            }
        }
    }
}