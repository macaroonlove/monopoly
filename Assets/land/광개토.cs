using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 광개토 : MonoBehaviour
{
    public static int basicprice;
    public static int oneprice;
    public static int twoprice;
    public static int threeprice;
    public static int landprice;
    public static int host = 0;
    public static int house = 0;
    void Start()
    {
        basicprice = 45;
        oneprice = 245;
        twoprice = 495;
        threeprice = 795;
        landprice = 2195;
    }

    // Update is called once per frame
    void Update()
    {
        //player2가 밟았을 경우

    }

    public void okbutton()
    {
        GameObject 그린깃발 = GameObject.Find("광개토건물").transform.Find("그린깃발").gameObject;
        GameObject 그린땅1 = GameObject.Find("광개토건물").transform.Find("그린땅1").gameObject;
        GameObject 그린땅2 = GameObject.Find("광개토건물").transform.Find("그린땅2").gameObject;
        GameObject 그린땅3 = GameObject.Find("광개토건물").transform.Find("그린땅3").gameObject;
        GameObject 그린랜드 = GameObject.Find("광개토건물").transform.Find("그린랜드").gameObject;
        GameObject 레드깃발 = GameObject.Find("광개토건물").transform.Find("레드깃발").gameObject;
        GameObject 레드땅1 = GameObject.Find("광개토건물").transform.Find("레드땅1").gameObject;
        GameObject 레드땅2 = GameObject.Find("광개토건물").transform.Find("레드땅2").gameObject;
        GameObject 레드땅3 = GameObject.Find("광개토건물").transform.Find("레드땅3").gameObject;
        GameObject 레드랜드 = GameObject.Find("광개토건물").transform.Find("레드랜드").gameObject;
        GameObject 노란깃발 = GameObject.Find("광개토건물").transform.Find("노란깃발").gameObject;
        GameObject 노란땅1 = GameObject.Find("광개토건물").transform.Find("노란땅1").gameObject;
        GameObject 노란땅2 = GameObject.Find("광개토건물").transform.Find("노란땅2").gameObject;
        GameObject 노란땅3 = GameObject.Find("광개토건물").transform.Find("노란땅3").gameObject;
        GameObject 노란랜드 = GameObject.Find("광개토건물").transform.Find("노란랜드").gameObject;
        GameObject 파란깃발 = GameObject.Find("광개토건물").transform.Find("파란깃발").gameObject;
        GameObject 파란땅1 = GameObject.Find("광개토건물").transform.Find("파란땅1").gameObject;
        GameObject 파란땅2 = GameObject.Find("광개토건물").transform.Find("파란땅2").gameObject;
        GameObject 파란땅3 = GameObject.Find("광개토건물").transform.Find("파란땅3").gameObject;
        GameObject 파란랜드 = GameObject.Find("광개토건물").transform.Find("파란랜드").gameObject;
        if (DiceScript.order == 2)
        {
            if (house == 0)
            {
                player1.money -= basicprice;
                house = 1;
                host = 1;
                그린깃발.SetActive(true);
            }
            else if (house == 1 && host == 1)
            {
                player1.money -= 200;
                house = 2;
                그린깃발.SetActive(false);
                그린땅1.SetActive(true);
            }
            else if (house == 2 && host == 1)
            {
                player1.money -= 200;
                house = 3;
                그린땅2.SetActive(true);
            }
            else if (house == 3 && host == 1)
            {
                player1.money -= 200;
                house = 4;
                그린땅3.SetActive(true);
            }
            else if (house == 4 && host == 1)
            {
                player1.money -= 200;
                house = 5;
                그린땅1.SetActive(false);
                그린땅2.SetActive(false);
                그린땅3.SetActive(false);
                그린랜드.SetActive(true);
            }
            else if (house == 5 && host == 1)
            {
                Debug.Log("더 이상 건물을 지을 수 없습니다.");
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 3)
        {
            if (house == 0)
            {
                player2.money -= basicprice;
                house = 1;
                host = 2;
                레드깃발.SetActive(true);
            }
            else if (house == 1 && host == 2)
            {
                player2.money -= 200;
                house = 2;
                레드깃발.SetActive(false);
                레드땅1.SetActive(true);
            }
            else if (house == 2 && host == 2)
            {
                player2.money -= 200;
                house = 3;
                레드땅2.SetActive(true);
            }
            else if (house == 3 && host == 2)
            {
                player2.money -= 200;
                house = 4;
                레드땅3.SetActive(true);
            }
            else if (house == 4 && host == 2)
            {
                player2.money -= 200;
                house = 5;
                레드땅1.SetActive(false);
                레드땅2.SetActive(false);
                레드땅3.SetActive(false);
                레드랜드.SetActive(true);
            }
            else if (house == 5 && host == 2)
            {
                Debug.Log("더 이상 건물을 지을 수 없습니다.");
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (DiceScript.order == 4)
        {
            if (house == 0)
            {
                player3.money -= basicprice;
                house = 1;
                host = 3;
                노란깃발.SetActive(true);
            }
            else if (house == 1 && host == 3)
            {
                player3.money -= 200;
                house = 2;
                노란깃발.SetActive(false);
                노란땅1.SetActive(true);
            }
            else if (house == 2 && host == 3)
            {
                player3.money -= 200;
                house = 3;
                노란땅2.SetActive(true);
            }
            else if (house == 3 && host == 3)
            {
                player3.money -= 200;
                house = 4;
                노란땅3.SetActive(true);
            }
            else if (house == 4 && host == 3)
            {
                player3.money -= 200;
                house = 5;
                노란땅1.SetActive(false);
                노란땅2.SetActive(false);
                노란땅3.SetActive(false);
                노란랜드.SetActive(true);
            }
            else if (house == 5 && host == 3)
            {
                Debug.Log("더 이상 건물을 지을 수 없습니다.");
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        if (DiceScript.order == 1)
        {
            if (house == 0)
            {
                player4.money -= basicprice;
                house = 1;
                host = 4;
                파란깃발.SetActive(true);
            }
            else if (house == 1 && host == 4)
            {
                player4.money -= 200;
                house = 2;
                파란깃발.SetActive(false);
                파란땅1.SetActive(true);
            }
            else if (house == 2 && host == 4)
            {
                player4.money -= 200;
                house = 3;
                파란땅2.SetActive(true);
            }
            else if (house == 3 && host == 4)
            {
                player4.money -= 200;
                house = 4;
                파란땅3.SetActive(true);
            }
            else if (house == 4 && host == 4)
            {
                player4.money -= 200;
                house = 5;
                파란땅1.SetActive(false);
                파란땅2.SetActive(false);
                파란땅3.SetActive(false);
                파란랜드.SetActive(true);
            }
            else if (house == 5 && host == 4)
            {
                Debug.Log("더 이상 건물을 지을 수 없습니다.");
            }
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
    }
}
