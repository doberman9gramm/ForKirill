using UnityEngine;
using TMPro;
public class ScoreView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        ScoreSystem.OnScoreChanged += UpdateScoreText;
    }

    private void OnDisable()
    {
        ScoreSystem.OnScoreChanged -= UpdateScoreText;
    }

    private void UpdateScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }
}