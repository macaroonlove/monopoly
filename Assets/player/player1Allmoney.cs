using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1Allmoney : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player1.Allmoney.ToString() + "����";
    }
}
