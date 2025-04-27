using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class SunController : MonoBehaviour
{
    /// <summary>
    /// Scipts to Control the Missions
    /// </summary>/
    TimerMission timerMission; // Reference to the TimerMission script

    // SCRIPT DONT MOVE
    // SCRIPT COLLECT THE COIN
    // SCRIPT MOVE
    // SCRIPT STAY AWAY FROM THE BOMB
    // SCRIPT STAY IN THE GREEN SQUARE
    // SCRIPT COPY THE MOVEMENT
    // SCRIPT AVOID PROJECTILES
    
    /// <summary>
    /// Controller the Missions
    /// </summary>

    int randomNumber; // Variable to store the random number
    [SerializeField] float[] timeMission = new float[7]; // Array to store time for each mission
    [SerializeField] float[] timerForStartTheMission = new float[7]; // Array to store time for each mission

    void Awake()
    {
        timerMission = GetComponent<TimerMission>(); // Get the TimerMission component attached to the same GameObject
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
#region Draw
    void Draw()
    {
        randomNumber = Random.Range(0, 7); // Generate a random number between 0 and 100

    }

#endregion Draw
    void StarTime()
    {

    }

}
