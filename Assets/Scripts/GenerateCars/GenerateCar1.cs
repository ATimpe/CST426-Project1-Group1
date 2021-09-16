using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCar1 : MonoBehaviour
{
    public GameObject car1;

    //do time based
    private int framesPassed = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(car1, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

        //time


        //random
        float randomValue = Random.value * 1000;

        // if (randomValue <= 1)
        // {
        //     Debug.Log(randomValue);
        //     Instantiate(car1, transform.position, Quaternion.identity);
        // }

        //frames
        framesPassed++;

        if (framesPassed % 1200 == 0)
        {
            Instantiate(car1, transform.position, Quaternion.identity);
        }
    }
}
