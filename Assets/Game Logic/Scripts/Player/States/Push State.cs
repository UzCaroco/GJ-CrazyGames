using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushState : PlayerState
{
    public PushState(PlayerStateMachine stateMachine, PlayerController player) : base(stateMachine, player) { }

    public override void Enter()
    {
        Debug.Log("Entrou no Push State");
    }
    public override void Update()
    {
        
    }
    public override void Exit()
    {
        Debug.Log("Saiu do Push State");
    }
}
