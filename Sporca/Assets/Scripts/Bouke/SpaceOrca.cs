using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceOrca : MonoBehaviour
{

    private Limitations limitations;
    private Vector3 movementRange;
    
    private float X;
    private float Z;

    private void Start()
    {
        //get out of the limitations script the vector 3 movementroom to use as the movement range
        limitations = gameObject.GetComponentInParent<Limitations>();
        movementRange = limitations.MovementRoom;
    }

    private void Update()
    {
        float time = 1f;
        time -= Time.deltaTime;
        if (time <= 0)
        {
            Debug.Log("ja ik kom hier");
            float randomX;
            float randomZ;

            randomX = movementRange.x / 2;
            randomZ = movementRange.z / 2;

            X = Random.Range(-randomX, randomX);
            Z = Random.Range(-randomZ, randomZ);

            time = Random.Range(1, 10);
        }
        float step = 2 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(X,0f,Z), step);
    }
}
