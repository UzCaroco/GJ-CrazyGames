using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class MissionAvoidProjectiles : Missions
{
    [Header("Mission 0 - A")]
    [SerializeField] byte any;

    void Start()
    {
        
    }
    void Update()
    {
        StartMission();
    }

    protected override void StartMission()
    {
        Debug.Log("Avoid projéteis, Beginning!");
    }
    protected override void CompleteMission()
    {
        Debug.Log("Avoid projéteis, Finish!");
    }
}
