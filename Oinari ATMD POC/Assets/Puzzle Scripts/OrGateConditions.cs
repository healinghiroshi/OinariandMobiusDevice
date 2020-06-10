using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrGateConditions : MonoBehaviour {

    public ProngComponent1 ProngComponents1ref;
    public ProngComponent2 ProngComponents2ref;


    public int prong1stat;
    public int prong2stat;

    [SerializeField]
    public bool OrGateOn;


    // Use this for initialization
    void Start()
    {
        OrGateOn = false;
    }



    // Update is called once per frame
    void Update()
    {
        prong1stat = ProngComponents1ref.Prong1Status;
        prong2stat = ProngComponents2ref.Prong2Status;
        if (prong1stat == 1 && prong2stat == 1
            || prong1stat == 1 && prong2stat == 0
            || prong1stat == 0 && prong2stat == 1)
        {
            Debug.Log("Or Gate is On");
            OrGateOn = true;
        }
        else
        {
            Debug.Log("Or Gate is Off");
            OrGateOn = false;
        }
    }

    

}

