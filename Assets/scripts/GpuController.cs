using UnityEngine;
using UnityEngine.AI;

public class GpuController : MonoBehaviour
{
    public GameObject smallObjectPrefab;
    [SerializeField] private Transform[] move;
    public int count;

    public int houseCapacity = 50; // Set a single capacity for all houses

    public AlertManager alertManager;
    public FarmCapacity[] farmCapacities;
    public Refill refill;

    private void Update()
    {
        count = CalculateTotalCapacity();
        if(refill.slider.value > 1)
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (count >= 0 && count < houseCapacity)
                {
                    SpawnObjectAndSetDestination(move[0], 20f, farmCapacities[0]);
                }
                else if (count >= houseCapacity && count < houseCapacity * 2)
                {
                    //alertManager.ShowAlert("House is full! Upgrade to increase capacity.");
                    SpawnObjectAndSetDestination(move[1], 25f, farmCapacities[1]);

                    // Reset the count to 0 when moving to the next house
                    count = 0;
                }
                else if (count >= houseCapacity * 2 && count < houseCapacity * 3)
                {
                    SpawnObjectAndSetDestination(move[2], 20f, farmCapacities[2]);
                }
                else if (count >= houseCapacity * 3 && count < houseCapacity * 4)
                {
                    SpawnObjectAndSetDestination(move[3], 30f, farmCapacities[3]);
                }
                else if (count >= houseCapacity * 4 && count < houseCapacity * 5)
                {
                    SpawnObjectAndSetDestination(move[4], 45f, farmCapacities[4]);
                }
            }
            else
            {
                Debug.Log(" Count exceed , count value is : " + count);
            }
        }
    }

    void SpawnObjectAndSetDestination(Transform destination, float destroyTime, FarmCapacity farmCapacity)
    {
        if (farmCapacity.size < houseCapacity)
        {
            GameObject smallObject = Instantiate(smallObjectPrefab, transform.position, Quaternion.identity);
            NavMeshAgent smallObjectNavMeshAgent = smallObject.GetComponent<NavMeshAgent>();

            if (smallObjectNavMeshAgent != null && destination != null)
            {
                smallObjectNavMeshAgent.destination = destination.position;
                Destroy(smallObject, destroyTime);

                // Increase the capacity of the house
                farmCapacity.size++;
            }
        }
        else
        {
            Debug.Log("Farm capacity exceeded!");
        }
    }

    int CalculateTotalCapacity()
    {
        int totalCapacity = 0;

        foreach (FarmCapacity farmCapacity in farmCapacities)
        {
            totalCapacity += farmCapacity.size;
        }

        return totalCapacity;
    }
}
