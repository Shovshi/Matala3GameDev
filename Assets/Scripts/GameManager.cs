using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  // לשמירה על הניקוד בין סצנות

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] private TextMeshProUGUI scoreText; // הפניה לטקסט שמציג את הניקוד
    private int score = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
         SceneManager.sceneLoaded += OnSceneLoaded; // מאזין לטעינת סצנה
    }

     private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // חיפוש מחדש של טקסט הניקוד בכל סצנה
        scoreText = GameObject.FindWithTag("ScoreText")?.GetComponent<TextMeshProUGUI>();

        // איפוס ניקוד אם הסצנה היא "Level1"
        if (scene.name == "Level1")
        {
            ResetScore();
        }

        UpdateScoreText(); // עדכון הטקסט אחרי טעינה
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int score)
    {
        score = score;
    }
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("ScoreText is not assigned in GameManager!");
        }
    }
       // פונקציה לשמירה על הניקוד
    public void SaveScore()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.Save();
    }

    // פונקציה לטעינת הניקוד
    private void LoadScore()
    {
        if (PlayerPrefs.HasKey("score"))
        {
            score = PlayerPrefs.GetInt("score");
            UpdateScoreText();
        }
    }

    // פונקציה שמבצעת מעבר לשלב הבא ושומרת את הניקוד
    public void LoadNextLevel(string sceneName)
    {
        SaveScore();  // שמירת הניקוד לפני המעבר לשלב הבא
        SceneManager.LoadScene(sceneName);  // מעבר לשלב
    }

    // פונקציה שמבצעת איפוס של הניקוד
    public void ResetScore()
    {
        score = 0;  // מאפס את הניקוד
        PlayerPrefs.DeleteKey("score"); // מוחק את הניקוד השמור
        UpdateScoreText();  // מעדכן את הטקסט
    }

   public void RestartGame()
    {
        ResetScore(); // מאפס את הניקוד
        SceneManager.LoadScene("Level1"); // טוען מחדש את השלב הראשון
    }
}
