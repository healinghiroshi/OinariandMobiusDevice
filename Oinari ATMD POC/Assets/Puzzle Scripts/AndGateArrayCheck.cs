using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndGateArrayCheck : MonoBehaviour {

    public AndGateConditions AndGateCheck1;
    public AndGateConditions AndGateCheck2; //Reference GateConditions class
    public OrGateConditions OrGateCheck1;

    //Create array later for cleanup

    public bool AndGate1Stat;
    public bool AndGate2Stat;
    public bool OrGate1Stat;


    [SerializeField]
    public bool totalOutput;

    void Start()
    {
        totalOutput = false;
    }

    void Update()
    {
        AndGate1Stat = AndGateCheck1.AndGateOn;
        AndGate2Stat = AndGateCheck2.AndGateOn;
        OrGate1Stat = OrGateCheck1.OrGateOn;

        if (AndGate1Stat && AndGate2Stat == true)
        {
            totalOutput = true;

            transform.position = new Vector3(0, 0, 1);
           
        }
        else totalOutput = false;


    }

}
