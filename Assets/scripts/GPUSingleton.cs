using UnityEngine;

public class GPUSingleton : MonoBehaviour
{
    private static GPUSingleton instance;

    public float GPUS;
    public static GPUSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<GPUSingleton>();

                if (instance == null)
                {
                    GameObject singletonObject = new GameObject("GPUSingleton");
                    instance = singletonObject.AddComponent<GPUSingleton>();
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

}
