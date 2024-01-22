using UnityEngine;

public class ReceivingHouse : MonoBehaviour
{
    private int objectsCollided = 0;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has a specific tag or component
        // For simplicity, let's assume the objects you're counting have a "Collectible" tag.
        if (other.CompareTag("Collectible"))
        {
            objectsCollided++;
            Debug.Log("Objects Collided: " + objectsCollided);

            // Optionally, you can destroy the collected object
            Destroy(other.gameObject);
        }
    }
}
