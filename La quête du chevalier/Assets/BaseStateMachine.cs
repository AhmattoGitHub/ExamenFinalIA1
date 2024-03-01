using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public abstract class BaseStateMachine<T> : MonoBehaviour where T : IState
{
    protected IState m_currentState;
    protected List<IState> m_possibleStates;

    protected virtual void Awake()
    {
        //CreatePossibleStates();
    }

    protected virtual void Start()
    {

        foreach (IState state in m_possibleStates)
        {
            state.OnStart();
        }

        m_currentState = m_possibleStates[0];
        //m_currentState.OnEnter();
    }

    protected virtual void Update()
    {
        m_currentState.OnUpdate();
        //TryTransitionningState();
    }

    protected virtual void FixedUpdate()
    {
        m_currentState.OnFixedUpdate();
    }
}