using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;  // שדה להציג בו את הניקוד
    public int score;

    private void Start() {
        score = 0;  // התחלה עם ניקוד 0
        UpdateScore();
    }

    public void AddPoints(int pointsToAdd) {
        score += pointsToAdd;
        UpdateScore();
    }

    private void UpdateScore() {
        scoreText.text = score.ToString();
    }
}
