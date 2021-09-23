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
        //gets x axis
        //if we press A or D then input is obtainned
        //multiply this by movespeed to get new movespeed
        float x = Input.GetAxis("Horizontal");

        //get z axis
        //Vertical is z axis or W and S
        float z = Input.GetAxis("Vertical");

        x *= moveSpeed;
        z *= moveSpeed;

        //velocity is Vector3
        rig.velocity = new Vector3(x, 0, z);


        if(Input.GetKeyDown("escape"))
        {
            Instantiate(Resources.Load("UI/Menu"), new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
