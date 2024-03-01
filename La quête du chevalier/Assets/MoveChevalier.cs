using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveChevalier : MonoBehaviour
{
    private Vector3 destination = new Vector3(7.30999994f, -3.57500005f, 4.01000023f);
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetDestination();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetDestination()
    {
        agent.SetDestination(destination);
    }
}
