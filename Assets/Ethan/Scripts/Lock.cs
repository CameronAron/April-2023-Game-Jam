using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] Collider key;
    [SerializeField] GameObject LockedItem;

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>() == key) {
            LockedItem.SetActive(true);
        }
    }
}
