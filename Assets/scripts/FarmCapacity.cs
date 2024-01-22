using UnityEngine;
using UnityEngine.UI;

public class FarmCapacity : MonoBehaviour
{
    public int size=0;
    public GpuController1 gpuController1;
    public Button[] buttons;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("gpu"))
        {
            // Assuming you want to increase the capacity of the first house in the array
            size++;
            Debug.Log("House capacity: " + size);
            other.gameObject.SetActive(false);
        }
    }
}
