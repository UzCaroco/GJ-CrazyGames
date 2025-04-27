using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class MissionStaySquare : Missions
{
    [Header("Mission 7 - SS")]
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
        Debug.Log("Stay Square, Beginning!");
    }
    protected override void CompleteMission()
    {
        Debug.Log("Stay Square, Finish!");
    }
}
