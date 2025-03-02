using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class Question_SO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] private string question = "Enter new question text here";
    [SerializeField] private string[] answers = new string[4];
    [SerializeField] private int correctAnswerIndex;

    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public int GetCorrctAnswerIndex()
    {
        return correctAnswerIndex;
    }
}