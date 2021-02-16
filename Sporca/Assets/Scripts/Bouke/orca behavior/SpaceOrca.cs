using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOrca : MonoBehaviour
{

    private Limitations limitations;
    private Vector3 movementRange;

    private float X;
    private float Z;

    private float timeBeforeNextmovement = 1;
    [SerializeField]
    private float speed = 2;

    private float minSpeed;
    private float maxSpeed;
    
    private Vector3 moveToPosition;

    private void Start()
    {
        //get out of the limitations script the vector 3 movementroom to use as the movement range
        limitations = gameObject.GetComponentInParent<Limitations>();
        movementRange = limitations.MovementRoom;
    }

    private void Update()
    {
        
        
        if(transform.position == moveToPosition)
        {
            //set the time that the orca moves to a random time
            timeBeforeNextmovement -= Time.deltaTime;
        }
        
        if (timeBeforeNextmovement <= 0)
        {
            //get a random location to move to in the parameters set in the limatation script
            float randomX;
            float randomZ;

            randomX = movementRange.x / 2;
            randomZ = movementRange.z / 2;

            X = Random.Range(-randomX, randomX);
            Z = Random.Range(-randomZ, randomZ);

            moveToPosition = new Vector3(X, 0f, Z);

            //random time it takes before moving
            timeBeforeNextmovement = Random.Range(1, 10);

            //random speed the animal wil move with the varibale minSpeed and maxSpeed
            speed = Random.Range(minSpeed, maxSpeed);
        }
        
        float step = speed * Time.deltaTime;
        //if it gets the new movetoposition varibale let this move it to the location
        transform.position = Vector3.MoveTowards(transform.position, moveToPosition, step);
    }
}
