using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 타임머신 : MonoBehaviour
{
    public static int timemove;
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
        timemove = Random.Range(1, 40);
        //player 1이 주인일 경우
        if (DiceScript.order == 2)
        {
            Stone.timepermission = true;
            Stone.playermove = true;

            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 3)
        {
            Stone2.timepermission = true;
            Stone2.playermove = true;

            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 4)
        {
            Stone3.timepermission = true;
            Stone3.playermove = true;

            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 1)
        {
            Stone4.timepermission = true;
            Stone4.playermove = true;

            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
    }
}
