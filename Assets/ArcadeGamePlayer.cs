using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeGamePlayer : MonoBehaviour
{
    [SerializeField] pressLeftButton leftScript;
    [SerializeField] pressRightButton rightScript;

    [SerializeField] float points = 0f;

    [SerializeField] GameObject WinScreen;

    //[SerializeField] Transform basketTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (leftScript.moveLeft)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            //GetComponent<Rigidbody>().AddForce(0f, 0f, -.1f, ForceMode.Force);
        }

        //if(!leftScript.moveLeft && !rightScript.moveRight)
        //{
        //    GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        //}

        if (rightScript.moveRight)
        {
            transform.Translate(Vector3.back * Time.deltaTime);
            //GetComponent<Rigidbody>().AddForce(0f, 0f, .1f, ForceMode.Force);
        }

        if(points >= 3f)
        {
            WinScreen.SetActive(true);
        }

        if(transform.localPosition.z < -.5f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, -.9f);
        }

        if (transform.localPosition.z > .5f)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, .9f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fruit"))
        {
            points += 1f;
        }
    }

}
