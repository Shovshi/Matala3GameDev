using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Update()
    {
        // אם האויב חצה את הגבול התחתון של המסך
        if (transform.position.y < -Camera.main.orthographicSize)
        {
            Destroy(gameObject); // השמד את האויב אם הוא יצא מהמקום הרצוי
        }
    }
}
