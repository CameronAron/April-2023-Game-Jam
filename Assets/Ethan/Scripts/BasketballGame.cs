using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BasketballGame : MonoBehaviour {
    [SerializeField] GameObject ball;
    [SerializeField] GameObject tickets;
    private int basketsMade;
    private TextMeshPro text;

    private void Start() {
        basketsMade = 0;
        text = GetComponentInChildren<TextMeshPro>();
        text.color = Color.red;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<Collider>() == ball.GetComponent<Collider>()) {
            basketsMade++;
            text.text = $"{basketsMade}";
            if(basketsMade == 3) {
                tickets.SetActive(true);
                text.color = Color.green;
            }
        }

    }
}