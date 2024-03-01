using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class RunningState : IState
{
    float distanceBetweenPlayerAndAgent;
    public bool CanEnter(IState currentState)
    {
        distanceBetweenPlayerAndAgent = (Vector3.Distance(ChevalierFSM.GetInstance().Agent.transform.position,
            ChevalierFSM.GetInstance().player.transform.position));
        return distanceBetweenPlayerAndAgent <= 5 && ChevalierFSM.GetInstance().playerController.playerLevel > 1; 
        //On calcule la distance entre les deux, et si cest
        //moins ou egal a 5 unités et le niveau du joueur est plus que 1, on peut rentrer dans l'état de fuite
    }

    public bool CanExit()
    {
        return distanceBetweenPlayerAndAgent > 5;//Si la distance entre les deux est plus que 5, on peut quitter la fuite
    }

    public void OnEnter(ChevalierFSM fsm)
    {
        ChevalierFSM.GetInstance().Agent.SetDestination(new Vector3(7.30999994f, -3.57500005f, -3.0999999f));//Durant cet état, il s'enfuit a sa position initale
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
