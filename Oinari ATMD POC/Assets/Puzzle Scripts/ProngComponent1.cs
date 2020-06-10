using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProngComponent1 : MonoBehaviour {

    public int Prong1Status;
    bool playerCanToggle;


    // Use this for initialization
    public void Start () {
        Prong1Status = 0;
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerCanToggle = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerCanToggle = false;
        }
    }

    // Update is called once per frame
    void Update () {
        while (playerCanToggle == true && Input.GetButtonDown("Interact"))
        {
            if (Prong1Status == 0)
            {
                Prong1Status = 1;   
                break;
            }
            else if (Prong1Status == 1)
            {
                Prong1Status = 0;
                break;
            }

        }

    }


}
