using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointNavigator : MonoBehaviour
{
    CharacterNavigationController controller;
    public Waypoint currentWaypoint;
    float direction;

    private void Awake()
    {
        controller = GetComponent<CharacterNavigationController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // the following line was previously used to have cars start pointing to next or previous waypoint randomly
        //direction = Mathf.RoundToInt(Random.Range(0f, 1f));

        // make all cars start facing toward the next waypoint
        direction = 0;

        controller.SetDestination(currentWaypoint.GetPosition());
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.reachedDestination)
        {
            bool shouldBranch = false;

            if(currentWaypoint.branches != null && currentWaypoint.branches.Count > 0)
            {
                shouldBranch = Random.Range(0f, 1f) <= currentWaypoint.branchRatio ? true : false;
            }

            if(shouldBranch)
            {
                currentWaypoint = currentWaypoint.branches[Random.Range(0, currentWaypoint.branches.Count - 1)];
            }
            else
            {
                if (direction == 0)
                {
                    if(currentWaypoint.nextWaypoint != null)
                    {
                        currentWaypoint = currentWaypoint.nextWaypoint;
                    }
                    else
                    {
                        //currentWaypoint = currentWaypoint.previousWaypoint;
                        //direction = 1;

                        // despawn cars once they reach the final waypoint
                        Destroy(controller.gameObject);
                    }
                }
                else if (direction == 1)
                {
                    if (currentWaypoint.previousWaypoint != null)
                    {
                        currentWaypoint = currentWaypoint.previousWaypoint;
                    }
                    else
                    {
                        currentWaypoint = currentWaypoint.nextWaypoint;
                        direction = 0;
                    }
                }
            }
            
            
            controller.SetDestination(currentWaypoint.GetPosition());
        }
    }
}
