using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreMenu : MonoBehaviour
{
    private int score;
    private int highscore;

    [SerializeField]
    private Text scoreVisual;
    [SerializeField]
    private Text highscoreVisual;

    [SerializeField]
    private PointSystem pointSys;

    void Start()
    {
        highscore = Random.Range(0, 20);
    }

    private void Update()
    {
        
        highscoreVisual.text = highscore.ToString();

        score = pointSys.Points;
        scoreVisual.text = score.ToString();

        if (score < highscore)
        {
          //  highscore = score;
            highscoreVisual.text = "New " + highscore.ToString();
        }
     }
    }
