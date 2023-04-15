using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HightScaler : MonoBehaviour
{
    [SerializeField] float scaleValue = -.17f;

    private void Update()
    {
        this.transform.localPosition = new Vector3(0, scaleValue, 0);
    }
}
