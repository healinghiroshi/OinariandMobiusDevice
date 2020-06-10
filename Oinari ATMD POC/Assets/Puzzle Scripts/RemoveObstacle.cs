using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObstacle : MonoBehaviour
{
    public AndGateArrayCheck resultingCheck;

    public bool okToRemove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        okToRemove = resultingCheck.totalOutput;
        if (okToRemove == true)
        {
            transform.position = new Vector3(0, 0, 1);
        }
    }
}
