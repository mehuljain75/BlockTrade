using UnityEngine;
using TMPro;

public class HouseScript : MonoBehaviour
{
    /*public float GPUS = 0f;*/
    public TMP_Text scoretext;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gpu")
        {
            GPUSingleton.Instance.GPUS++;
            scoretext.text = (int)GPUSingleton.Instance.GPUS + " ";

        }
    }
}
