using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingState : IState
{
    float distanceBetweenPlayerAndAgent;
    public bool CanEnter(IState currentState)
    {
        distanceBetweenPlayerAndAgent = (Vector3.Distance(ChevalierFSM.GetInstance().Agent.transform.position,
            ChevalierFSM.GetInstance().player.transform.position));
        return distanceBetweenPlayerAndAgent <= 5 && ChevalierFSM.GetInstance().playerController.playerLevel <= 1;
        //Si la distance entre les deux est de 5, et que le joueur est de asser bas niveau, on entre dans l'état de poursuite
    }

    public bool CanExit()
    {
        return distanceBetweenPlayerAndAgent > 5; //Si le joueur est trop éloigné, on sort de cet état
    }

    public void OnEnter(ChevalierFSM fsm)
    {
        throw new System.NotImplementedException();
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
