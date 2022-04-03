using UnityEngine;

public class PlayerController : Player_StateMachine
{
    [SerializeField] private Player _self = null;

    private Player_State _currentState = null;

    public PlayerController Instance { get; private set; }
    public Player Self { get => _self; }

    private void Awake()
    {
        if (!_self)
            _self = GetComponent<Player>();

        Instance = this;

        _currentState = SetState(new IdleState(this));
    }

    private void Tick()
    {
        State.Tick();
    }
}
