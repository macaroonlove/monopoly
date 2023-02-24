using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 찬스4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void okbutton()
    {
        //player 1이 주인일 경우
        if (DiceScript.order == 2)
        {
            player1.money -= 150;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 3)
        {
            player2.money -= 150;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 4)
        {
            player3.money -= 150;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 1)
        {
            player4.money -= 150;
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
    }
}
