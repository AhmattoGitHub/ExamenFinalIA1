using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class RoamingState : IState
{
    private ChevalierFSM stateMachine;

    private Vector3 destination = new Vector3(7.30999994f, -3.57500005f, 4.01000023f);
    public bool CanEnter(IState currentState)
    {
        return true; //On peut toujours rentrer dans cet état, c'est l'état de base
    }

    public bool CanExit()
    {
        return true;
    }

    public void OnEnter(ChevalierFSM fsm)
    {
        stateMachine = fsm;
        Debug.Log("Entering RoamingState!");
        stateMachine.Agent.SetDestination(destination);
    }

    public void OnExit()
    {
        throw new System.NotImplementedException();
    }

    public void OnFixedUpdate()
    {
        throw new System.NotImplementedException();
    }

    public void OnStart()
    {
        throw new System.NotImplementedException();
    }

    public void OnUpdate()
    {
        throw new System.NotImplementedException();
    }
}
