using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{

    private float time = 1f;
    private int points;
    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            points++;
            time = 1f;
            Debug.Log(points);
        }

    }
}
