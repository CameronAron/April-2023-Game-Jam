using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressLeftButton : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            Debug.Log("Pressed the left button");
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
