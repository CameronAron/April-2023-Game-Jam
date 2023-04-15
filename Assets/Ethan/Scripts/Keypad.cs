using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    [SerializeField] TextMeshPro text;
    [SerializeField] TMP_InputField inputField;
    [SerializeField] string code = "8 7 6 4 ";
    private bool canType;

    private void Start() {
        inputField.text = "_ _ _ _";
        text.color = Color.white;
        canType = true;
    }

    private void Update() {
        if (inputField.text.Length == 8) {
            if (inputField.text == code) {
                Debug.Log("Code Correct");
                canType = false;
                text.color = Color.green;
            }
            else {
                inputField.text = "_ _ _ _";
            }
        }
    }

    public void InsertChar(string c) {
        if (canType) {
            if (inputField.text.Length == 7) {
                inputField.text = "";
            }
            inputField.text += (c + " ");
        } 
    }
}
