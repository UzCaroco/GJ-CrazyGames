using System.Collections;
using System.Collections.Generic;
using Fusion;
using UnityEngine;

public abstract class Missions : NetworkBehaviour
{
    protected abstract void StartMission();
    protected abstract void CompleteMission();
}
