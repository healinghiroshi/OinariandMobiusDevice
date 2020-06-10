using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
        playerMovement(hor, vert);
    }

    void playerMovement(float x, float y)
    {


        Vector3 playerMovement = new Vector3(x, 0f, y) * Speed * Time.deltaTime;

        if (playerMovement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(playerMovement), 0.15f);
        }
        transform.Translate(playerMovement, Space.World);



    }

}
