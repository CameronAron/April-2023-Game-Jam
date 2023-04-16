using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketballGame : MonoBehaviour {
    [SerializeField] GameObject tickets;
    private int basketsMade;
    private TextMeshPro text;

    private void Start() {
        basketsMade = 0;
        text = GetComponentInChildren<TextMeshPro>();
        text.color = Color.red;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball")) {
            basketsMade++;
            text.text = $"{basketsMade}";
            if(basketsMade == 3) {
                tickets.SetActive(true);
                text.color = Color.green;
            }
        }

    }
}