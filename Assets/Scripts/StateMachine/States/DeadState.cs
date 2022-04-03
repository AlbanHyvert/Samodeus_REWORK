public class DeadState : Player_State
{
    public DeadState(PlayerController stateMachine) : base(stateMachine)
    {
    }

    public override void Init()
    {
        base.Init();
    }

    public override void Tick()
    {
        base.Tick();

    }

    public override void Exit()
    {
        base.Exit();
    }
}
