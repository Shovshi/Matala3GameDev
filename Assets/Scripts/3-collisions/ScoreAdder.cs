using UnityEngine;

/**
 * This component increases the game score via GameManager whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger adding score.")]
    [SerializeField] public string triggeringTag; // התג שמפעיל את הניקוד
    [SerializeField] int pointsToAdd; // מספר הנקודות להוספה

    private void OnTriggerEnter2D(Collider2D other)
    {
        // בדיקה אם האובייקט המתנגש מתאים לתג שהוגדר
        if (other.tag == triggeringTag)
        {
            // הוספת נקודות ל-GameManager
            if (GameManager.Instance != null)
            {
                GameManager.Instance.AddScore(pointsToAdd);
            }
            else
            {
                Debug.LogError("GameManager not found in the scene!");
            }

            // השמדת האויב (אופציונלי)
            Destroy(other.gameObject);
        }
    }

    public ScoreAdder SetPointsToAdd(int newPointsToAdd)
    {
        this.pointsToAdd = newPointsToAdd;
        return this;
    }
}
