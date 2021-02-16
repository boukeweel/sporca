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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
