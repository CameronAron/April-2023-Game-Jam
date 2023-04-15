using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressLeftButton : MonoBehaviour
{
    [SerializeField] public bool moveLeft { get; protected set; }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            Debug.Log("Pressed the left button");
            moveLeft = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Finger"))
        {
            //Debug.Log("Pressed the left button");
            moveLeft = false;
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
