using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    public int currentScore; //This is used to pass the score to the end screen

    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if (remainingTime <= 0)
        {
            remainingTime = 0;
            LoadEndScreen();
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void LoadEndScreen()
    {
        // Save the score globally before switching scenes
        ScoreKeeper.finalScore = FindFirstObjectByType<ScoreScript>().score;
        
        SceneManager.LoadScene("EndScreen"); //This loads the end screen when the timer runs out
    }
}