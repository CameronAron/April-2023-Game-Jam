using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadButton : MonoBehaviour {
    Keypad keypad;
    TextMeshPro buttonText;

    void Start()
    {
        keypad = GetComponentInParent<Keypad>();
        buttonText = GetComponentInChildren<TextMeshPro>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Finger")) {
            keypad.InsertChar(buttonText.text);
        }
    }
}
