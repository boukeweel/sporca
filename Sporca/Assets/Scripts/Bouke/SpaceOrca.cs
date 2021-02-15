using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOrca : MonoBehaviour
{
    public Vector3 MovementRoom;

    
    private float X;
    private float Z;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, MovementRoom);
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float randomX;
            float randomZ;

            randomX = MovementRoom.x / 2;
            randomZ = MovementRoom.y / 2;

            X = Random.Range(-randomX, randomX);
            Z = Random.Range(-randomZ, randomZ);

            transform.Translate(new Vector3(X, 0f, Z) * Time.deltaTime);
        }
    }
}
