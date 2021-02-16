using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{

    private float time = 1f;
    private int points;

    [SerializeField]
    private Text pointText;
    public int Points
    {
        get { return points; }
        set { points = value; }
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

        pointText.text = points.ToString();

    }
}
