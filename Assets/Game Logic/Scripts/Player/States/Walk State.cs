using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : PlayerState
{
    public WalkState(PlayerStateMachine stateMachine, PlayerController player) : base(stateMachine, player) { }

    public override void Enter()
    {
        Debug.Log("Entrou no Walk State");
    }

    public override void Update()
    {
        /*float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        if (x == 0 && z == 0)
        {
            stateMachine.ChangeState(player.idleState);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            stateMachine.ChangeState(player.pushState);
        }*/
    }

    public override void Exit()
    {
        Debug.Log("Saiu do Walk State");
    }
}
