using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    private Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y <= -5)
        {
            this.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("counterDrop"))
        {
            this.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);
        }
    }
}
