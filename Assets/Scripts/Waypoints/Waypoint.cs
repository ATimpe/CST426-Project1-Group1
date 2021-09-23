using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This class defines the basic waypoint system.
 * 
 * previousWaypoint = previous waypoint relative to the current waypoint
 * nextWaypoint = next waypoint relative to the current waypoint
 * 
 * width = determines how loosely an object approaches the waypoint
 * 
 * branches = a list containing another set of waypoints, which can be branched to from any waypoint on
 *              the current track
 *              
 * branchRatio = probability of an object on the current waypoint track to access the branch upon passing it
 */
public class Waypoint : MonoBehaviour
{
    public Waypoint previousWaypoint;
    public Waypoint nextWaypoint;

    [Range(0f, 5f)]
    public float width = 1f;

    public List<Waypoint> branches = new List<Waypoint>();

    [Range(0f, 1f)]
    public float branchRatio = 0.5f;

    public Vector3 GetPosition()
    {
        //Vector3 minBound = transform.position + transform.right * width / 2f;
        //Vector3 maxBound = transform.position - transform.right * width / 2f;

        //Vector3 minBound = transform.position + transform.right;
        //Vector3 maxBound = transform.position - transform.right;

        //return Vector3.Lerp(minBound, maxBound, Random.Range(0f, 1f));
        //return Vector3.Lerp(minBound, maxBound, 1);

        // the commented lines of code above control how tightly cars turn at waypoints
        // use them if you want to change the turning radius (or introduce randomness when turning)
        return transform.position;
    }

    public Waypoint GetFirstWaypoint()
    {
        return nextWaypoint;
    }
}
