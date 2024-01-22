using UnityEngine;
using UnityEngine.AI;

public class GPU_Speed : MonoBehaviour
{
    public NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        //FactoryLevel10();
    }
    public void FactoryLevel2()
    {
        agent.speed = 6f;
    }

    public void FactoryLevel3()
    {
        agent.speed = 7f;
    }

    public void FactoryLevel4()
    {
        agent.speed = 8f;
    }

    public void FactoryLevel5()
    {
        agent.speed = 9f;
    }

    public void FactoryLevel6()
    {
        agent.speed = 10f;
    }

    public void FactoryLevel7()
    {
        agent.speed = 11f;
    }

    public void FactoryLevel8()
    {
        agent.speed = 12f;
    }

    public void FactoryLevel9()
    {
        agent.speed = 13f;
    }

    public void FactoryLevel10()
    {
        agent.speed = 14f;
        Debug.Log("Factory Level 10 speed set -------------------------------------------------------");
    }

}
