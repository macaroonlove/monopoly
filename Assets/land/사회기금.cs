using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 사회기금 : MonoBehaviour
{
    public static int basicprice;
    int lotto;
    public static int bank = 0;
    void Start()
    {
        basicprice = 50;
    }

    // Update is called once per frame
    void Update()
    {
        //player2가 밟았을 경우
        
    }

    public void okbutton()
    {
        lotto = Random.Range(1, 101);
        //player 1이 주인일 경우
        if (DiceScript.order == 2)
        {
            if (lotto > 84)
            {
                player1.money += bank;
                player1.Allmoney += bank;
                bank = 0;
            }
            else
            {
                player1.money -= 100;
                bank += 100;
            }
            
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 3)
        {
            if (lotto > 84)
            {
                player2.money += bank;
                player2.Allmoney += bank;
                bank = 0;
            }
            else
            {
                player2.money -= 100;
                bank += 100;
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 4)
        {
            if (lotto > 84)
            {
                player3.money += bank;
                player3.Allmoney += bank;
                bank = 0;
            }
            else
            {
                player3.money -= 100;
                bank += 100;
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 1)
        {
            if (lotto > 84)
            {
                player4.money += bank;
                player4.Allmoney += bank;
                bank = 0;
            }
            else
            {
                player4.money -= 100;
                bank += 100;
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
    }
}
