using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

/*
 * This class defines the behavior of objects while following a series of waypoints.
 * 
 * float movementSpeed = movement speed of the object as it travels between waypoints
 * float rotationSpeed = rotation speed of the object as it rotates toward current next waypoint
 * float stopDistance = the distance from the final waypoint that the object will stop at
 * float startingHeight = the starting y position of all cars (change as needed)
 * 
 * Vector3 destination = a vector representing the current waypoint the object is moving toward
 * bool reachedDestination = boolean that signifies whether the object has reached its current waypoint
 * Vector3 lastPosition = a vector representing the last position of an object (where it presently is)
 * Vector3 velocity = used by animator if one exists
 */
public class CharacterNavigationController : MonoBehaviour
{
    public float movementSpeed = 1;
    public float rotationSpeed = 120;
    public float stopDistance = 0f;
    public float startingHeight = 4.3f;

    public Vector3 destination;
    //public Animator animator;
    public bool reachedDestination;

    private Vector3 lastPosition;
    Vector3 velocity;

    private void Awake()
    {
        // set position of object to roughly the same height as waypoint (this will need to be changed later)
        transform.position = new Vector3(transform.position.x, startingHeight, transform.position.z);

        // uncomment the following line of code if you want every car to start with a random speed
        //movementSpeed = Random.Range(0.8f, 2f);

        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != destination)
        {
            // this represents a vector pointing from object's current position toward current waypoint
            Vector3 destinationDirection = destination - transform.position;

            float destinationDistance = destinationDirection.magnitude;

            if(destinationDistance >= stopDistance)
            {
                // here we change the quaternion of the gameobject so that it faces its next destination as it's moving
                reachedDestination = false;
                Quaternion targetRotation = Quaternion.LookRotation(destinationDirection);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            }
            else
            {
                reachedDestination = true;
            }

            // this section relates to any attached animator
            velocity = (transform.position - lastPosition) / Time.deltaTime;
            velocity.y = 0;
            var velocityMagnitude = velocity.magnitude;
            velocity = velocity.normalized;
            var fwdDotProduct = Vector3.Dot(transform.forward, velocity);
            var rightDotProduct = Vector3.Dot(transform.right, velocity);

            //animator.SetFloat("Horizontal", rightDotProduct);
            //animator.SetFloat("Forward", fwdDotProduct);
        }

        lastPosition = transform.position;
    }

    // this function is called by WaypointNavigator to reset the destination of a car every time it reaches its current waypoint
    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }
}
