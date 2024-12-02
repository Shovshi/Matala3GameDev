using UnityEngine;
using TMPro;  // נוסיף את TextMeshPro כדי להציג את הניקוד

/**
 * This component reads the player score from the GameManager and displays it on the screen.
 */
public class GameStatusReader : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>(); // תוודא שיש לך TextMeshProUGUI מחובר
        if (scoreText != null)
        {
            scoreText.text = "Score: " + GameManager.Instance.GetScore();
        }
        else
        {
            Debug.LogError("TextMeshProUGUI not found on GameStatusReader!");
        }
    }
}
