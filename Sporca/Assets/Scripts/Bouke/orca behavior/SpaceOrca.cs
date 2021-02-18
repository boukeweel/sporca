using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum animationsStats
{
    idle,
    walking,
};
public class SpaceOrca : MonoBehaviour
{

    private Limitations limitations;
    private Vector3 movementRange;

    private float X;
    private float Z;

    [Header("place the minimum and the maximum of the allowed travel distance in world space for X")]
    [SerializeField] private float minXAllowed;
    [SerializeField] private float maxXAllowed;

    [Header("place the minimum and the maximum of the allowed travel distance in world space for Z")]
    [SerializeField] private float minZAllowed;
    [SerializeField] private float maxZAllowed;

    private float timeBeforeNextmovement = 0;
    private float StuckTimer;

    private Vector3 moveToPosition;

    //for lookaround
    private float TimeBeforeLookingOtherway;
    private bool changeDirection;

    //for animations
    private animationsStats animationStats = animationsStats.idle;

    //navmes
    private NavMeshAgent agent;

    private void Start()
    {
        //get out of the limitations script the vector 3 movementroom to use as the movement range
        limitations = gameObject.GetComponentInParent<Limitations>();
        movementRange = limitations.MovementRoom;

        agent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        //when it is standing still
        if(transform.position == moveToPosition || StuckTimer >= 10)
        {
            //set the time that the orca moves to a random time
            timeBeforeNextmovement -= Time.deltaTime;
            //let the object look around
            LookAround();

            animationStats = animationsStats.idle;
        }
        else
        {
            StuckTimer += Time.deltaTime;

            animationStats = animationsStats.walking;
            //if it gets the new movetoposition varibale let this move it to the location
            agent.SetDestination(moveToPosition);
        }

        //get the next posistion to move to next
        if (timeBeforeNextmovement <= 0) 
        {
            //get a random location to move to in the parameters set in the limatation script
            

            X = Random.Range(minXAllowed, maxXAllowed);
            Z = Random.Range(minZAllowed, maxZAllowed);

            moveToPosition = new Vector3(X, transform.position.y, Z);

            //random time it takes before moving
            timeBeforeNextmovement = Random.Range(4, 10);

            

            StuckTimer = 0;
        }
    }

    /// <summary>
    /// this is for looking around when the orca is standing still
    /// </summary>
    private void LookAround()
    {
        TimeBeforeLookingOtherway -= Time.deltaTime;
        if (TimeBeforeLookingOtherway <= 0)
        {
            changeDirection = !changeDirection;
            
            TimeBeforeLookingOtherway = Random.Range(1, 2);
        }

        if (changeDirection)
        {
            transform.Rotate(new Vector3(0, 0.5f, 0));
        }
        else
        {
            transform.Rotate(new Vector3(0, -0.5f, 0));
        }
    }
    /// <summary>
    /// animation manger
    /// </summary>
    private void animations()
    {
        if(animationStats == animationsStats.idle)
        {
            //play the idle animation
        }
        else if(animationStats == animationsStats.walking)
        {
            //play the walking animation
        }
    }
}
