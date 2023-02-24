using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player3money : MonoBehaviour
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
        text.text = player3.money.ToString() + "¸¸¿ø";
        money = player3.money;
    }
}
