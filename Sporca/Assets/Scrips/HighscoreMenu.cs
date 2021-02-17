using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreMenu : MonoBehaviour
{
    private int score;
    [SerializeField]
    private Transform spawnPos;
    [SerializeField]
    private Text scoreVisual;
    [SerializeField]
    private PointSystem pointSys;

    private void Start()
    {
        score = pointSys.Points;
        scoreVisual.text = score.ToString();
     }
    }
