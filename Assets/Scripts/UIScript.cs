using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{

    /*
        To use, download TextMeshPro from,
        Window->TextMeshPro->Import TMP Essential Resources.

        Make a UI object under:
        GameObject->UI->Button - (TextMeshPro)
        
        Add this script to the "Canvas" object
        Under "Canvas there is "Button"
        Rename the button to "MakeMyPrefab"

        On the Component tab of "MakeMyPrefab", there is a "Button" component.
        At the bottom of that component there is an onClick section.
        
        Click on the "+" symbol to make a new onClick method.
        On the bottom of the new thing that was made in OnClick, there is a small section with "None (Object)".
        Click and drag "Canvas" into that section.
        In the "NoFunction" dropdown menu: do the following: UIScript->OnMakeMyPrefab()

        You will need to make a prefab to put into the script "myPrefab"

        The UI should show up and make a blue cube right now, and delete itself        
    */

    //get the cube we clicked on and assign to this variable
    //not implemented!!
    public GameObject myGameObject;

    public GameObject myPrefab;

    public GameObject redCube;

    private Vector3 cubeLocation;

    //upon clicking on MakeMyPrefab button
    public void OnMakeMyPrefab()
    {   
        //destroy the original object
        //Not implemented!!
        Destroy(myGameObject);

        //make the myPrefab
        Instantiate(myPrefab, cubeLocation, Quaternion.identity);

        //destroy the ui
        Destroy(gameObject);
    }

    public void MakeRedCube()
    {
        Destroy(myGameObject);

        //make redcube
        Instantiate(redCube, cubeLocation, Quaternion.identity);

        //destroy the ui
        Destroy(gameObject);
    }

    public void GetGameObject(GameObject newGameObject, Vector3 position)
    {
        myGameObject = newGameObject;
        cubeLocation = position;
    }
}
