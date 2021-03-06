using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : CubeElement
{
    // Start is called before the first frame update
    void Start()
    {
        // Sets the current type of cube the player is placing and writes the value into the model
        app.model.roadType = FindObjectOfType<GameApplication>().GetComponent<GameApplication>().controller.app.model.currentPiece;
        app.model.rotation = FindObjectOfType<GameApplication>().GetComponent<GameApplication>().controller.app.model.rotation;
        
        //adds a waypoint on creation
        app.controller.SetWaypoint(Resources.Load<GameObject>("Waypoint/Waypoint").GetComponent<Waypoint>());
        Debug.Log("New road type " + app.model.roadType + " at rotation " + app.model.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public Waypoint GetWaypoint()
    {
        return app.model.waypoint;
    }
    public void SetWaypoint(Waypoint otherWaypoint)
    {
        app.model.waypoint = otherWaypoint;
    }
}
