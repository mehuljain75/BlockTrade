using UnityEngine;

[System.Serializable]
public class Path
{
    public Transform[] waypoints;
}

public class MultiPathDefinition : MonoBehaviour
{
    public Path[] paths;
    public float speed = 5f;
    private int currentPathIndex = 0;
    private int currentWaypointIndex = 0;

    public void Update()
    {
        if (paths.Length > 0)
        {
            MoveTowardsWaypoint();
        }
        else
        {
            Debug.LogWarning("No paths defined!");
        }
    }

    public void MoveTowardsWaypoint()
    {
        Path currentPath = paths[currentPathIndex];

        if (currentPath.waypoints.Length > 0)
        {
            Transform currentWaypoint = currentPath.waypoints[currentWaypointIndex];

            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, currentWaypoint.position) < 0.1f)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % currentPath.waypoints.Length;

                if (currentWaypointIndex == 0)
                {

                    currentPathIndex = (currentPathIndex + 1) % paths.Length;

                    // Check if it's the last path
                    if (currentPathIndex == 0)
                    {
                        // If it's the last path and the last waypoint, destroy the GameObject
                        Destroy(gameObject);
                    }
                }
            }
        }
        else
        {
            Debug.LogWarning("No waypoints in the current path!");
        }
    }
}
