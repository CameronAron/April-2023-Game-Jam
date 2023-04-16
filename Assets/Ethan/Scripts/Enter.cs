using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour
{
    [SerializeField] string nextScene = "Arcade";

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Finger")) {
            SceneManager.LoadScene(nextScene);
        }
    }
}
