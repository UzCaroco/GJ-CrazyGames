using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerMission : MonoBehaviour
{
    float timeToWait; // Time to wait in seconds
    float timerMax;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartTimer(int timeToWait)
    {
        
    }

    public void GetTimer(float timeToWait, float TimerTheMission)
    {
        this.timeToWait = timeToWait; // Set the time to wait
        timerMax = timeToWait; // Set the maximum timer value
    }
}
