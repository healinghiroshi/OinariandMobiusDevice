using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProngComponent2 : MonoBehaviour
{

    public int Prong2Status;
    bool playerCanToggle;


    // Use this for initialization
    public void Start()
    {
        Prong2Status = 0;
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
    void Update()
    {
        while (playerCanToggle == true && Input.GetButtonDown("Interact"))
        {
            if (Prong2Status == 0)
            {
                Prong2Status = 1;
                Debug.Log(Prong2Status);
                break;
            }
            else if (Prong2Status == 1)
            {
                Prong2Status = 0;
                Debug.Log(Prong2Status);
                break;
            }

        }

    }


}
