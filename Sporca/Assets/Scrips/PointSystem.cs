using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{

    private float time = 1f;
    private int points;
    private int finalPoints;
    private bool pause = false;
    public bool Pause
    {
        get { return pause; }
        set { pause = value; }
    }

    [SerializeField]
    private Text pointText;
    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    public int FinalPoints
    {
        get { return finalPoints; }
        set { finalPoints = value; }
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause)
        {
            time -= Time.deltaTime;
        }

        if (time <= 0)
        {
            points++;
            time = 1f;
        }

        pointText.text = points.ToString();

    }
}
