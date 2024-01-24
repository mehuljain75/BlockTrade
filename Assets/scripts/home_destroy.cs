using UnityEngine;
using UnityEngine.UI;

public class home_destroy : MonoBehaviour
{
    [SerializeField] private Button destroyButton;
    [SerializeField] private GameObject[] objectsToDestroy;

    private void Start()
    {
        if (destroyButton != null)
        {
            destroyButton.onClick.AddListener(DestroyGameObjects);
        }
    }

    private void DestroyGameObjects()
    {
        if (objectsToDestroy != null)
        {
            foreach (var obj in objectsToDestroy)
            {
                if (obj != null)
                {
                    Destroy(obj);
                }       
            }
        }
    }
}
