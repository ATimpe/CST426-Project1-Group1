using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCubeClick : GameView
{

    //Original code
    public GameObject myPrefab;

    public GameObject thisObject;

    public GameObject otherObject;

    private GameObject oldUI;

    private Vector3 originalPosition;

    //When you click the cube, create the UI
    void OnMouseDown()
    {
        //find if we previously clicked on a cube.
        if (GameObject.FindWithTag("ClickedObject") != null)
        {
            otherObject = GameObject.FindWithTag("ClickedObject");
            otherObject.tag="Cube";
        }

        //unnecessary
        thisObject = gameObject;

        //find any existing UI and delete it.
        oldUI = GameObject.FindWithTag("UI");
        Destroy(oldUI);

        //grab the position of the cube
        originalPosition = thisObject.transform.position;

        thisObject.tag="ClickedObject";

        //Create the UI
        Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);


        //find the UI through its script
        uiScript = GameObject.FindObjectOfType<UIScript>();

        //send the clicked on gameObject to the UIScript, as well as the cube's location
        uiScript.GetGameObject(thisObject, originalPosition);
    }
}
