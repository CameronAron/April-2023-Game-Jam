using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BlackText : MonoBehaviour
{
    [SerializeField] TextMeshPro text;
    void Start()
    {
        text.color = Color.black;
    }

}
