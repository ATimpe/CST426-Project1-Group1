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
    public float stopDistance = 2f;
    public Vector3 destination;
    //public Animator animator;
    public bool reachedDestination;

    private Vector3 lastPosition;
    Vector3 velocity;

    private void Awake()
    {
        // set position of object to roughly the same height as waypoint (this will need to be changed later)
        //transform.position.y = 4.3f;

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
            //Vector3 forward = new Vector3(destinationDirection.x, 0, 0);
            //Vector3 up = new Vector3(0, 0, destinationDirection.z);
            destinationDirection.y = 0;
            
            float destinationDistance = destinationDirection.magnitude;

            if(destinationDistance >= stopDistance)
            {
                reachedDestination = false;
                //Quaternion targetRotation = Quaternion.LookRotation(destinationDirection);
                Quaternion targetRotation = Quaternion.LookRotation(new Vector3(destinationDirection.x, 0f, 0f), new Vector3(0f, 0f, destinationDirection.z));
                //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
                transform.LookAt(destination);
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
            }
            else
            {
                reachedDestination = true;
            }

            // this section relates to any attached animator
            velocity = (transform.position - lastPosition) / Time.deltaTime;
            velocity.y = 0; // we only want movement along a 2D plane
            var velocityMagnitude = velocity.magnitude;
            velocity = velocity.normalized;
            var fwdDotProduct = Vector3.Dot(transform.forward, velocity);
            var rightDotProduct = Vector3.Dot(transform.right, velocity);

            //animator.SetFloat("Horizontal", rightDotProduct);
            //animator.SetFloat("Forward", fwdDotProduct);
        }

        lastPosition = transform.position;
    }

    public void SetDestination(Vector3 destination)
    {
        this.destination = destination;
        reachedDestination = false;
    }
}
