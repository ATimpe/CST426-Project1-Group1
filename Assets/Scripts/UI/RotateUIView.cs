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
        selectedObject = GameObject.FindWithTag("ClickedObject");
        app.controller.onRotateRight(selectedObject);
    }

    //user clicks on rotate left button
    public void clickedRotateLeft()
    {
        selectedObject = GameObject.FindWithTag("ClickedObject");
        app.controller.onRotateLeft(selectedObject);
    }

    public void clickedPlace()
    {
        selectedObject = GameObject.FindWithTag("ClickedObject");
        selectedObject.tag = "Cube";
        app.controller.onPlace(gameObject);
        Destroy(gameObject);
    }

}
