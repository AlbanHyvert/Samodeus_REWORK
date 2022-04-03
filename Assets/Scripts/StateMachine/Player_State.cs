public abstract class Player_State
{
    protected PlayerController StateMachine = null;

    protected Player_State(PlayerController stateMachine)
    {
        StateMachine = stateMachine;
    }

    public virtual void Init()
    { }

    public virtual void Tick()
    { }

    public virtual void Exit()
    { }

    public virtual void Destroy()
    { }
}
