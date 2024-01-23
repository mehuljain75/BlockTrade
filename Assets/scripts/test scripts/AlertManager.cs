using UnityEngine;
using UnityEngine.UI;

public class AlertManager : MonoBehaviour
{
    public GameObject[] alertPanel;
    public float alertDuration = 2f; // Adjust the duration of the alert display
    float upward = -28f;
    bool check;


    private void Start()
    {
        HideAlert();
    }

    /*void Update()
    {
        foreach (GameObject a in alertPanel)
        {
            if (a != null)
            {
                if (a.transform.position.y > -25)
                {
                    check = true;
                   
                }

                else if (a.transform.position.y < -30)
                {
                    check = false;
                    
                }

                if(check == false)
                {
                    a.transform.position = new Vector3(a.transform.position.x, a.transform.position.y + upward, a.transform.position.z);
                    upward += +0.000025f ;
                }

                else
                {
                    a.transform.position = new Vector3(a.transform.position.x, a.transform.position.y + upward, a.transform.position.z);
                    upward += -0.000025f ;
                }
            }
        }
    }*/

    public void ShowAlert1()
    {
        alertPanel[0].SetActive(true);
        //Invoke("HideAlert", alertDuration);
    }

    public void ShowAlert2()
    {
        alertPanel[1].SetActive(true);
        //alertPanel[1].transform.
        //Invoke("HideAlert", alertDuration);
    }

    public void ShowAlert3()
    {
        alertPanel[2].SetActive(true);
    }

    public void ShowAlert4()
    {
        alertPanel[3].SetActive(true);
    }

    public void ShowAlert5()
    {
        alertPanel[4].SetActive(true);
    }

    void HideAlert()
    {
        alertPanel[0].SetActive(false);
        alertPanel[1].SetActive(false);
        alertPanel[2].SetActive(false);
        alertPanel[3].SetActive(false);
        alertPanel[4].SetActive(false);
    }
}
