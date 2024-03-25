using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // This ensures that the GameManager persists between scene changes

        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("Score: " + score); // Optionally, you can print the score for debugging
    }
     public int GetScore()
    {
       return score; // Optionally, you can print the score for debugging
    }
}
