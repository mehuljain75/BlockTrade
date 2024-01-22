using UnityEngine;
using UnityEngine.UI;

public class AlertManager : MonoBehaviour
{
    public GameObject[] alertPanel;
    public float alertDuration = 2f; // Adjust the duration of the alert display

    private void Start()
    {
        HideAlert();
    }

    public void ShowAlert1()
    {
        alertPanel[0].SetActive(true);
        //Invoke("HideAlert", alertDuration);
    }

    public void ShowAlert2()
    {
        alertPanel[1].SetActive(true);
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
