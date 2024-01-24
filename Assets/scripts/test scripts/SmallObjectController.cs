using UnityEngine;
using UnityEngine.AI;

public class SmallObjectController : MonoBehaviour
{
    private GpuController gpuController;

    // Initialize the SmallObjectController with a reference to the GpuController
    public void Initialize(GpuController gpuController)
    {
        this.gpuController = gpuController;
    }

    private void Update()
    {
        // Check if the object has reached its destination
        if (!GetComponent<NavMeshAgent>().pathPending && GetComponent<NavMeshAgent>().remainingDistance <= GetComponent<NavMeshAgent>().stoppingDistance)
        {
            // Destroy the object
            Destroy(gameObject);

            // Optionally, you can also update the count size when the object is destroyed
            if (gpuController != null)
            {
                Debug.Log("Incrementing count size to: " + gpuController.GetComponent<FarmCapacity>().size);
            }
        }
    }
}
