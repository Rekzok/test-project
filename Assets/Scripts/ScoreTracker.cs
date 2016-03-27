using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreTracker : MonoBehaviour
{
    //initializes required variables
    private float score;
    Text scoreText;

    //sets scoreText object to the script's GameObject
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

	void Update ()
    {
        //increments score with the time elapsed in seconds
        score += Time.deltaTime;

        //outputs score rounded to the first decimal place
        scoreText.text = Math.Round(score, 1).ToString("0.0");
	}
}
