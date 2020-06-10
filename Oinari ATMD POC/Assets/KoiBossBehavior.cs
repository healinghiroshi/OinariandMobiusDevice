using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoiBossBehavior : MonoBehaviour {

    public int KoiHealth;

    // Use this for initialization
    void Start () {
        KoiHealth = 100;
	}

    

    public enum BossPhaseState
    {
        idle,
        Phase1,
        Phase2,
        Phase3,
    }

    private BossPhaseState currState = BossPhaseState.Phase1;

    // Update is called once per frame
    void Update () {
        switch (currState)
        {
            case BossPhaseState.idle:
                Handleidle();
                break;

            case BossPhaseState.Phase1:
                HandlePhase1();
                break;

            case BossPhaseState.Phase2:
                HandlePhase2();
                break;

            case BossPhaseState.Phase3:
                HandlePhase3();
                break;
        }
    }
    void Handleidle()
    {

    }
    void HandlePhase1()
    {

    }
    void HandlePhase2()
    {

    }
    void HandlePhase3()
    {

    }
}
