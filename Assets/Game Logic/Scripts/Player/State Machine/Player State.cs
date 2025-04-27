using UnityEngine;

public abstract class PlayerState
{
    protected PlayerStateMachine stateMachine;
    protected PlayerController player;
    protected PlayerInput playerInput;
    public PlayerState (PlayerStateMachine stateMachine, PlayerController player)
    {
        this.stateMachine = stateMachine;
        this.player = player;

        playerInput = new PlayerInput();
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}
