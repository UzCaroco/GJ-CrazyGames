using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class MissionStayAwayBomb : Missions
{
    [Header("Mission 6 - SAB")]
    private GameObject prefabBomb;
    private float timeForExplosion;
    private bool isInitialized;


    void Start()
    {
        
    }
    void Update()
    {
        StartMission();
    }
    protected override void StartMission()
    {
        Debug.Log("Stay Away Bomb, Beginning!");
    }
    protected override void CompleteMission()
    {
        Debug.Log("Stay Away Bomb, Finish!");
    }
}
