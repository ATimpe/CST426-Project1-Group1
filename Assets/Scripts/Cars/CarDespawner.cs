using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDespawner : MonoBehaviour
{
    //if the car enters a destroy object or zone, destroy it
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Car"))
        {
            Destroy(other.gameObject);
        }
    }
}
