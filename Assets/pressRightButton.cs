using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressRightButton : MonoBehaviour
{
    [SerializeField] public bool moveRight { get; protected set; }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            Debug.Log("Pressed the right button");
            moveRight = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            //Debug.Log("Pressed the left button");
            moveRight = false;
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
