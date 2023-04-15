using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressStartButton : MonoBehaviour
{
    [SerializeField] public bool GameStarted { get; protected set; }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");

        if (other.CompareTag("Finger"))
        {
            Debug.Log("Pressed the start button");
            GameStarted = true;
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
