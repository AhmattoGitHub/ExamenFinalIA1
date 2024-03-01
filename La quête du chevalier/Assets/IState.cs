public interface IState
{
    public void OnStart();
    public void OnEnter(ChevalierFSM fsm);
    public void OnUpdate();
    public void OnFixedUpdate();
    public void OnExit();
    public bool CanEnter(IState currentState);
    public bool CanExit();
}
