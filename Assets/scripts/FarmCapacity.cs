using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FarmCapacity : MonoBehaviour
{
    public int size=0;
    public GpuController1 gpuController1;
    //public Button[] buttons;

    //calling the alert manager script here
    public AlertManager alertManager;

    private void OnTriggerEnter(Collider other)
    {
        //gpuController1.move.Clear();
        if (other.CompareTag("gpu"))
        {
            size++;
            Debug.Log("House capacity: " + size);
            other.gameObject.SetActive(false);
        }


        //checking the condition here for collision
        if (size > gpuController1.capacity1 && gpuController1.move.Count==5)
        {
            alertManager.ShowAlert1();

            if (gpuController1.move != null)
            {
               /* Destroy(gpuController1.move[0].gameObject);*/
                gpuController1.move.RemoveAt(0);
            }
            else
            {
                Debug.Log("Please Upgrade!!!");
            }
        }

        if (size > gpuController1.capacity2 && gpuController1.move.Count == 4)
        {
            alertManager.ShowAlert2();

            if (gpuController1.move != null)
            {
                //Destroy(gpuController1.move[0].gameObject);
                gpuController1.move.RemoveAt(0);
            }
            else
            {
                Debug.Log("Please Upgrade!!!");
            }
        }

        if (size > gpuController1.capacity3 && gpuController1.move.Count == 3)
        {

            alertManager.ShowAlert3();
            if (gpuController1.move != null)
            {
                //Destroy(gpuController1.move[0].gameObject);
                gpuController1.move.RemoveAt(0);
            }
            else
            {
                Debug.Log("Please Upgrade!!!");
            }
        }

        if (size > gpuController1.capacity4 && gpuController1.move.Count == 1)
        {
            alertManager.ShowAlert4();
            if (gpuController1.move != null)
            {
                //Destroy(gpuController1.move[0].gameObject);
                gpuController1.move.RemoveAt(0);
            }
            else
            {
                Debug.Log("Please Upgrade!!!");
            }
        }

        if (size > gpuController1.capacity5 && gpuController1.move.Count == 0)
        {
            alertManager.ShowAlert5();
            if (gpuController1.move != null)
            {
               // Destroy(gpuController1.move[0].gameObject);
                gpuController1.move.RemoveAt(0);
            }
            else
            {
                Debug.Log("Please Upgrade!!!");
            }
        }
        
    }
}
