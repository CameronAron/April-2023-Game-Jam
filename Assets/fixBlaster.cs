using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixBlaster : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject[] lockedItem, removeObj;

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<Collider>() == key.GetComponent<Collider>()) {
            for (int i = 0; i < lockedItem.Length; i++) {
                lockedItem[i].SetActive(true);
                lockedItem[i].transform.position = key.transform.position;
            }
            key.SetActive(false);
            for (int i = 0; i < removeObj.Length; i++) {
                removeObj[i].SetActive(false);
            }
        }
    }
}
