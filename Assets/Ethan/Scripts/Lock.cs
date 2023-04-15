using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject lockedItem;

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>() == key.GetComponent<Collider>()) {
            lockedItem.SetActive(true);
            key.SetActive(false);
        }
    }
}