using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : CubeElement
{
    // Start is called before the first frame update
    void Start()
    {
        app.model.roadType = FindObjectOfType<GameApplication>().GetComponent<GameApplication>().controller.app.model.currentPiece;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
