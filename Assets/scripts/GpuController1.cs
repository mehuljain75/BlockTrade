using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class GpuController1 : MonoBehaviour
{
    //gpu game object
    public GameObject smallObjectPrefab;

    // destination for the gpu's
    public List<Transform> move = new List<Transform>();

    //for count the click
    public int count = 0;

    // calling Refill Script
    public Refill refillScript;

    //Alert ui when house is full
    public AlertManager alertManager;

    // calling clicker script for the cost
    public Clicker clicker;

    // Capacity of all the farm 1           
    public int capacity1 = 50;
    public int capacity2 = 100;
    public int capacity3 = 150;
    public int capacity4 = 200;
    public int capacity5 = 250;

    //Capacity of all the farm 2
    public int capacity6 = 300;
    public int capacity7 = 350;
    public int capacity8 = 400;
    public int capacity9 = 450;
    public int capacity10 = 500;


    //Capacity of all the farm 3
    public int capacity11 = 550;
    public int capacity12 = 600;
    public int capacity13 = 650;
    public int capacity14 = 700;
    public int capacity15 = 750;

    //Capacity of all the farm 4
    public int capacity16 = 800;
    public int capacity17 = 850;
    public int capacity18 = 900;
    public int capacity19 = 950;
    public int capacity20 = 1000;

    //Capacity of all the farm 5
    public int capacity21 = 1050;
    public int capacity22 = 1100;
    public int capacity23 = 1150;
    public int capacity24 = 1200;
    public int capacity25 = 1250;

    //Capacity of all the farm 6
    public int capacity26 = 1300;
    public int capacity27 = 1350;
    public int capacity28 = 1400;
    public int capacity29 = 1450;
    public int capacity30 = 1500;

    //Capacity of all the farm 7
    public int capacity31 = 1550;
    public int capacity32 = 1600;
    public int capacity33 = 1650;
    public int capacity34 = 1700;
    public int capacity35 = 1750;

    //Capacity of all the farm 8
    public int capacity36 = 1800;
    public int capacity37 = 1850;
    public int capacity38 = 1900;
    public int capacity39 = 1950;
    public int capacity40 = 2000;

    //Capacity of all the farm 9
    public int capacity41 = 2050;
    public int capacity42 = 2100;
    public int capacity43 = 2150;
    public int capacity44 = 2200;
    public int capacity45 = 2250;

    //Capacity of all the farm 9
    public int capacity46 = 2300;
    public int capacity47 = 2350;
    public int capacity48 = 2400;
    public int capacity49 = 2450;
    public int capacity50 = 2500;

    //Capacity of all the farm 10
    public int capacity51 = 2550;
    public int capacity52 = 2600;
    public int capacity53 = 2650;
    public int capacity54 = 2700;
    public int capacity55 = 2750;

    public void SpawnSmallObject(Transform moveTransform)
    {

        GameObject smallObject = Object_Pooler.instance.GetPooledObject();

        

        if (smallObject != null)
        {
            smallObject.GetComponent<BoxCollider>().enabled = true;


            smallObject.transform.position = transform.position;
            smallObject.SetActive(true);

            NavMeshAgent smallObjectNavMeshAgent = smallObject.GetComponent<NavMeshAgent>();

            if (smallObjectNavMeshAgent != null && moveTransform != null)
            {
                smallObjectNavMeshAgent.destination = moveTransform.position;
            }
        }

    }

    public void OnClick()
    {
        if (move.Count > 0)
        {
            

            // for the refill bar
            if (refillScript.slider.value > -1)
            {
                count++;
                // Calculate the index of the destination based on the count

                //int destinationIndex = count % move.Count - 1;
                int destinationIndex = Random.Range(0, move.Count);

                Debug.Log("Destination index out of range: " + destinationIndex + " move   " + move.Count);


                // Get the corresponding destination transform
                Transform destinationTransform = move[destinationIndex];

                // Spawn the small object at the calculated destination
                SpawnSmallObject(destinationTransform);


                //  Conditions for spawning small objects based on capacity

                if (count > 0 && count <= capacity1)
                {
                    /*if(destinationIndex == 0)
                    {
                        full = false;
                    }*/

                    //SpawnSmallObject(move[0]);  
                }

                else if (count > capacity1 && count <= capacity2)
                {
                    //SpawnSmallObject(move[1]);

                }

                else if (count > capacity2 && count <= capacity3)
                {
                    //SpawnSmallObject(move[2]);
                }

                else if (count > capacity3 && count <= capacity4)
                {
                    //SpawnSmallObject(move[3]);
                }
                else if (count > capacity4 && count <= capacity5)
                {
                    //SpawnSmallObject(move[4]);
                }

            }
        }
    }

}