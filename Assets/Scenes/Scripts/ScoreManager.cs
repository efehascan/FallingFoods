using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;
    void Start()
    {
        
    }
    
    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }

    void AddScore(int points)
    {
        scoreCount += points;
    }
}
