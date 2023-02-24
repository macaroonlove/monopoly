using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 재난카드3 : MonoBehaviour
{
    public static int basicprice;
    void Start()
    {
        basicprice = 150;
    }

    // Update is called once per frame
    void Update()
    {
        //player2가 밟았을 경우

    }

    public void okbutton()
    {
        //player 1이 주인일 경우
        if (DiceScript.order == 2)
        {
            player1.money -= basicprice;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 3)
        {
            player2.money -= basicprice;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 4)
        {
            player3.money -= basicprice;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 1)
        {
            player4.money -= basicprice;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
    }
}
