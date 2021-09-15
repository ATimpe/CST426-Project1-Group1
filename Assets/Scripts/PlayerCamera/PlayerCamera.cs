using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //public so Unity can allow us to input custom values
    public float moveSpeed = 5; // 5 is default value

    //gets a reference to rigidbody component.
    public Rigidbody rig;

    // Update is called once per frame
    void Update()
    {
        //We want to detect keyboard inputs
        //left = x - 1
        //right = x + 1

        //gets x axis
        //if we press A or D then input is obtainned
        //multiply this by movespeed to get new movespeed
        float x = Input.GetAxis("Horizontal");

        //get z axis
        //Vertical is z axis or W and S
        float z = Input.GetAxis("Vertical");

        if (x == 1 && z == 0)
        {
            z += -1;
        }
        else if (x == -1 && z == 0)
        {
            z += 1;
        }
        else if (x == 0 && z == 1)
        {
            x += 1;
        }
        else if (x == 0 && z == -1)
        {
            x += -1;
        }

        x *= moveSpeed;
        z *= moveSpeed;

        //velocity is Vector3
        rig.velocity = new Vector3(x, 0, z);
    }
}
