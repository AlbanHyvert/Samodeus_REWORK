using UnityEngine;

public abstract class Player_StateMachine : MonoBehaviour
{
    protected Player_State State = null;

    public Player_State SetState(Player_State newState = null)
    {
        if (newState == null)
            return null;

        State = newState;

        State.Init();

        return State;
    }
}