using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : GameElement
{
    // This is where the logic of the game will be implemented. Should include things like changes to currency, managing objects ect.

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("It's working!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("S")) {
            app.model.currentPiece = "straight";
        }

        if (Input.GetKeyDown("T")) {
            app.model.currentPiece = "turn";
        }

        if (Input.GetKeyDown("4") || Input.GetKeyDown("F")) {
            app.model.currentPiece = "4way";
        }

        if (Input.GetKeyDown("R")) {
            app.model.currentPiece = "roundabout";
        }
    }
}
