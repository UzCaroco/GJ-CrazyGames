using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public class MissionStayAwayBomb : Missions
{
    [Header("Mission 6 - SAB")]
    private GameObject prefabBomb;

    private bool isInitialized;

    private byte index;

    private int posXBomb, posYBomb;
    private int lastXRandom, lastYRandom;
    private Transform spawnBomb;
    private bool hasCollision;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void DrawPosition()
    {
        while (lastXRandom == posXBomb)
        {
            lastXRandom = Random.Range(0,100);
        }

        while(lastYRandom == posYBomb)
        {
            lastYRandom = Random.Range(0,100);
        }

        posXBomb = lastXRandom;
        posYBomb = lastYRandom;
        spawnBomb.position = new Vector2(posXBomb, posYBomb);
    }

    void initializeBomb()
    {
        if (!isInitialized && index <= 5)
        {
            DrawPosition();

            Debug.Log("Spawndando em X:" + posXBomb + "em Y:" + posYBomb + "sendo a:" + index);
            GameObject bomb = Instantiate(prefabBomb, spawnBomb.position, transform.rotation);
            bomb.transform.SetParent(spawnBomb);
            isInitialized = true;
            
            StartCoroutine(CountDown());
        }
    }

    void ExplodeTheBomb()
    {

    }

    IEnumerator CountDown()
    {
        if (index + 1 < 6)
        {
            index++;

            Debug.Log("NextBomb: " + index);
        }
        else
        {
            Debug.Log("is Initialized all!");
            //index = 0;
        }

        yield return new WaitForSeconds(0.2f);

        isInitialized = false;
    }

    protected override void StartMission()
    {
        Debug.Log("Stay Away Bomb, Beginning!");

        initializeBomb();
    }

    protected override void CompleteMission()
    {
        Debug.Log("Stay Away Bomb, Finish!");
        index = 0;
    }

    /*protected override void LostMission()
    {
        Debug.Log("Stay Away Bomb, Lost!");
    }*/
}
