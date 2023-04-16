using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    private Transform spawnPoint;
    private GameObject obj;
    private float spawnX;
    private float spawnY;
    private float spawnZ;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = this.transform;
        ///obj = GetComponent<GameObject>();
        spawnX = spawnPoint.position.x;
        spawnY = spawnPoint.position.y;
        spawnZ = spawnPoint.position.z;

        //spawnPoint.position = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y <= -5)
        {
            this.transform.SetPositionAndRotation(new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("counterDrop"))
    //    {
    //        this.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);

    //        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
    //        this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    //    }
    //}

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("counterDrop")) {
            //this.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, spawnPoint.position.z);

            this.transform.SetPositionAndRotation(new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
            this.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
