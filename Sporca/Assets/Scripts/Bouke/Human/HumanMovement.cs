using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class HumanMovement : MonoBehaviour
{
    //for animations
    private animationsStats aniState = animationsStats.idle;

    //where it can walk to
    

    //where the human needs to walk to
     private Vector3 Targetpos;

     private float X;
     private float Z;

    [Header("place the minimum and the maximum of the allowed travel distance in world space for X")]
    [SerializeField] private float minXAllowed;
    [SerializeField] private float maxXAllowed;

    [Header("place the minimum and the maximum of the allowed travel distance in world space for Z")]
    [SerializeField] private float minZAllowed;
    [SerializeField] private float maxZAllowed;

     private float randomMoveTime;

     private float stucktimer;
    //navmesh
    private NavMeshAgent agent;

     
    private void Start()
    {
        //for the start set the target pos at the pos where the player spawns in
        Targetpos = transform.position;

        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if(transform.position == Targetpos || stucktimer >= 20)
        {
            randomMoveTime -= Time.deltaTime;

            aniState = animationsStats.idle;
        }
        else
        {
            stucktimer += Time.deltaTime;

            aniState = animationsStats.walking;

            agent.SetDestination(Targetpos);
        }
        if (randomMoveTime <= 0)
        {

            X = Random.Range(minXAllowed, maxXAllowed);
            Z = Random.Range(minZAllowed, maxZAllowed);

            Targetpos = new Vector3(X, transform.position.y, Z);

            //random time
            randomMoveTime = Random.Range(2, 6);

            stucktimer = 0;
        }


    }
}
