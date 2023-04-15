using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject[] lockedItem, removeObj;

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>() == key.GetComponent<Collider>()) {
            key.SetActive(false);
            for (int i = 0; i < lockedItem.Length; i++) {
                lockedItem[i].SetActive(true);
            }
            for (int i = 0; i < removeObj.Length; i++) {
                removeObj[i].SetActive(false);
            }
        }
    }
}