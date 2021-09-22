using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUIView : GameView
{
    //we need the gameObject that was selected
    public GameObject selectedObject;
    
    //user clicks on rotate right button
    public void clickedRotateRight()
    {
        app.controller.onRotateRight(selectedObject);
    }

    //user clicks on rotate left button
    public void clickedRotateLeft()
    {
        app.controller.onRotateLeft(selectedObject);
    }

    
}
