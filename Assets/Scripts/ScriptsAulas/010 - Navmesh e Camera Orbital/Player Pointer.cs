using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class PlayerPointer : MonoBehaviour
{
    //NavMeshAgent myAgent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            PointClick();
        }
    }
    void PointClick()
    {
        Ray raio;
        raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(raio, out hit))
        {
            Debug.Log(hit.transform.gameObject.name);
            //myAgent.SetDestination(hit.point);//move o navmesh agent pro destino do clique
        }
        else 
        {
            Debug.LogWarning("xxxx");
        }
    }
}
