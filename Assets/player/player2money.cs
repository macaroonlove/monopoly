using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2money : MonoBehaviour
{
    Text text;
    public static int money;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player2.money.ToString() + "¸¸¿ø";
        money = player2.money;
    }
}
