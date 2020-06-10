using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndGateConditions : MonoBehaviour {

    public ProngComponent1 ProngComponents1ref;  //Reference ProngComponent class
    public ProngComponent2 ProngComponents2ref;

    public int prong1stat;
    public int prong2stat;

  
  

    [SerializeField]
    public bool AndGateOn;


    // Use this for initialization
    void Start () {
        AndGateOn = false; 
    }

   

    // Update is called once per frame
    void Update()
    {
        prong1stat = ProngComponents1ref.Prong1Status;
        prong2stat = ProngComponents2ref.Prong2Status;

        if (prong1stat == 1 && prong2stat == 1)
        {
            Debug.Log("And Gate is On");
            AndGateOn = true;
        }
        else
        {
            Debug.Log("And Gate is Off");
            AndGateOn = false;
        }
    }

}
