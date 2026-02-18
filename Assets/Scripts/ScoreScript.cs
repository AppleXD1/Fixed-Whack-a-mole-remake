using UnityEngine;
using TMPro;

public class ScoreScript : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText; //Drag UI text here
    
    

    public void AddPoint()
    {
        
            score++;
            UpdateScoreUI();
       
        
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    
}