using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour {




    public void Start () { 
 

    /* GameObject gate;
     GameObject prong1;
     GameObject prong2;
     gate = new GameObject("AndGate1");
     prong1 = new GameObject("Left");
     prong2 = new GameObject("Right");
        gate.GetComponent<GateInfo>().Info.GateType = 1;
     */
    }

    private void Update () {
        //for loop to check how it's doing 

    }



    private void GateIsOn( )
    {

    }

    private void prongSwitching()
    {
        
    }

    /*You could do something like if(logicgate[1].isOn){do something}
     And in your component u put on the logic gate, have isOn as a book  -Andy

    Create Array of Gates
    Each Gate has 3 pieces of information 
    1. Type of Gate (AND, OR, XOR) 
    2. Prong1 status (0 or 1)
    3. Prong2 status (0 or 1)
    
    Create isOn() function to check gate status
    
    Loop through array, if all gate status are true, then unlock.
    If partial, then unlock partial.
    */
}
