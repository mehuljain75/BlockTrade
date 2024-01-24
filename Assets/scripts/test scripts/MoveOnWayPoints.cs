using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnWayPoints : MonoBehaviour
{
    public List<GameObject> waypoints;
    public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        int index = 0;
        Vector3 destination = waypoints[index].transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position,destination, speed * 2);
        transform.position = newPos;

        float distance = Vector3.Distance(transform.position, destination);

        if(distance <= 0.05) 
        {
            index++;
        }
    }
}
