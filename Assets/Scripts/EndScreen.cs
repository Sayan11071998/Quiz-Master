using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScoreText;
    private ScoreKeeper scoreKeeper;

    void Awake() => scoreKeeper = FindObjectOfType<ScoreKeeper>();

    public void ShowFinalScore()
    {
        int obtainedScore = scoreKeeper.CalculateScore();
        int maxScore = scoreKeeper.CalculateTotalScore();
        finalScoreText.text = "Congratulations!\nYou got a score of " + obtainedScore + " / " + maxScore;
    }
}