using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
     public TextMeshProUGUI  scoreText; // Reference to the UI Text component

    private void Update()
    {
        // Get the current score from the GameManager
        int score = GameManager.Instance.GetScore();
        // Update the text to display the score
        scoreText.text = "Score: " + score.ToString();
       
    }
}
