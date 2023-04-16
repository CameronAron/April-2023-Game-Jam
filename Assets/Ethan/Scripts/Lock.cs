using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject[] lockedItem, removeObj;
    [SerializeField] bool hasSound;
    private AudioSource sound;

    private void Start() {
        if (hasSound) {
            sound = this.GetComponent<AudioSource>();
        }
    }

    private void OnTriggerEnter(Collider other) {
        if(other.GetComponent<Collider>() == key.GetComponent<Collider>()) {
            key.SetActive(false);
            if (hasSound) {
                sound.Play();
            }
            for (int i = 0; i < lockedItem.Length; i++) {
                lockedItem[i].SetActive(true);
            }
            for (int i = 0; i < removeObj.Length; i++) {
                removeObj[i].SetActive(false);
            }
        }
    }
}