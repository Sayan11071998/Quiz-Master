using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private int correctAnswers = 0;
    private int questionsSeen = 0;
    private int totalQuestions = 0;

    public int GetCorrectAnswers() => correctAnswers;
    public void IncrementCorrectAnswers() => correctAnswers++;

    public int GetQuestionSeen() => questionsSeen;
    public void IncrementQuestionsSeen() => questionsSeen++;

    public void SetTotalQuestions(int total) => totalQuestions = total;

    public int CalculateScore() => correctAnswers * 10;
    public int CalculateTotalScore() => totalQuestions * 10;
}