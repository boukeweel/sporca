using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class HumanMovement : MonoBehaviour
{
    //for animations
    private animationsStats aniState = animationsStats.idle;

    //where it can walk to
    private Limitations limitations;
    private Vector3 movementRestrigtions;

    //where the human needs to walk to
    private Vector3 Targetpos;

    private float X;
    private float Z;

    private float randomMoveTime;

    //navmesh
    private NavMeshAgent agent;
    private void Start()
    {
        //for the start set the target pos at the pos where the player spawns in
        Targetpos = transform.position;

        limitations = gameObject.GetComponentInParent<Limitations>();
        movementRestrigtions = limitations.MovementRoom;

        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (randomMoveTime <= 0)
        {
            //get the next random target position
            float randomX;
            float randomY;

            randomX = movementRestrigtions.x / 2;
            randomY = movementRestrigtions.y / 2;

            X = Random.Range(-randomX, randomX);
            Z = Random.Range(-randomY, randomY);

            Targetpos = new Vector3(X, transform.position.y, Z);

            //random time
            randomMoveTime = Random.Range(2, 6);
        }


    }
}
