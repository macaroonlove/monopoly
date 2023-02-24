using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player4 : MonoBehaviour
{
    public static int Allmoney;
    public static int money;

    void Start()
    {
        money = 1500;
        Allmoney = money;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.distance4 % 40 > 10 && GameManager.distance4 % 40 < 19)
            transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (GameManager.distance4 % 40 > 20 && GameManager.distance4 % 40 < 29)
            transform.rotation = Quaternion.Euler(0, 90, 0);
        else if (GameManager.distance4 % 40 > 30 && GameManager.distance4 % 40 < 39)
            transform.rotation = Quaternion.Euler(0, 180, 0);
        else if (GameManager.distance4 % 40 > 0 && GameManager.distance4 % 40 < 9)
            transform.rotation = Quaternion.Euler(0, -90, 0);
    }
}
