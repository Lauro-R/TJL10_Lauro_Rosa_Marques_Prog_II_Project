using UnityEngine;
using UnityEngine.AI;

public class PlayerFollow : MonoBehaviour
{
    NavMeshAgent myAgent;

    //[SerializeField]
    //Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        myAgent.isStopped = false;
    }
}
