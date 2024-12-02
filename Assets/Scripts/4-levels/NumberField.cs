using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshProUGUI object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TextMeshProUGUI))]
public class NumberField : MonoBehaviour {
    private int number;
    private TextMeshProUGUI textMesh;

    private void Awake() {
        // מתייחס לרכיב TextMeshProUGUI שנמצא על ה-GameObject
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    public int GetNumber() {
        return this.number;
    }

    public void SetNumber(int newNumber) {
        this.number = newNumber;
        textMesh.text = newNumber.ToString(); // עדכון הטקסט
    }

    public void AddNumber(int toAdd) {
        SetNumber(this.number + toAdd);
    }
}
