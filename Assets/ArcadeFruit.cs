using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeFruit : MonoBehaviour
{
    private float counter = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(.33f, 0, 0);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (counter > 7f)
        {
            Destroy(gameObject);
        }
    }
}
