using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressStartButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            Debug.Log("Pressed the start button");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
