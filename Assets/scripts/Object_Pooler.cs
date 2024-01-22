using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Pooler : MonoBehaviour
{
    public static Object_Pooler instance;

    public List<GameObject> pooledObjects = new List<GameObject>();
    private int ammountToPool = 500;

    [SerializeField] private GameObject gpuPrebab;
    void Start()
    {
        for (int i = 0; i < ammountToPool; i++)
        {
            GameObject obj = Instantiate(gpuPrebab);
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    public GameObject GetPooledObject()
    {
        for(int i=0;i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
