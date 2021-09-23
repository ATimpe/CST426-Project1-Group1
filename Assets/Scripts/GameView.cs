using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameView : GameElement
{
    /*  This part of the game will control the rendering of the game (mainly UI for this one) and
        notifying the controller when things happen in the game (level completed, colisions, ect.)
    */

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s")) {
            app.controller.changePiece("straight");
        }

        if (Input.GetKeyDown("t")) {
            app.controller.changePiece("turn");
        }

        if (Input.GetKeyDown("4") || Input.GetKeyDown("f")) {
            app.controller.changePiece("4way");
        }

        if (Input.GetKeyDown("r")) {
            app.controller.changePiece("roundabout");
        }

        if (Input.GetMouseButtonDown(1)) { // Right click
            app.controller.changeRotation((app.model.rotation + 1) % 4); // Caps at 3 and goes back to 0 after
        }
    }
}
