using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 무기 : MonoBehaviour
{
    public static int basicprice;
    public static int host = 0;
    public static int host2 = 0;
    public static int host3 = 0;
    public static int host4 = 0;
    public static int house = 0;
    public static int house2 = 0;
    public static int house3 = 0;
    public static int house4 = 0;
    public static int weapon1 = 0;
    public static int weapon2 = 0;
    public static int weapon3 = 0;
    public static int weapon4 = 0;
    void Start()
    {
        basicprice = 100;
    }

    public void okbutton()
    {
        GameObject 그린깃발1 = GameObject.Find("청동검깃발").transform.Find("그린깃발").gameObject;
        GameObject 레드깃발1 = GameObject.Find("청동검깃발").transform.Find("레드깃발").gameObject;
        GameObject 노란깃발1 = GameObject.Find("청동검깃발").transform.Find("노란깃발").gameObject;
        GameObject 파란깃발1 = GameObject.Find("청동검깃발").transform.Find("파란깃발").gameObject;
        GameObject 그린깃발2 = GameObject.Find("칠지도깃발").transform.Find("그린깃발").gameObject;
        GameObject 레드깃발2 = GameObject.Find("칠지도깃발").transform.Find("레드깃발").gameObject;
        GameObject 노란깃발2 = GameObject.Find("칠지도깃발").transform.Find("노란깃발").gameObject;
        GameObject 파란깃발2 = GameObject.Find("칠지도깃발").transform.Find("파란깃발").gameObject;
        GameObject 그린깃발3 = GameObject.Find("신기전깃발").transform.Find("그린깃발").gameObject;
        GameObject 레드깃발3 = GameObject.Find("신기전깃발").transform.Find("레드깃발").gameObject;
        GameObject 노란깃발3 = GameObject.Find("신기전깃발").transform.Find("노란깃발").gameObject;
        GameObject 파란깃발3 = GameObject.Find("신기전깃발").transform.Find("파란깃발").gameObject;
        GameObject 그린깃발4 = GameObject.Find("천궁깃발").transform.Find("그린깃발").gameObject;
        GameObject 레드깃발4 = GameObject.Find("천궁깃발").transform.Find("레드깃발").gameObject;
        GameObject 노란깃발4 = GameObject.Find("천궁깃발").transform.Find("노란깃발").gameObject;
        GameObject 파란깃발4 = GameObject.Find("천궁깃발").transform.Find("파란깃발").gameObject;
        GameObject 승리 = GameObject.Find("UI모음").transform.Find("승리").gameObject;


        if (DiceScript.order == 2)
        {
            if (house == 0 && GameManager.distance % 40 == 5)
            {
                player1.money -= basicprice;
                house = 1;
                host = 1;
                weapon1++;
                그린깃발1.SetActive(true);
            }
            else if (house2 == 0 && GameManager.distance % 40 == 15)
            {
                player1.money -= basicprice;
                house2 = 1;
                host2 = 1;
                weapon1++;
                그린깃발2.SetActive(true);
            }
            else if (house3 == 0 && GameManager.distance % 40 == 25)
            {
                player1.money -= basicprice;
                house3 = 1;
                host3 = 1;
                weapon1++;
                그린깃발3.SetActive(true);
            }
            else if (house4 == 0 && GameManager.distance % 40 == 35)
            {
                player1.money -= basicprice;
                house4 = 1;
                host4 = 1;
                weapon1++;
                그린깃발4.SetActive(true);
            }
            else if (house == 1 && host == 1 && GameManager.distance % 40 == 5) {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house2 == 1 && host2 == 1 && GameManager.distance % 40 == 15)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house3 == 1 && host3 == 1 && GameManager.distance % 40 == 25)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house4 == 1 && host4 == 1 && GameManager.distance % 40 == 35)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            if(weapon1 == 4)
            {
                승리.SetActive(true);
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 3)
        {
            if (house == 0 && GameManager.distance2 % 40 == 5)
            {
                player2.money -= basicprice;
                house = 1;
                host = 2;
                weapon2++;
                레드깃발1.SetActive(true);
            }
            else if (house2 == 0 && GameManager.distance2 % 40 == 15)
            {
                player1.money -= basicprice;
                house2 = 1;
                host2 = 2;
                weapon2++;
                레드깃발2.SetActive(true);
            }
            else if (house3 == 0 && GameManager.distance2 % 40 == 25)
            {
                player1.money -= basicprice;
                house3 = 1;
                host3 = 2;
                weapon2++;
                레드깃발3.SetActive(true);
            }
            else if (house4 == 0 && GameManager.distance2 % 40 == 35)
            {
                player1.money -= basicprice;
                house4 = 1;
                host4 = 1;
                weapon2++;
                레드깃발4.SetActive(true);
            }
            else if (house == 1 && host == 2 && GameManager.distance2 % 40 == 5)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house2 == 1 && host2 == 2 && GameManager.distance2 % 40== 15)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house3 == 1 && host3 == 2 && GameManager.distance2 % 40== 25)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house4 == 1 && host4 == 2 && GameManager.distance2 % 40 == 35)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            if (weapon2 == 4)
            {
                승리.SetActive(true);
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 4)
        {
            if (house == 0 && GameManager.distance3 % 40 == 5)
            {
                player3.money -= basicprice;
                house = 1;
                host = 3;
                weapon3++;
                노란깃발1.SetActive(true);
            }
            else if (house2 == 0 && GameManager.distance3 % 40 == 15)
            {
                player3.money -= basicprice;
                house2 = 1;
                host2 = 3;
                weapon3++;
                노란깃발2.SetActive(true);
            }
            else if (house3 == 0 && GameManager.distance3 % 40 == 25)
            {
                player3.money -= basicprice;
                house3 = 1;
                host3 = 3;
                weapon3++;
                노란깃발3.SetActive(true);
            }
            else if (house4 == 0 && GameManager.distance3 % 40 == 35)
            {
                player3.money -= basicprice;
                house4 = 1;
                host4 = 3;
                weapon3++;
                노란깃발4.SetActive(true);
            }
            else if (house == 1 && host == 3 && GameManager.distance3 % 40 == 5)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house2 == 1 && host2 == 3 && GameManager.distance3 % 40 == 15)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house3 == 1 && host3 == 3 && GameManager.distance3 % 40 == 25)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house4 == 1 && host4 == 3 && GameManager.distance3 % 40 == 35)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            if (weapon3 == 4)
            {
                승리.SetActive(true);
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        if (DiceScript.order == 1)
        {
            if (house == 0 && GameManager.distance4 % 40 == 5)
            {
                player4.money -= basicprice;
                house = 1;
                host = 4;
                weapon4++;
                파란깃발1.SetActive(true);
            }
            else if (house2 == 0 && GameManager.distance4 % 40 == 15)
            {
                player4.money -= basicprice;
                house2 = 1;
                host2 = 4;
                weapon4++;
                파란깃발2.SetActive(true);
            }
            else if (house3 == 0 && GameManager.distance4 % 40 == 25)
            {
                player4.money -= basicprice;
                house3 = 1;
                host3 = 4;
                weapon4++;
                파란깃발3.SetActive(true);
            }
            else if (house4 == 0 && GameManager.distance4 % 40 == 35)
            {
                player4.money -= basicprice;
                house4 = 1;
                host4 = 4;
                weapon4++;
                파란깃발4.SetActive(true);
            }
            else if (house == 1 && host == 4 && GameManager.distance4 % 40 == 5)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house2 == 1 && host2 == 4 && GameManager.distance4 % 40 == 15)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house3 == 1 && host3 == 4 && GameManager.distance4 % 40 == 25)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            else if (house4 == 1 && host4 == 4 && GameManager.distance4 % 40 == 35)
            {
                Debug.Log("이미 획득한 무기입니다.");
            }
            if (weapon4 == 4)
            {
                승리.SetActive(true);
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }

    }
}
