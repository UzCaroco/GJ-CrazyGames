using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TimerMission : MonoBehaviour
{
    float timeToWaitTheMission; // Time to wait in seconds
    float timerToCompleteThMission;

    bool isTimerActive = false; // Flag to check if the timer is active

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartTimerToWait(float timeToWait)
    {
        timeToWaitTheMission -= Time.unscaledDeltaTime; 

        if (timeToWaitTheMission <= 0)
        {
            timeToWaitTheMission = timeToWait;

            isTimerActive = false; // Disable the script when the timer is complete
        }
        else 
            isTimerActive = true;
    }
    
    void StartTimerToComplete(float timeToComplete)
    {
        timeToWaitTheMission -= Time.unscaledDeltaTime; 

        if (timeToWaitTheMission <= 0)
        {
            timeToWaitTheMission = timeToComplete;

            isTimerActive = false; // Disable the script when the timer is complete
        }
        else 
            isTimerActive = true;
    }

    public void GetTimer(float timeToWait, float TimerTheMission)
    {
        timeToWaitTheMission = timeToWait; // Set the time to wait for the mission
        timerToCompleteThMission = TimerTheMission; // Set the timer for the mission

        StartTimerToWait(timeToWait); // Start the timer coroutine
    }
}
