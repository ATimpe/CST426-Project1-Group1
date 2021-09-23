using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : GameElement
{
    // This is where the logic of the game will be implemented. Should include things like changes to currency, managing objects ect.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changePiece(string pieceType) {
        app.model.currentPiece = pieceType;
        Debug.Log("piece now set to " + pieceType);
    }

    public void changeRotation(int rotation) {
        app.model.rotation = rotation;
        Debug.Log("rotation now at " + rotation);
    }
}
