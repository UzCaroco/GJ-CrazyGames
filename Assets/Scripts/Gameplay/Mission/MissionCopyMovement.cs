using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class MissionCopyMovement : Missions
{
    [Header("Mission 2 - CM")]
    byte any;
    void Start()
    {
        
    }
    void Update()
    {
        StartMission();
    }
    protected override void StartMission()
    {
        Debug.Log("COPY THE MOVEMENT, Beginning!");
    }
    protected override void CompleteMission()
    {
        Debug.Log("COPY THE MOVEMENT, Finish!");
    }
}
