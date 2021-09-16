using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1Move : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody rig;

    // Update is called once per frame
    void Update()
    {
        //car will only move forward
        rig.velocity = new Vector3(0, 0, 1 * moveSpeed);
    }
}
