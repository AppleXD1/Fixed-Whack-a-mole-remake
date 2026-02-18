using UnityEngine;
using TMPro;

public class EndScreenUI : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;

    void Start()
    {
        finalScoreText.text = "Final Score: " + ScoreKeeper.finalScore;
    }
}