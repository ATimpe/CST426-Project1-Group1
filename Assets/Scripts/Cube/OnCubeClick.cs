using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCubeClick : MonoBehaviour
{


    //Original code
    public GameObject myPrefab;

    public GameObject thisObject;

    private GameObject oldUI;

    private UIScript uiScript;

    private Vector3 originalPosition;

    //When you click the cube, create the UI
    void OnMouseDown()
    {
        //unnecessary
        thisObject = gameObject;

        //find any existing UI and delete it.
        oldUI = GameObject.FindWithTag("UI");
        Destroy(oldUI);

        //grab the position of the cube
        originalPosition = thisObject.transform.position;
            

        //Create the UI
        Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);


        //find the UI through its script
        uiScript = GameObject.FindObjectOfType<UIScript>();

        //send the clicked on gameObject to the UIScript, as well as the cube's location
        uiScript.GetGameObject(thisObject, originalPosition);
    }
}
