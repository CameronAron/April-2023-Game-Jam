using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressRightButton : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            Debug.Log("Pressed the right button");
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
