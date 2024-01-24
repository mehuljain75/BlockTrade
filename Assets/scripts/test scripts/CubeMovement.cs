using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public GameObject smallObjectPrefab;  // Assign your small object prefab in the Inspector.
    public Transform destinationCube;     // Assign your destination cube GameObject in the Inspector.

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Spawn the small object at the source cube's position.
            GameObject smallObject = Instantiate(smallObjectPrefab, transform.position, Quaternion.identity);

            // Calculate the direction towards the destination cube.
            Vector3 direction = (destinationCube.position - transform.position).normalized;

            // Add a force to the small object's rigidbody to make it move towards the destination.
            Rigidbody rb = smallObject.GetComponent<Rigidbody>();
            rb.velocity = direction * 5f; // Adjust the speed as needed.

            Destroy(smallObject, 30f);
        }
    }
}
