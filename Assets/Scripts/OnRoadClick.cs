using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRoadClick : MonoBehaviour
{
    
    private GameObject otherObject;

    private GameObject oldUI;

    private GameObject newUI;

    private Vector3 originalPosition;

    //When you click the road, create the UI
    void OnMouseDown()
    {
        //find if we previously clicked on a road.
        if (GameObject.FindWithTag("ClickedObject") != null)
        {
            otherObject = GameObject.FindWithTag("ClickedObject");
            otherObject.tag="Road";
        }

        //find any existing UI and delete it.
        oldUI = GameObject.FindWithTag("UI");
        Destroy(oldUI);


        //make this road the click on road
        gameObject.tag="ClickedObject";

        //Load the ui from Resources
        newUI = Resources.Load<GameObject>("UI/RotateUI");

        //Create the UI
        Instantiate(newUI, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
