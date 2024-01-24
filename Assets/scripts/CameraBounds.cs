using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    public Transform topLeftBound;
    public Transform bottomRightBound;

    void LateUpdate()
    {
        // Get the current camera position
        Vector3 clampedPosition = transform.position;

        // Clamp the x-axis within the specified bounds
        clampedPosition.x = Mathf.Clamp(transform.position.x, topLeftBound.position.x, bottomRightBound.position.x);

        // Clamp the y-axis within the specified bounds
        clampedPosition.y = Mathf.Clamp(transform.position.y, bottomRightBound.position.y, topLeftBound.position.y);

        // Apply the clamped position to the camera
        transform.position = new Vector3(clampedPosition.x, clampedPosition.y, transform.position.z);
    }
}
