using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class HumanMovement : MonoBehaviour
{
    //for animations
    private animationsStats aniState = animationsStats.idle;

    //where it can walk to
    [SerializeField]
    private Limitations limitations;
    [SerializeField]
    private Vector3 movementRestrigtions;

    //where the human needs to walk to
   [SerializeField] private Vector3 Targetpos;

    [SerializeField] private float X;
    [SerializeField] private float Z;

    private float randomMoveTime;

    private float stucktimer;
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
        if(transform.position == Targetpos || stucktimer >= 10)
        {
            randomMoveTime = Time.deltaTime;

            aniState = animationsStats.idle;
        }
        else
        {
            stucktimer += Time.deltaTime;

            aniState = animationsStats.walking;

            //agent.SetDestination(Targetpos);
        }
        if (/*randomMoveTime <= 0*/ Input.GetKeyDown(KeyCode.Space))
        {
            //get the next random target position
            float randomX;
            float randomZ;

            randomX = movementRestrigtions.x / 2;
            randomZ = movementRestrigtions.y / 2;


            X = Random.Range(transform.position.x - randomX, transform.position.x + randomX);
            Z = Random.Range(-randomZ, randomZ);

            Targetpos = new Vector3(Z + X, transform.position.y, Z);

            //random time
            randomMoveTime = Random.Range(2, 6);
        }


    }
}
