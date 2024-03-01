using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChevalierFSM : BaseStateMachine<IState>
{
    public NavMeshAgent Agent { get; private set; }
    public GameObject player;
    public PlayerController playerController;

    static private ChevalierFSM instance;
    protected override void Awake()
    {
        instance = this;
        CreatePossibleStates();
    }
    protected override void Start()
    {
        foreach (IState state in m_possibleStates)
        {
            state.OnStart();
        }

        m_currentState = m_possibleStates[0];
        m_currentState.OnEnter(this);
        Agent = GetComponent<NavMeshAgent>();

    }

    protected override void Update()
    {
        m_currentState.OnUpdate();
        TryTransitionningState();
    }

    protected void TryTransitionningState()
    {
        if (!m_currentState.CanExit())
        {
            return;
        }

        foreach (var state in m_possibleStates)
        {
            if (m_currentState.Equals(state))
            {
                continue;
            }

            if (state.CanEnter(m_currentState))
            {
                m_currentState.OnExit();
                m_currentState = state;
                m_currentState.OnEnter(this);
                return;
            }
        }
    }

    private void CreatePossibleStates()
    {
        m_possibleStates.Add(new RoamingState());
        m_possibleStates.Add(new FollowingState());
        m_possibleStates.Add(new RunningState());
    }

    static public ChevalierFSM GetInstance()
    {
        return instance;
    }
}
    
