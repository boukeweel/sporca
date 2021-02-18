using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limitations : MonoBehaviour
{

    public Vector3 MovementRoom;

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, MovementRoom);
    }
   
}
