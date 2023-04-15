using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    [SerializeField] GameObject lockedItem;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Bullet")) {
            lockedItem.SetActive(true);
        }
    }
}