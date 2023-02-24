using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int distance = 0;
    public static int distance2 = 0;
    public static int distance3 = 0;
    public static int distance4 = 0;
    public static bool UIScrean = true;
    int 월급칸1 = 40;
    int 월급칸2 = 40;
    int 월급칸3 = 40;
    int 월급칸4 = 40;
    public GameObject menuSet;
    //int dnumber;
    void Start()
    {
        UIScrean = true;
        //Debug.Log("서버도 실행중");
    }

    void FixedUpdate()
    {
        //Debug.Log(UIScrean);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject 플레이어1 = GameObject.Find("Stone").transform.Find("human2").gameObject;
        GameObject 플레이어2 = GameObject.Find("Stone2").transform.Find("무사").gameObject;
        GameObject 플레이어3 = GameObject.Find("Stone3").transform.Find("r7").gameObject;
        GameObject 플레이어4 = GameObject.Find("Stone4").transform.Find("정장입은").gameObject;
        StartCoroutine(SeeUI());
        if (Input.GetKeyDown(KeyCode.Space))
            StopCoroutine(SeeUI());
        //Debug.Log("UI2" + UIScrean);
        
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuSet.activeSelf)
                menuSet.SetActive(false);
            else
                menuSet.SetActive(true);
        }
        
        if(player1.money < 0)
        {
            플레이어1.SetActive(false);
        }
        if (player2.money < 0)
        {
            플레이어2.SetActive(false);
        }
        if (player3.money < 0)
        {
            플레이어3.SetActive(false);
        }
        if (player4.money < 0)
        {
            플레이어4.SetActive(false);
        }
    }

    void LateUpdate()
    {
        
    }

    public void GameExit()
    {
        //Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    IEnumerator SeeUI()
    {
        GameObject 동굴권리증 = GameObject.Find("UI모음").transform.Find("동굴UI").gameObject;
        GameObject 지하움집권리증 = GameObject.Find("UI모음").transform.Find("지하움집UI").gameObject;
        GameObject 지상움집권리증 = GameObject.Find("UI모음").transform.Find("지상움집UI").gameObject;
        GameObject 고인돌권리증 = GameObject.Find("UI모음").transform.Find("고인돌UI").gameObject;
        GameObject 부뚜막권리증 = GameObject.Find("UI모음").transform.Find("부뚜막UI").gameObject;
        GameObject 광개토권리증 = GameObject.Find("UI모음").transform.Find("광개토UI").gameObject;
        GameObject 장군총권리증 = GameObject.Find("UI모음").transform.Find("장군총UI").gameObject;
        GameObject 무령왕릉권리증 = GameObject.Find("UI모음").transform.Find("무령왕릉UI").gameObject;
        GameObject 정림사권리증 = GameObject.Find("UI모음").transform.Find("정림사UI").gameObject;
        GameObject 첨성대권리증 = GameObject.Find("UI모음").transform.Find("첨성대UI").gameObject;
        GameObject 불국사권리증 = GameObject.Find("UI모음").transform.Find("불국사UI").gameObject;
        GameObject 해인사권리증 = GameObject.Find("UI모음").transform.Find("해인사UI").gameObject;
        GameObject 처인성권리증 = GameObject.Find("UI모음").transform.Find("처인성UI").gameObject;
        GameObject 천리장성권리증 = GameObject.Find("UI모음").transform.Find("천리장성UI").gameObject;
        GameObject 경복궁권리증 = GameObject.Find("UI모음").transform.Find("경복궁UI").gameObject;
        GameObject 집현전권리증 = GameObject.Find("UI모음").transform.Find("집현전UI").gameObject;
        GameObject 창덕궁권리증 = GameObject.Find("UI모음").transform.Find("창덕궁UI").gameObject;
        GameObject 명동성당권리증 = GameObject.Find("UI모음").transform.Find("명동성당UI").gameObject;
        GameObject 석조전권리증 = GameObject.Find("UI모음").transform.Find("석조전UI").gameObject;
        GameObject 가덕도등대권리증 = GameObject.Find("UI모음").transform.Find("가덕도등대UI").gameObject;
        GameObject 인천권리증 = GameObject.Find("UI모음").transform.Find("인천UI").gameObject;
        GameObject 서울권리증 = GameObject.Find("UI모음").transform.Find("서울UI").gameObject;
        GameObject 재난카드1 = GameObject.Find("UI모음").transform.Find("재난카드1UI").gameObject;
        GameObject 재난카드2 = GameObject.Find("UI모음").transform.Find("재난카드2UI").gameObject;
        GameObject 재난카드3 = GameObject.Find("UI모음").transform.Find("재난카드3UI").gameObject;
        GameObject 재난카드4 = GameObject.Find("UI모음").transform.Find("재난카드4UI").gameObject;
        GameObject 무기1 = GameObject.Find("UI모음").transform.Find("청동검UI").gameObject;
        GameObject 무기2 = GameObject.Find("UI모음").transform.Find("칠지도UI").gameObject;
        GameObject 무기3 = GameObject.Find("UI모음").transform.Find("신기전UI").gameObject;
        GameObject 무기4 = GameObject.Find("UI모음").transform.Find("천궁UI").gameObject;
        GameObject 사회기금 = GameObject.Find("UI모음").transform.Find("사회기금UI").gameObject;
        GameObject 타임머신 = GameObject.Find("UI모음").transform.Find("타임머신UI").gameObject;
        GameObject 찬스카드 = GameObject.Find("UI모음").transform.Find("찬스카드UI").gameObject;

        if (distance >= 월급칸1)
        {
            player1.money += 500;
            월급칸1 += 40;
            //UIScrean = false;
        }
        if (distance2 >= 월급칸2)
        {
            player2.money += 500;
            월급칸2 += 40;
            //UIScrean = false;
        }
        if (distance3 >= 월급칸3)
        {
            player3.money += 500;
            월급칸3 += 40;
            //UIScrean = false;
        }
        if (distance4 >= 월급칸4)
        {
            player4.money += 500;
            월급칸4 += 40;
            //UIScrean = false;
        }
        //Debug.Log(DiceScript.order);
        if (DiceScript.order == 2)
        {
            if (1 == distance % 40 && UIScrean)
            {
                if (동굴.host == 0 || 동굴.host == 1)
                {
                    동굴권리증.SetActive(true);
                }
                if (동굴.host == 2)
                {
                    if (동굴.house == 1)
                    {
                        player1.money -= 동굴.basicprice;
                        player2.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player1.money -= 동굴.oneprice;
                        player2.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player1.money -= 동굴.twoprice;
                        player2.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player1.money -= 동굴.threeprice;
                        player2.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player1.money -= 동굴.landprice;
                        player2.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 3)
                {
                    if (동굴.house == 1)
                    {
                        player1.money -= 동굴.basicprice;
                        player3.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player1.money -= 동굴.oneprice;
                        player3.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player1.money -= 동굴.twoprice;
                        player3.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player1.money -= 동굴.threeprice;
                        player3.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player1.money -= 동굴.landprice;
                        player3.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 4)
                {
                    if (동굴.house == 1)
                    {
                        player1.money -= 동굴.basicprice;
                        player4.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player1.money -= 동굴.oneprice;
                        player4.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player1.money -= 동굴.twoprice;
                        player4.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player1.money -= 동굴.threeprice;
                        player4.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player1.money -= 동굴.landprice;
                        player4.money += 동굴.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance % 40 && UIScrean)
            {
                if (지하움집.host == 0 || 지하움집.host == 1)
                {
                    지하움집권리증.SetActive(true);
                }
                if (지하움집.host == 2)
                {
                    if (지하움집.house == 1)
                    {
                        player1.money -= 지하움집.basicprice;
                        player2.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player1.money -= 지하움집.oneprice;
                        player2.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player1.money -= 지하움집.twoprice;
                        player2.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player1.money -= 지하움집.threeprice;
                        player2.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player1.money -= 지하움집.landprice;
                        player2.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 3)
                {
                    if (지하움집.house == 1)
                    {
                        player1.money -= 지하움집.basicprice;
                        player3.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player1.money -= 지하움집.oneprice;
                        player3.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player1.money -= 지하움집.twoprice;
                        player3.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player1.money -= 지하움집.threeprice;
                        player3.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player1.money -= 지하움집.landprice;
                        player3.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 4)
                {
                    if (지하움집.house == 1)
                    {
                        player1.money -= 지하움집.basicprice;
                        player4.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player1.money -= 지하움집.oneprice;
                        player4.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player1.money -= 지하움집.twoprice;
                        player4.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player1.money -= 지하움집.threeprice;
                        player4.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player1.money -= 지하움집.landprice;
                        player4.money += 지하움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (4 == distance % 40 && UIScrean)
            {
                재난카드1.SetActive(true);
                UIScrean = false;
            }
            if (6 == distance % 40 && UIScrean)
            {
                if (지상움집.host == 0 || 지상움집.host == 1)
                {
                    지상움집권리증.SetActive(true);
                }
                if (지상움집.host == 2)
                {
                    if (지상움집.house == 1)
                    {
                        player1.money -= 지상움집.basicprice;
                        player2.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player1.money -= 지상움집.oneprice;
                        player2.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player1.money -= 지상움집.twoprice;
                        player2.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player1.money -= 지상움집.threeprice;
                        player2.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player1.money -= 지상움집.landprice;
                        player2.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 3)
                {
                    if (지상움집.house == 1)
                    {
                        player1.money -= 지상움집.basicprice;
                        player3.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player1.money -= 지상움집.oneprice;
                        player3.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player1.money -= 지상움집.twoprice;
                        player3.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player1.money -= 지상움집.threeprice;
                        player3.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player1.money -= 지상움집.landprice;
                        player3.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 4)
                {
                    if (지상움집.house == 1)
                    {
                        player1.money -= 지상움집.basicprice;
                        player4.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player1.money -= 지상움집.oneprice;
                        player4.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player1.money -= 지상움집.twoprice;
                        player4.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player1.money -= 지상움집.threeprice;
                        player4.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player1.money -= 지상움집.landprice;
                        player4.money += 지상움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance % 40 && UIScrean)
            {
                if (고인돌.host == 0 || 고인돌.host == 1)
                {
                    고인돌권리증.SetActive(true);
                }
                if (고인돌.host == 2)
                {
                    if (고인돌.house == 1)
                    {
                        player1.money -= 고인돌.basicprice;
                        player2.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player1.money -= 고인돌.oneprice;
                        player2.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player1.money -= 고인돌.twoprice;
                        player2.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player1.money -= 고인돌.threeprice;
                        player2.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player1.money -= 고인돌.landprice;
                        player2.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 3)
                {
                    if (고인돌.house == 1)
                    {
                        player1.money -= 고인돌.basicprice;
                        player3.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player1.money -= 고인돌.oneprice;
                        player3.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player1.money -= 고인돌.twoprice;
                        player3.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player1.money -= 고인돌.threeprice;
                        player3.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player1.money -= 고인돌.landprice;
                        player3.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 4)
                {
                    if (고인돌.house == 1)
                    {
                        player1.money -= 고인돌.basicprice;
                        player4.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player1.money -= 고인돌.oneprice;
                        player4.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player1.money -= 고인돌.twoprice;
                        player4.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player1.money -= 고인돌.threeprice;
                        player4.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player1.money -= 고인돌.landprice;
                        player4.money += 고인돌.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance % 40 && UIScrean)
            {
                if (부뚜막.host == 0 || 부뚜막.host == 1)
                {
                    부뚜막권리증.SetActive(true);
                }
                if (부뚜막.host == 2)
                {
                    if (부뚜막.house == 1)
                    {
                        player1.money -= 부뚜막.basicprice;
                        player2.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player1.money -= 부뚜막.oneprice;
                        player2.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player1.money -= 부뚜막.twoprice;
                        player2.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player1.money -= 부뚜막.threeprice;
                        player2.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player1.money -= 부뚜막.landprice;
                        player2.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 3)
                {
                    if (부뚜막.house == 1)
                    {
                        player1.money -= 부뚜막.basicprice;
                        player3.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player1.money -= 부뚜막.oneprice;
                        player3.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player1.money -= 부뚜막.twoprice;
                        player3.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player1.money -= 부뚜막.threeprice;
                        player3.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player1.money -= 부뚜막.landprice;
                        player3.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 4)
                {
                    if (부뚜막.house == 1)
                    {
                        player1.money -= 부뚜막.basicprice;
                        player4.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player1.money -= 부뚜막.oneprice;
                        player4.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player1.money -= 부뚜막.twoprice;
                        player4.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player1.money -= 부뚜막.threeprice;
                        player4.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player1.money -= 부뚜막.landprice;
                        player4.money += 부뚜막.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance % 40 && UIScrean)
            {
                if (광개토.host == 0 || 광개토.host == 1)
                {
                    광개토권리증.SetActive(true);
                }
                if (광개토.host == 2)
                {
                    if (광개토.house == 1)
                    {
                        player1.money -= 광개토.basicprice;
                        player2.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player1.money -= 광개토.oneprice;
                        player2.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player1.money -= 광개토.twoprice;
                        player2.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player1.money -= 광개토.threeprice;
                        player2.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player1.money -= 광개토.landprice;
                        player2.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 3)
                {
                    if (광개토.house == 1)
                    {
                        player1.money -= 광개토.basicprice;
                        player3.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player1.money -= 광개토.oneprice;
                        player3.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player1.money -= 광개토.twoprice;
                        player3.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player1.money -= 광개토.threeprice;
                        player3.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player1.money -= 광개토.landprice;
                        player3.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 4)
                {
                    if (광개토.house == 1)
                    {
                        player1.money -= 광개토.basicprice;
                        player4.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player1.money -= 광개토.oneprice;
                        player4.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player1.money -= 광개토.twoprice;
                        player4.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player1.money -= 광개토.threeprice;
                        player4.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player1.money -= 광개토.landprice;
                        player4.money += 광개토.landprice;
                    }
                }
                UIScrean = false;
            }
            if (12 == distance % 40 && UIScrean)
            {
                재난카드2.SetActive(true);
                UIScrean = false;
            }
            if (13 == distance % 40 && UIScrean)
            {
                if (장군총.host == 0 || 장군총.host == 1)
                {
                    장군총권리증.SetActive(true);
                }
                if (장군총.host == 2)
                {
                    if (장군총.house == 1)
                    {
                        player1.money -= 장군총.basicprice;
                        player2.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player1.money -= 장군총.oneprice;
                        player2.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player1.money -= 장군총.twoprice;
                        player2.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player1.money -= 장군총.threeprice;
                        player2.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player1.money -= 장군총.landprice;
                        player2.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 3)
                {
                    if (장군총.house == 1)
                    {
                        player1.money -= 장군총.basicprice;
                        player3.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player1.money -= 장군총.oneprice;
                        player3.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player1.money -= 장군총.twoprice;
                        player3.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player1.money -= 장군총.threeprice;
                        player3.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player1.money -= 장군총.landprice;
                        player3.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 4)
                {
                    if (장군총.house == 1)
                    {
                        player1.money -= 장군총.basicprice;
                        player4.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player1.money -= 장군총.oneprice;
                        player4.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player1.money -= 장군총.twoprice;
                        player4.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player1.money -= 장군총.threeprice;
                        player4.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player1.money -= 장군총.landprice;
                        player4.money += 장군총.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance % 40 && UIScrean)
            {
                if (무령왕릉.host == 0 || 무령왕릉.host == 1)
                {
                    무령왕릉권리증.SetActive(true);
                }
                if (무령왕릉.host == 2)
                {
                    if (무령왕릉.house == 1)
                    {
                        player1.money -= 무령왕릉.basicprice;
                        player2.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player1.money -= 무령왕릉.oneprice;
                        player2.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player1.money -= 무령왕릉.twoprice;
                        player2.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player1.money -= 무령왕릉.threeprice;
                        player2.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player1.money -= 무령왕릉.landprice;
                        player2.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 3)
                {
                    if (무령왕릉.house == 1)
                    {
                        player1.money -= 무령왕릉.basicprice;
                        player3.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player1.money -= 무령왕릉.oneprice;
                        player3.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player1.money -= 무령왕릉.twoprice;
                        player3.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player1.money -= 무령왕릉.threeprice;
                        player3.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player1.money -= 무령왕릉.landprice;
                        player3.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 4)
                {
                    if (무령왕릉.house == 1)
                    {
                        player1.money -= 무령왕릉.basicprice;
                        player4.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player1.money -= 무령왕릉.oneprice;
                        player4.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player1.money -= 무령왕릉.twoprice;
                        player4.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player1.money -= 무령왕릉.threeprice;
                        player4.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player1.money -= 무령왕릉.landprice;
                        player4.money += 무령왕릉.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance % 40 && UIScrean)
            {
                if (정림사.host == 0 || 정림사.host == 1)
                {
                    정림사권리증.SetActive(true);
                }
                if (정림사.host == 2)
                {
                    if (정림사.house == 1)
                    {
                        player1.money -= 정림사.basicprice;
                        player2.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player1.money -= 정림사.oneprice;
                        player2.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player1.money -= 정림사.twoprice;
                        player2.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player1.money -= 정림사.threeprice;
                        player2.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player1.money -= 정림사.landprice;
                        player2.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 3)
                {
                    if (정림사.house == 1)
                    {
                        player1.money -= 정림사.basicprice;
                        player3.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player1.money -= 정림사.oneprice;
                        player3.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player1.money -= 정림사.twoprice;
                        player3.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player1.money -= 정림사.threeprice;
                        player3.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player1.money -= 정림사.landprice;
                        player3.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 4)
                {
                    if (정림사.house == 1)
                    {
                        player1.money -= 정림사.basicprice;
                        player4.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player1.money -= 정림사.oneprice;
                        player4.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player1.money -= 정림사.twoprice;
                        player4.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player1.money -= 정림사.threeprice;
                        player4.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player1.money -= 정림사.landprice;
                        player4.money += 정림사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance % 40 && UIScrean)
            {
                if (첨성대.host == 0 || 첨성대.host == 1)
                {
                    첨성대권리증.SetActive(true);
                }
                if (첨성대.host == 2)
                {
                    if (첨성대.house == 1)
                    {
                        player1.money -= 첨성대.basicprice;
                        player2.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player1.money -= 첨성대.oneprice;
                        player2.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player1.money -= 첨성대.twoprice;
                        player2.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player1.money -= 첨성대.threeprice;
                        player2.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player1.money -= 첨성대.landprice;
                        player2.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 3)
                {
                    if (첨성대.house == 1)
                    {
                        player1.money -= 첨성대.basicprice;
                        player3.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player1.money -= 첨성대.oneprice;
                        player3.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player1.money -= 첨성대.twoprice;
                        player3.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player1.money -= 첨성대.threeprice;
                        player3.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player1.money -= 첨성대.landprice;
                        player3.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 4)
                {
                    if (첨성대.house == 1)
                    {
                        player1.money -= 첨성대.basicprice;
                        player4.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player1.money -= 첨성대.oneprice;
                        player4.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player1.money -= 첨성대.twoprice;
                        player4.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player1.money -= 첨성대.threeprice;
                        player4.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player1.money -= 첨성대.landprice;
                        player4.money += 첨성대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance % 40 && UIScrean)
            {
                if (불국사.host == 0 || 불국사.host == 1)
                {
                    불국사권리증.SetActive(true);
                }
                if (불국사.host == 2)
                {
                    if (불국사.house == 1)
                    {
                        player1.money -= 불국사.basicprice;
                        player2.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player1.money -= 불국사.oneprice;
                        player2.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player1.money -= 불국사.twoprice;
                        player2.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player1.money -= 불국사.threeprice;
                        player2.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player1.money -= 불국사.landprice;
                        player2.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 3)
                {
                    if (불국사.house == 1)
                    {
                        player1.money -= 불국사.basicprice;
                        player3.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player1.money -= 불국사.oneprice;
                        player3.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player1.money -= 불국사.twoprice;
                        player3.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player1.money -= 불국사.threeprice;
                        player3.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player1.money -= 불국사.landprice;
                        player3.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 4)
                {
                    if (불국사.house == 1)
                    {
                        player1.money -= 불국사.basicprice;
                        player4.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player1.money -= 불국사.oneprice;
                        player4.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player1.money -= 불국사.twoprice;
                        player4.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player1.money -= 불국사.threeprice;
                        player4.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player1.money -= 불국사.landprice;
                        player4.money += 불국사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance % 40 && UIScrean)
            {
                if (해인사.host == 0 || 해인사.host == 1)
                {
                    해인사권리증.SetActive(true);
                }
                if (해인사.host == 2)
                {
                    if (해인사.house == 1)
                    {
                        player1.money -= 해인사.basicprice;
                        player2.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player1.money -= 해인사.oneprice;
                        player2.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player1.money -= 해인사.twoprice;
                        player2.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player1.money -= 해인사.threeprice;
                        player2.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player1.money -= 해인사.landprice;
                        player2.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 3)
                {
                    if (해인사.house == 1)
                    {
                        player1.money -= 해인사.basicprice;
                        player3.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player1.money -= 해인사.oneprice;
                        player3.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player1.money -= 해인사.twoprice;
                        player3.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player1.money -= 해인사.threeprice;
                        player3.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player1.money -= 해인사.landprice;
                        player3.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 4)
                {
                    if (해인사.house == 1)
                    {
                        player1.money -= 해인사.basicprice;
                        player4.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player1.money -= 해인사.oneprice;
                        player4.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player1.money -= 해인사.twoprice;
                        player4.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player1.money -= 해인사.threeprice;
                        player4.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player1.money -= 해인사.landprice;
                        player4.money += 해인사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance % 40 && UIScrean)
            {
                if (처인성.host == 0 || 처인성.host == 1)
                {
                    처인성권리증.SetActive(true);
                }
                if (처인성.host == 2)
                {
                    if (처인성.house == 1)
                    {
                        player1.money -= 처인성.basicprice;
                        player2.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player1.money -= 처인성.oneprice;
                        player2.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player1.money -= 처인성.twoprice;
                        player2.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player1.money -= 처인성.threeprice;
                        player2.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player1.money -= 처인성.landprice;
                        player2.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 3)
                {
                    if (처인성.house == 1)
                    {
                        player1.money -= 처인성.basicprice;
                        player3.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player1.money -= 처인성.oneprice;
                        player3.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player1.money -= 처인성.twoprice;
                        player3.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player1.money -= 처인성.threeprice;
                        player3.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player1.money -= 처인성.landprice;
                        player3.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 4)
                {
                    if (처인성.house == 1)
                    {
                        player1.money -= 처인성.basicprice;
                        player4.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player1.money -= 처인성.oneprice;
                        player4.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player1.money -= 처인성.twoprice;
                        player4.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player1.money -= 처인성.threeprice;
                        player4.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player1.money -= 처인성.landprice;
                        player4.money += 처인성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance % 40 && UIScrean)
            {
                if (천리장성.host == 0 || 천리장성.host == 1)
                {
                    천리장성권리증.SetActive(true);
                }
                if (천리장성.host == 2)
                {
                    if (천리장성.house == 1)
                    {
                        player1.money -= 천리장성.basicprice;
                        player2.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player1.money -= 천리장성.oneprice;
                        player2.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player1.money -= 천리장성.twoprice;
                        player2.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player1.money -= 천리장성.threeprice;
                        player2.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player1.money -= 천리장성.landprice;
                        player2.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 3)
                {
                    if (천리장성.house == 1)
                    {
                        player1.money -= 천리장성.basicprice;
                        player3.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player1.money -= 천리장성.oneprice;
                        player3.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player1.money -= 천리장성.twoprice;
                        player3.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player1.money -= 천리장성.threeprice;
                        player3.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player1.money -= 천리장성.landprice;
                        player3.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 4)
                {
                    if (천리장성.house == 1)
                    {
                        player1.money -= 천리장성.basicprice;
                        player4.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player1.money -= 천리장성.oneprice;
                        player4.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player1.money -= 천리장성.twoprice;
                        player4.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player1.money -= 천리장성.threeprice;
                        player4.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player1.money -= 천리장성.landprice;
                        player4.money += 천리장성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance % 40 && UIScrean)
            {
                if (경복궁.host == 0 || 경복궁.host == 1)
                {
                    경복궁권리증.SetActive(true);
                }
                if (경복궁.host == 2)
                {
                    if (경복궁.house == 1)
                    {
                        player1.money -= 경복궁.basicprice;
                        player2.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player1.money -= 경복궁.oneprice;
                        player2.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player1.money -= 경복궁.twoprice;
                        player2.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player1.money -= 경복궁.threeprice;
                        player2.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player1.money -= 경복궁.landprice;
                        player2.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 3)
                {
                    if (경복궁.house == 1)
                    {
                        player1.money -= 경복궁.basicprice;
                        player3.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player1.money -= 경복궁.oneprice;
                        player3.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player1.money -= 경복궁.twoprice;
                        player3.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player1.money -= 경복궁.threeprice;
                        player3.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player1.money -= 경복궁.landprice;
                        player3.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 4)
                {
                    if (경복궁.house == 1)
                    {
                        player1.money -= 경복궁.basicprice;
                        player4.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player1.money -= 경복궁.oneprice;
                        player4.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player1.money -= 경복궁.twoprice;
                        player4.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player1.money -= 경복궁.threeprice;
                        player4.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player1.money -= 경복궁.landprice;
                        player4.money += 경복궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance % 40 && UIScrean)
            {
                if (집현전.host == 0 || 집현전.host == 1)
                {
                    집현전권리증.SetActive(true);
                }
                if (집현전.host == 2)
                {
                    if (집현전.house == 1)
                    {
                        player1.money -= 집현전.basicprice;
                        player2.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player1.money -= 집현전.oneprice;
                        player2.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player1.money -= 집현전.twoprice;
                        player2.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player1.money -= 집현전.threeprice;
                        player2.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player1.money -= 집현전.landprice;
                        player2.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 3)
                {
                    if (집현전.house == 1)
                    {
                        player1.money -= 집현전.basicprice;
                        player3.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player1.money -= 집현전.oneprice;
                        player3.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player1.money -= 집현전.twoprice;
                        player3.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player1.money -= 집현전.threeprice;
                        player3.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player1.money -= 집현전.landprice;
                        player3.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 4)
                {
                    if (집현전.house == 1)
                    {
                        player1.money -= 집현전.basicprice;
                        player4.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player1.money -= 집현전.oneprice;
                        player4.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player1.money -= 집현전.twoprice;
                        player4.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player1.money -= 집현전.threeprice;
                        player4.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player1.money -= 집현전.landprice;
                        player4.money += 집현전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (28 == distance % 40 && UIScrean)
            {
                재난카드3.SetActive(true);
                UIScrean = false;
            }
            if (29 == distance % 40 && UIScrean)
            {
                if (창덕궁.host == 0 || 창덕궁.host == 1)
                {
                    창덕궁권리증.SetActive(true);
                }
                if (창덕궁.host == 2)
                {
                    if (창덕궁.house == 1)
                    {
                        player1.money -= 창덕궁.basicprice;
                        player2.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player1.money -= 창덕궁.oneprice;
                        player2.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player1.money -= 창덕궁.twoprice;
                        player2.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player1.money -= 창덕궁.threeprice;
                        player2.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player1.money -= 창덕궁.landprice;
                        player2.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 3)
                {
                    if (창덕궁.house == 1)
                    {
                        player1.money -= 창덕궁.basicprice;
                        player3.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player1.money -= 창덕궁.oneprice;
                        player3.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player1.money -= 창덕궁.twoprice;
                        player3.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player1.money -= 창덕궁.threeprice;
                        player3.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player1.money -= 창덕궁.landprice;
                        player3.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 4)
                {
                    if (창덕궁.house == 1)
                    {
                        player1.money -= 창덕궁.basicprice;
                        player4.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player1.money -= 창덕궁.oneprice;
                        player4.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player1.money -= 창덕궁.twoprice;
                        player4.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player1.money -= 창덕궁.threeprice;
                        player4.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player1.money -= 창덕궁.landprice;
                        player4.money += 창덕궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance % 40 && UIScrean)
            {
                if (명동성당.host == 0 || 명동성당.host == 1)
                {
                    명동성당권리증.SetActive(true);
                }
                if (명동성당.host == 2)
                {
                    if (명동성당.house == 1)
                    {
                        player1.money -= 명동성당.basicprice;
                        player2.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player1.money -= 명동성당.oneprice;
                        player2.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player1.money -= 명동성당.twoprice;
                        player2.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player1.money -= 명동성당.threeprice;
                        player2.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player1.money -= 명동성당.landprice;
                        player2.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 3)
                {
                    if (명동성당.house == 1)
                    {
                        player1.money -= 명동성당.basicprice;
                        player3.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player1.money -= 명동성당.oneprice;
                        player3.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player1.money -= 명동성당.twoprice;
                        player3.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player1.money -= 명동성당.threeprice;
                        player3.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player1.money -= 명동성당.landprice;
                        player3.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 4)
                {
                    if (명동성당.house == 1)
                    {
                        player1.money -= 명동성당.basicprice;
                        player4.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player1.money -= 명동성당.oneprice;
                        player4.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player1.money -= 명동성당.twoprice;
                        player4.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player1.money -= 명동성당.threeprice;
                        player4.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player1.money -= 명동성당.landprice;
                        player4.money += 명동성당.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance % 40 && UIScrean)
            {
                if (석조전.host == 0 || 석조전.host == 1)
                {
                    석조전권리증.SetActive(true);
                }
                if (석조전.host == 2)
                {
                    if (석조전.house == 1)
                    {
                        player1.money -= 석조전.basicprice;
                        player2.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player1.money -= 석조전.oneprice;
                        player2.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player1.money -= 석조전.twoprice;
                        player2.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player1.money -= 석조전.threeprice;
                        player2.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player1.money -= 석조전.landprice;
                        player2.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 3)
                {
                    if (석조전.house == 1)
                    {
                        player1.money -= 석조전.basicprice;
                        player3.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player1.money -= 석조전.oneprice;
                        player3.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player1.money -= 석조전.twoprice;
                        player3.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player1.money -= 석조전.threeprice;
                        player3.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player1.money -= 석조전.landprice;
                        player3.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 4)
                {
                    if (석조전.house == 1)
                    {
                        player1.money -= 석조전.basicprice;
                        player4.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player1.money -= 석조전.oneprice;
                        player4.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player1.money -= 석조전.twoprice;
                        player4.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player1.money -= 석조전.threeprice;
                        player4.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player1.money -= 석조전.landprice;
                        player4.money += 석조전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance % 40 && UIScrean)
            {
                if (가덕도등대.host == 0 || 가덕도등대.host == 1)
                {
                    가덕도등대권리증.SetActive(true);
                }
                if (가덕도등대.host == 2)
                {
                    if (가덕도등대.house == 1)
                    {
                        player1.money -= 가덕도등대.basicprice;
                        player2.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player1.money -= 가덕도등대.oneprice;
                        player2.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player1.money -= 가덕도등대.twoprice;
                        player2.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player1.money -= 가덕도등대.threeprice;
                        player2.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player1.money -= 가덕도등대.landprice;
                        player2.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 3)
                {
                    if (가덕도등대.house == 1)
                    {
                        player1.money -= 가덕도등대.basicprice;
                        player3.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player1.money -= 가덕도등대.oneprice;
                        player3.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player1.money -= 가덕도등대.twoprice;
                        player3.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player1.money -= 가덕도등대.threeprice;
                        player3.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player1.money -= 가덕도등대.landprice;
                        player3.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 4)
                {
                    if (가덕도등대.house == 1)
                    {
                        player1.money -= 가덕도등대.basicprice;
                        player4.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player1.money -= 가덕도등대.oneprice;
                        player4.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player1.money -= 가덕도등대.twoprice;
                        player4.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player1.money -= 가덕도등대.threeprice;
                        player4.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player1.money -= 가덕도등대.landprice;
                        player4.money += 가덕도등대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance % 40 && UIScrean)
            {
                if (인천.host == 0 || 인천.host == 1)
                {
                    인천권리증.SetActive(true);
                }
                if (인천.host == 2)
                {
                    if (인천.house == 1)
                    {
                        player1.money -= 인천.basicprice;
                        player2.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player1.money -= 인천.oneprice;
                        player2.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player1.money -= 인천.twoprice;
                        player2.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player1.money -= 인천.threeprice;
                        player2.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player1.money -= 인천.landprice;
                        player2.money += 인천.landprice;
                    }
                }
                else if (인천.host == 3)
                {
                    if (인천.house == 1)
                    {
                        player1.money -= 인천.basicprice;
                        player3.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player1.money -= 인천.oneprice;
                        player3.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player1.money -= 인천.twoprice;
                        player3.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player1.money -= 인천.threeprice;
                        player3.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player1.money -= 인천.landprice;
                        player3.money += 인천.landprice;
                    }
                }
                else if (인천.host == 4)
                {
                    if (인천.house == 1)
                    {
                        player1.money -= 인천.basicprice;
                        player4.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player1.money -= 인천.oneprice;
                        player4.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player1.money -= 인천.twoprice;
                        player4.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player1.money -= 인천.threeprice;
                        player4.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player1.money -= 인천.landprice;
                        player4.money += 인천.landprice;
                    }
                }
                UIScrean = false;

            }
            if (38 == distance % 40 && UIScrean)
            {
                재난카드4.SetActive(true);
                UIScrean = false;
            }
            if (39 == distance % 40 && UIScrean)
            {
                if (서울.host == 0 || 서울.host == 1)
                {
                    서울권리증.SetActive(true);
                }
                if (서울.host == 2)
                {
                    if (서울.house == 1)
                    {
                        player1.money -= 서울.basicprice;
                        player2.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player1.money -= 서울.oneprice;
                        player2.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player1.money -= 서울.twoprice;
                        player2.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player1.money -= 서울.threeprice;
                        player2.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player1.money -= 서울.landprice;
                        player2.money += 서울.landprice;
                    }
                }
                else if (서울.host == 3)
                {
                    if (서울.house == 1)
                    {
                        player1.money -= 서울.basicprice;
                        player3.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player1.money -= 서울.oneprice;
                        player3.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player1.money -= 서울.twoprice;
                        player3.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player1.money -= 서울.threeprice;
                        player3.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player1.money -= 서울.landprice;
                        player3.money += 서울.landprice;
                    }
                }
                else if (서울.host == 4)
                {
                    if (서울.house == 1)
                    {
                        player1.money -= 서울.basicprice;
                        player4.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player1.money -= 서울.oneprice;
                        player4.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player1.money -= 서울.twoprice;
                        player4.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player1.money -= 서울.threeprice;
                        player4.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player1.money -= 서울.landprice;
                        player4.money += 서울.landprice;
                    }
                }
                UIScrean = false;

            }
            if (5 == distance % 40 && UIScrean)
            {
                if (무기.host == 0)
                {
                    무기1.SetActive(true);
                }
                else if(무기.host == 2)
                {
                    player1.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host == 3)
                {
                    player1.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host == 4)
                {
                    player1.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance % 40 && UIScrean)
            {
                if (무기.host2 == 0)
                {
                    무기2.SetActive(true);
                }
                else if (무기.host2 == 2)
                {
                    player1.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host2 == 3)
                {
                    player1.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host2 == 4)
                {
                    player1.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance % 40 && UIScrean)
            {
                if (무기.host3 == 0)
                {
                    무기3.SetActive(true);
                }
                else if (무기.host3 == 2)
                {
                    player1.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host3 == 3)
                {
                    player1.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host3 == 4)
                {
                    player1.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance % 40 && UIScrean)
            {
                if (무기.host4 == 0)
                {
                    무기4.SetActive(true);
                }
                else if (무기.host4 == 2)
                {
                    player1.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host4 == 3)
                {
                    player1.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host4 == 4)
                {
                    player1.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance % 40 || 17 == distance % 40 || 33 == distance) && UIScrean)
            {
                사회기금.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance % 40 || 22 == distance % 40 || 36 == distance) && UIScrean)
            {
                찬스카드.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance % 40 && UIScrean)
            {
                타임머신.SetActive(true);
                UIScrean = false;
            }
            if (동굴권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                동굴권리증.SetActive(false);
            }
            else if (지하움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지하움집권리증.SetActive(false);
            }
            else if (지상움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지상움집권리증.SetActive(false);
            }
            else if (고인돌권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                고인돌권리증.SetActive(false);
            }
            else if (부뚜막권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                부뚜막권리증.SetActive(false);
            }
            else if (광개토권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                광개토권리증.SetActive(false);
            }
            else if (장군총권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                장군총권리증.SetActive(false);
            }
            else if (무령왕릉권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무령왕릉권리증.SetActive(false);
            }
            else if (정림사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                정림사권리증.SetActive(false);
            }
            else if (첨성대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                첨성대권리증.SetActive(false);
            }
            else if (불국사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                불국사권리증.SetActive(false);
            }
            else if (해인사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                해인사권리증.SetActive(false);
            }
            else if (처인성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                처인성권리증.SetActive(false);
            }
            else if (천리장성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                천리장성권리증.SetActive(false);
            }
            else if (경복궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                경복궁권리증.SetActive(false);
            }
            else if (집현전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                집현전권리증.SetActive(false);
            }
            else if (창덕궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                창덕궁권리증.SetActive(false);
            }
            else if (명동성당권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                명동성당권리증.SetActive(false);
            }
            else if (석조전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                석조전권리증.SetActive(false);
            }
            else if (가덕도등대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                가덕도등대권리증.SetActive(false);
            }
            else if (인천권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                인천권리증.SetActive(false);
            }
            else if (서울권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                서울권리증.SetActive(false);
            }
            else if (재난카드1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드1.SetActive(false);
            }
            else if (재난카드2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드2.SetActive(false);
            }
            else if (재난카드3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드3.SetActive(false);
            }
            else if (재난카드4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드4.SetActive(false);
            }
            else if (무기1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기1.SetActive(false);
            }
            else if (무기2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기2.SetActive(false);
            }
            else if (무기3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기3.SetActive(false);
            }
            else if (무기4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기4.SetActive(false);
            }
            else if (사회기금.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                사회기금.SetActive(false);
            }
            else if (찬스카드.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                찬스카드.SetActive(false);
            }
        }
        else if (DiceScript.order == 3)
        {
            if (1 == distance2 % 40 && UIScrean)
            {
                if (동굴.host == 0 || 동굴.host == 2)
                {
                    동굴권리증.SetActive(true);
                }
                if (동굴.host == 1)
                {
                    if (동굴.house == 1)
                    {
                        player2.money -= 동굴.basicprice;
                        player1.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player2.money -= 동굴.oneprice;
                        player1.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player2.money -= 동굴.twoprice;
                        player1.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player2.money -= 동굴.threeprice;
                        player1.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player2.money -= 동굴.landprice;
                        player1.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 3)
                {
                    if (동굴.house == 1)
                    {
                        player2.money -= 동굴.basicprice;
                        player3.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player2.money -= 동굴.oneprice;
                        player3.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player2.money -= 동굴.twoprice;
                        player3.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player2.money -= 동굴.threeprice;
                        player3.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player2.money -= 동굴.landprice;
                        player3.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 4)
                {
                    if (동굴.house == 1)
                    {
                        player2.money -= 동굴.basicprice;
                        player4.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player2.money -= 동굴.oneprice;
                        player2.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player2.money -= 동굴.twoprice;
                        player4.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player2.money -= 동굴.threeprice;
                        player4.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player2.money -= 동굴.landprice;
                        player4.money += 동굴.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance2 % 40 && UIScrean)
            {
                if (지하움집.host == 0 || 지하움집.host == 2)
                {
                    지하움집권리증.SetActive(true);
                }
                if (지하움집.host == 1)
                {
                    if (지하움집.house == 1)
                    {
                        player2.money -= 지하움집.basicprice;
                        player1.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player2.money -= 지하움집.oneprice;
                        player1.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player2.money -= 지하움집.twoprice;
                        player1.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player2.money -= 지하움집.threeprice;
                        player1.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player2.money -= 지하움집.landprice;
                        player1.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 3)
                {
                    if (지하움집.house == 1)
                    {
                        player2.money -= 지하움집.basicprice;
                        player3.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player2.money -= 지하움집.oneprice;
                        player3.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player2.money -= 지하움집.twoprice;
                        player3.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player2.money -= 지하움집.threeprice;
                        player3.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player2.money -= 지하움집.landprice;
                        player3.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 4)
                {
                    if (지하움집.house == 1)
                    {
                        player2.money -= 지하움집.basicprice;
                        player4.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player2.money -= 지하움집.oneprice;
                        player4.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player2.money -= 지하움집.twoprice;
                        player4.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player2.money -= 지하움집.threeprice;
                        player4.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player2.money -= 지하움집.landprice;
                        player4.money += 지하움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (6 == distance2 % 40 && UIScrean)
            {
                if (지상움집.host == 0 || 지상움집.host == 2)
                {
                    지상움집권리증.SetActive(true);
                }
                if (지상움집.host == 1)
                {
                    if (지상움집.house == 1)
                    {
                        player2.money -= 지상움집.basicprice;
                        player1.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player2.money -= 지상움집.oneprice;
                        player1.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player2.money -= 지상움집.twoprice;
                        player1.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player2.money -= 지상움집.threeprice;
                        player1.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player2.money -= 지상움집.landprice;
                        player1.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 3)
                {
                    if (지상움집.house == 1)
                    {
                        player2.money -= 지상움집.basicprice;
                        player3.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player2.money -= 지상움집.oneprice;
                        player3.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player2.money -= 지상움집.twoprice;
                        player3.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player2.money -= 지상움집.threeprice;
                        player3.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player2.money -= 지상움집.landprice;
                        player3.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 4)
                {
                    if (지상움집.house == 1)
                    {
                        player2.money -= 지상움집.basicprice;
                        player4.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player2.money -= 지상움집.oneprice;
                        player4.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player2.money -= 지상움집.twoprice;
                        player4.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player2.money -= 지상움집.threeprice;
                        player4.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player2.money -= 지상움집.landprice;
                        player4.money += 지상움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance2 % 40 && UIScrean)
            {
                if (고인돌.host == 0 || 고인돌.host == 2)
                {
                    고인돌권리증.SetActive(true);
                }
                if (고인돌.host == 1)
                {
                    if (고인돌.house == 1)
                    {
                        player2.money -= 고인돌.basicprice;
                        player1.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player2.money -= 고인돌.oneprice;
                        player1.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player2.money -= 고인돌.twoprice;
                        player1.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player2.money -= 고인돌.threeprice;
                        player1.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player2.money -= 고인돌.landprice;
                        player1.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 3)
                {
                    if (고인돌.house == 1)
                    {
                        player2.money -= 고인돌.basicprice;
                        player3.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player2.money -= 고인돌.oneprice;
                        player3.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player2.money -= 고인돌.twoprice;
                        player3.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player2.money -= 고인돌.threeprice;
                        player3.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player2.money -= 고인돌.landprice;
                        player3.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 4)
                {
                    if (고인돌.house == 1)
                    {
                        player2.money -= 고인돌.basicprice;
                        player4.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player2.money -= 고인돌.oneprice;
                        player4.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player2.money -= 고인돌.twoprice;
                        player4.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player2.money -= 고인돌.threeprice;
                        player4.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player2.money -= 고인돌.landprice;
                        player4.money += 고인돌.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance2 % 40 && UIScrean)
            {
                if (부뚜막.host == 0 || 부뚜막.host == 2)
                {
                    부뚜막권리증.SetActive(true);
                }
                if (부뚜막.host == 1)
                {
                    if (부뚜막.house == 1)
                    {
                        player2.money -= 부뚜막.basicprice;
                        player1.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player2.money -= 부뚜막.oneprice;
                        player1.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player2.money -= 부뚜막.twoprice;
                        player1.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player2.money -= 부뚜막.threeprice;
                        player1.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player2.money -= 부뚜막.landprice;
                        player1.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 3)
                {
                    if (부뚜막.house == 1)
                    {
                        player2.money -= 부뚜막.basicprice;
                        player3.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player2.money -= 부뚜막.oneprice;
                        player3.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player2.money -= 부뚜막.twoprice;
                        player3.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player2.money -= 부뚜막.threeprice;
                        player3.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player2.money -= 부뚜막.landprice;
                        player3.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 4)
                {
                    if (부뚜막.house == 1)
                    {
                        player2.money -= 부뚜막.basicprice;
                        player4.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player2.money -= 부뚜막.oneprice;
                        player4.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player2.money -= 부뚜막.twoprice;
                        player4.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player2.money -= 부뚜막.threeprice;
                        player4.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player2.money -= 부뚜막.landprice;
                        player4.money += 부뚜막.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance2 % 40 && UIScrean)
            {
                if (광개토.host == 0 || 광개토.host == 2)
                {
                    광개토권리증.SetActive(true);
                }
                if (광개토.host == 1)
                {
                    if (광개토.house == 1)
                    {
                        player2.money -= 광개토.basicprice;
                        player1.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player2.money -= 광개토.oneprice;
                        player1.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player2.money -= 광개토.twoprice;
                        player1.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player2.money -= 광개토.threeprice;
                        player1.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player2.money -= 광개토.landprice;
                        player1.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 3)
                {
                    if (광개토.house == 1)
                    {
                        player2.money -= 광개토.basicprice;
                        player3.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player2.money -= 광개토.oneprice;
                        player3.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player2.money -= 광개토.twoprice;
                        player3.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player2.money -= 광개토.threeprice;
                        player3.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player2.money -= 광개토.landprice;
                        player3.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 4)
                {
                    if (광개토.house == 1)
                    {
                        player2.money -= 광개토.basicprice;
                        player4.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player2.money -= 광개토.oneprice;
                        player4.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player2.money -= 광개토.twoprice;
                        player4.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player2.money -= 광개토.threeprice;
                        player4.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player2.money -= 광개토.landprice;
                        player4.money += 광개토.landprice;
                    }
                }
                UIScrean = false;
            }
            if (13 == distance2 % 40 && UIScrean)
            {
                if (장군총.host == 0 || 장군총.host == 2)
                {
                    장군총권리증.SetActive(true);
                }
                if (장군총.host == 1)
                {
                    if (장군총.house == 1)
                    {
                        player2.money -= 장군총.basicprice;
                        player1.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player2.money -= 장군총.oneprice;
                        player1.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player2.money -= 장군총.twoprice;
                        player1.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player2.money -= 장군총.threeprice;
                        player1.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player2.money -= 장군총.landprice;
                        player1.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 3)
                {
                    if (장군총.house == 1)
                    {
                        player2.money -= 장군총.basicprice;
                        player3.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player2.money -= 장군총.oneprice;
                        player3.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player2.money -= 장군총.twoprice;
                        player3.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player2.money -= 장군총.threeprice;
                        player3.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player2.money -= 장군총.landprice;
                        player3.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 4)
                {
                    if (장군총.house == 1)
                    {
                        player2.money -= 장군총.basicprice;
                        player4.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player2.money -= 장군총.oneprice;
                        player4.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player2.money -= 장군총.twoprice;
                        player4.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player2.money -= 장군총.threeprice;
                        player4.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player2.money -= 장군총.landprice;
                        player4.money += 장군총.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance2 % 40 && UIScrean)
            {
                if (무령왕릉.host == 0 || 무령왕릉.host == 2)
                {
                    무령왕릉권리증.SetActive(true);
                }
                if (무령왕릉.host == 1)
                {
                    if (무령왕릉.house == 1)
                    {
                        player2.money -= 무령왕릉.basicprice;
                        player1.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player2.money -= 무령왕릉.oneprice;
                        player1.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player2.money -= 무령왕릉.twoprice;
                        player1.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player2.money -= 무령왕릉.threeprice;
                        player1.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player2.money -= 무령왕릉.landprice;
                        player1.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 3)
                {
                    if (무령왕릉.house == 1)
                    {
                        player2.money -= 무령왕릉.basicprice;
                        player3.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player2.money -= 무령왕릉.oneprice;
                        player3.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player2.money -= 무령왕릉.twoprice;
                        player3.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player2.money -= 무령왕릉.threeprice;
                        player3.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player2.money -= 무령왕릉.landprice;
                        player3.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 4)
                {
                    if (무령왕릉.house == 1)
                    {
                        player2.money -= 무령왕릉.basicprice;
                        player4.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player2.money -= 무령왕릉.oneprice;
                        player4.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player2.money -= 무령왕릉.twoprice;
                        player4.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player2.money -= 무령왕릉.threeprice;
                        player4.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player2.money -= 무령왕릉.landprice;
                        player4.money += 무령왕릉.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance2 % 40 && UIScrean)
            {
                if (정림사.host == 0 || 정림사.host == 2)
                {
                    정림사권리증.SetActive(true);
                }
                if (정림사.host == 1)
                {
                    if (정림사.house == 1)
                    {
                        player2.money -= 정림사.basicprice;
                        player1.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player2.money -= 정림사.oneprice;
                        player1.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player2.money -= 정림사.twoprice;
                        player1.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player2.money -= 정림사.threeprice;
                        player1.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player2.money -= 정림사.landprice;
                        player1.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 3)
                {
                    if (정림사.house == 1)
                    {
                        player2.money -= 정림사.basicprice;
                        player3.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player2.money -= 정림사.oneprice;
                        player3.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player2.money -= 정림사.twoprice;
                        player3.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player2.money -= 정림사.threeprice;
                        player3.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player2.money -= 정림사.landprice;
                        player3.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 4)
                {
                    if (정림사.house == 1)
                    {
                        player2.money -= 정림사.basicprice;
                        player4.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player2.money -= 정림사.oneprice;
                        player4.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player2.money -= 정림사.twoprice;
                        player4.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player2.money -= 정림사.threeprice;
                        player4.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player2.money -= 정림사.landprice;
                        player4.money += 정림사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance2 % 40 && UIScrean)
            {
                if (첨성대.host == 0 || 첨성대.host == 2)
                {
                    첨성대권리증.SetActive(true);
                }
                if (첨성대.host == 1)
                {
                    if (첨성대.house == 1)
                    {
                        player2.money -= 첨성대.basicprice;
                        player1.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player2.money -= 첨성대.oneprice;
                        player1.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player2.money -= 첨성대.twoprice;
                        player1.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player2.money -= 첨성대.threeprice;
                        player1.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player2.money -= 첨성대.landprice;
                        player1.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 3)
                {
                    if (첨성대.house == 1)
                    {
                        player2.money -= 첨성대.basicprice;
                        player3.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player2.money -= 첨성대.oneprice;
                        player3.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player2.money -= 첨성대.twoprice;
                        player3.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player2.money -= 첨성대.threeprice;
                        player3.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player2.money -= 첨성대.landprice;
                        player3.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 4)
                {
                    if (첨성대.house == 1)
                    {
                        player2.money -= 첨성대.basicprice;
                        player4.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player2.money -= 첨성대.oneprice;
                        player4.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player2.money -= 첨성대.twoprice;
                        player4.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player2.money -= 첨성대.threeprice;
                        player4.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player2.money -= 첨성대.landprice;
                        player4.money += 첨성대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance2 % 40 && UIScrean)
            {
                if (불국사.host == 0 || 불국사.host == 2)
                {
                    불국사권리증.SetActive(true);
                }
                if (불국사.host == 1)
                {
                    if (불국사.house == 1)
                    {
                        player2.money -= 불국사.basicprice;
                        player1.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player2.money -= 불국사.oneprice;
                        player1.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player2.money -= 불국사.twoprice;
                        player1.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player2.money -= 불국사.threeprice;
                        player1.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player2.money -= 불국사.landprice;
                        player1.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 3)
                {
                    if (불국사.house == 1)
                    {
                        player2.money -= 불국사.basicprice;
                        player3.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player2.money -= 불국사.oneprice;
                        player3.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player2.money -= 불국사.twoprice;
                        player3.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player2.money -= 불국사.threeprice;
                        player3.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player2.money -= 불국사.landprice;
                        player3.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 4)
                {
                    if (불국사.house == 1)
                    {
                        player2.money -= 불국사.basicprice;
                        player4.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player2.money -= 불국사.oneprice;
                        player4.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player2.money -= 불국사.twoprice;
                        player4.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player2.money -= 불국사.threeprice;
                        player4.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player2.money -= 불국사.landprice;
                        player4.money += 불국사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance2 % 40 && UIScrean)
            {
                if (해인사.host == 0 || 해인사.host == 2)
                {
                    해인사권리증.SetActive(true);
                }
                if (해인사.host == 1)
                {
                    if (해인사.house == 1)
                    {
                        player2.money -= 해인사.basicprice;
                        player1.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player2.money -= 해인사.oneprice;
                        player1.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player2.money -= 해인사.twoprice;
                        player1.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player2.money -= 해인사.threeprice;
                        player1.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player2.money -= 해인사.landprice;
                        player1.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 3)
                {
                    if (해인사.house == 1)
                    {
                        player2.money -= 해인사.basicprice;
                        player3.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player2.money -= 해인사.oneprice;
                        player3.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player2.money -= 해인사.twoprice;
                        player3.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player2.money -= 해인사.threeprice;
                        player3.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player2.money -= 해인사.landprice;
                        player3.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 4)
                {
                    if (해인사.house == 1)
                    {
                        player2.money -= 해인사.basicprice;
                        player4.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player2.money -= 해인사.oneprice;
                        player4.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player2.money -= 해인사.twoprice;
                        player4.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player2.money -= 해인사.threeprice;
                        player4.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player2.money -= 해인사.landprice;
                        player4.money += 해인사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance2 % 40 && UIScrean)
            {
                if (처인성.host == 0 || 처인성.host == 2)
                {
                    처인성권리증.SetActive(true);
                }
                if (처인성.host == 1)
                {
                    if (처인성.house == 1)
                    {
                        player2.money -= 처인성.basicprice;
                        player1.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player2.money -= 처인성.oneprice;
                        player1.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player2.money -= 처인성.twoprice;
                        player1.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player2.money -= 처인성.threeprice;
                        player1.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player2.money -= 처인성.landprice;
                        player1.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 3)
                {
                    if (처인성.house == 1)
                    {
                        player2.money -= 처인성.basicprice;
                        player3.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player2.money -= 처인성.oneprice;
                        player3.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player2.money -= 처인성.twoprice;
                        player3.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player2.money -= 처인성.threeprice;
                        player3.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player2.money -= 처인성.landprice;
                        player3.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 4)
                {
                    if (처인성.house == 1)
                    {
                        player2.money -= 처인성.basicprice;
                        player4.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player2.money -= 처인성.oneprice;
                        player4.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player2.money -= 처인성.twoprice;
                        player4.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player2.money -= 처인성.threeprice;
                        player4.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player2.money -= 처인성.landprice;
                        player4.money += 처인성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance2 % 40 && UIScrean)
            {
                if (천리장성.host == 0 || 천리장성.host == 2)
                {
                    천리장성권리증.SetActive(true);
                }
                if (천리장성.host == 1)
                {
                    if (천리장성.house == 1)
                    {
                        player2.money -= 천리장성.basicprice;
                        player1.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player2.money -= 천리장성.oneprice;
                        player1.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player2.money -= 천리장성.twoprice;
                        player1.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player2.money -= 천리장성.threeprice;
                        player1.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player2.money -= 천리장성.landprice;
                        player1.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 3)
                {
                    if (천리장성.house == 1)
                    {
                        player2.money -= 천리장성.basicprice;
                        player3.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player2.money -= 천리장성.oneprice;
                        player3.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player2.money -= 천리장성.twoprice;
                        player3.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player2.money -= 천리장성.threeprice;
                        player3.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player2.money -= 천리장성.landprice;
                        player3.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 4)
                {
                    if (천리장성.house == 1)
                    {
                        player2.money -= 천리장성.basicprice;
                        player4.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player2.money -= 천리장성.oneprice;
                        player4.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player2.money -= 천리장성.twoprice;
                        player4.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player2.money -= 천리장성.threeprice;
                        player4.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player2.money -= 천리장성.landprice;
                        player4.money += 천리장성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance2 % 40 && UIScrean)
            {
                if (경복궁.host == 0 || 경복궁.host == 2)
                {
                    경복궁권리증.SetActive(true);
                }
                if (경복궁.host == 1)
                {
                    if (경복궁.house == 1)
                    {
                        player2.money -= 경복궁.basicprice;
                        player1.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player2.money -= 경복궁.oneprice;
                        player1.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player2.money -= 경복궁.twoprice;
                        player1.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player2.money -= 경복궁.threeprice;
                        player1.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player2.money -= 경복궁.landprice;
                        player1.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 3)
                {
                    if (경복궁.house == 1)
                    {
                        player2.money -= 경복궁.basicprice;
                        player3.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player2.money -= 경복궁.oneprice;
                        player3.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player2.money -= 경복궁.twoprice;
                        player3.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player2.money -= 경복궁.threeprice;
                        player3.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player2.money -= 경복궁.landprice;
                        player3.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 4)
                {
                    if (경복궁.house == 1)
                    {
                        player2.money -= 경복궁.basicprice;
                        player4.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player2.money -= 경복궁.oneprice;
                        player4.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player2.money -= 경복궁.twoprice;
                        player4.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player2.money -= 경복궁.threeprice;
                        player4.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player2.money -= 경복궁.landprice;
                        player4.money += 경복궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance2 % 40 && UIScrean)
            {
                if (집현전.host == 0 || 집현전.host == 2)
                {
                    집현전권리증.SetActive(true);
                }
                if (집현전.host == 1)
                {
                    if (집현전.house == 1)
                    {
                        player2.money -= 집현전.basicprice;
                        player1.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player2.money -= 집현전.oneprice;
                        player1.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player2.money -= 집현전.twoprice;
                        player1.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player2.money -= 집현전.threeprice;
                        player1.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player2.money -= 집현전.landprice;
                        player1.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 3)
                {
                    if (집현전.house == 1)
                    {
                        player2.money -= 집현전.basicprice;
                        player3.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player2.money -= 집현전.oneprice;
                        player3.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player2.money -= 집현전.twoprice;
                        player3.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player2.money -= 집현전.threeprice;
                        player3.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player2.money -= 집현전.landprice;
                        player3.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 4)
                {
                    if (집현전.house == 1)
                    {
                        player2.money -= 집현전.basicprice;
                        player4.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player2.money -= 집현전.oneprice;
                        player4.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player2.money -= 집현전.twoprice;
                        player4.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player2.money -= 집현전.threeprice;
                        player4.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player2.money -= 집현전.landprice;
                        player4.money += 집현전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (29 == distance2 % 40 && UIScrean)
            {
                if (창덕궁.host == 0 || 창덕궁.host == 2)
                {
                    창덕궁권리증.SetActive(true);
                }
                if (창덕궁.host == 1)
                {
                    if (창덕궁.house == 1)
                    {
                        player2.money -= 창덕궁.basicprice;
                        player1.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player2.money -= 창덕궁.oneprice;
                        player1.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player2.money -= 창덕궁.twoprice;
                        player1.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player2.money -= 창덕궁.threeprice;
                        player1.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player2.money -= 창덕궁.landprice;
                        player1.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 3)
                {
                    if (창덕궁.house == 1)
                    {
                        player2.money -= 창덕궁.basicprice;
                        player3.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player2.money -= 창덕궁.oneprice;
                        player3.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player2.money -= 창덕궁.twoprice;
                        player3.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player2.money -= 창덕궁.threeprice;
                        player3.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player2.money -= 창덕궁.landprice;
                        player3.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 4)
                {
                    if (창덕궁.house == 1)
                    {
                        player2.money -= 창덕궁.basicprice;
                        player4.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player2.money -= 창덕궁.oneprice;
                        player4.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player2.money -= 창덕궁.twoprice;
                        player4.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player2.money -= 창덕궁.threeprice;
                        player4.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player2.money -= 창덕궁.landprice;
                        player4.money += 창덕궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance2 % 40 && UIScrean)
            {
                if (명동성당.host == 0 || 명동성당.host == 2)
                {
                    명동성당권리증.SetActive(true);
                }
                if (명동성당.host == 1)
                {
                    if (명동성당.house == 1)
                    {
                        player2.money -= 명동성당.basicprice;
                        player1.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player2.money -= 명동성당.oneprice;
                        player1.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player2.money -= 명동성당.twoprice;
                        player1.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player2.money -= 명동성당.threeprice;
                        player1.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player2.money -= 명동성당.landprice;
                        player1.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 3)
                {
                    if (명동성당.house == 1)
                    {
                        player2.money -= 명동성당.basicprice;
                        player3.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player2.money -= 명동성당.oneprice;
                        player3.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player2.money -= 명동성당.twoprice;
                        player3.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player2.money -= 명동성당.threeprice;
                        player3.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player2.money -= 명동성당.landprice;
                        player3.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 4)
                {
                    if (명동성당.house == 1)
                    {
                        player2.money -= 명동성당.basicprice;
                        player4.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player2.money -= 명동성당.oneprice;
                        player4.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player2.money -= 명동성당.twoprice;
                        player4.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player2.money -= 명동성당.threeprice;
                        player4.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player2.money -= 명동성당.landprice;
                        player4.money += 명동성당.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance2 % 40 && UIScrean)
            {
                if (석조전.host == 0 || 석조전.host == 2)
                {
                    석조전권리증.SetActive(true);
                }
                if (석조전.host == 1)
                {
                    if (석조전.house == 1)
                    {
                        player2.money -= 석조전.basicprice;
                        player1.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player2.money -= 석조전.oneprice;
                        player1.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player2.money -= 석조전.twoprice;
                        player1.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player2.money -= 석조전.threeprice;
                        player1.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player2.money -= 석조전.landprice;
                        player1.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 3)
                {
                    if (석조전.house == 1)
                    {
                        player2.money -= 석조전.basicprice;
                        player3.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player2.money -= 석조전.oneprice;
                        player3.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player2.money -= 석조전.twoprice;
                        player3.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player2.money -= 석조전.threeprice;
                        player3.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player2.money -= 석조전.landprice;
                        player3.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 4)
                {
                    if (석조전.house == 1)
                    {
                        player2.money -= 석조전.basicprice;
                        player4.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player2.money -= 석조전.oneprice;
                        player4.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player2.money -= 석조전.twoprice;
                        player4.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player2.money -= 석조전.threeprice;
                        player4.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player2.money -= 석조전.landprice;
                        player4.money += 석조전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance2 % 40 && UIScrean)
            {
                if (가덕도등대.host == 0 || 가덕도등대.host == 2)
                {
                    가덕도등대권리증.SetActive(true);
                }
                if (가덕도등대.host == 1)
                {
                    if (가덕도등대.house == 1)
                    {
                        player2.money -= 가덕도등대.basicprice;
                        player1.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player2.money -= 가덕도등대.oneprice;
                        player1.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player2.money -= 가덕도등대.twoprice;
                        player1.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player2.money -= 가덕도등대.threeprice;
                        player1.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player2.money -= 가덕도등대.landprice;
                        player1.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 3)
                {
                    if (가덕도등대.house == 1)
                    {
                        player2.money -= 가덕도등대.basicprice;
                        player3.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player2.money -= 가덕도등대.oneprice;
                        player3.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player2.money -= 가덕도등대.twoprice;
                        player3.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player2.money -= 가덕도등대.threeprice;
                        player3.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player2.money -= 가덕도등대.landprice;
                        player3.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 4)
                {
                    if (가덕도등대.house == 1)
                    {
                        player2.money -= 가덕도등대.basicprice;
                        player4.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player2.money -= 가덕도등대.oneprice;
                        player4.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player2.money -= 가덕도등대.twoprice;
                        player4.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player2.money -= 가덕도등대.threeprice;
                        player4.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player2.money -= 가덕도등대.landprice;
                        player4.money += 가덕도등대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance2 % 40 && UIScrean)
            {
                if (인천.host == 0 || 인천.host == 2)
                {
                    인천권리증.SetActive(true);
                }
                if (인천.host == 1)
                {
                    if (인천.house == 1)
                    {
                        player2.money -= 인천.basicprice;
                        player1.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player2.money -= 인천.oneprice;
                        player1.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player2.money -= 인천.twoprice;
                        player1.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player2.money -= 인천.threeprice;
                        player1.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player2.money -= 인천.landprice;
                        player1.money += 인천.landprice;
                    }
                }
                else if (인천.host == 3)
                {
                    if (인천.house == 1)
                    {
                        player2.money -= 인천.basicprice;
                        player3.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player2.money -= 인천.oneprice;
                        player3.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player2.money -= 인천.twoprice;
                        player3.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player2.money -= 인천.threeprice;
                        player3.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player2.money -= 인천.landprice;
                        player3.money += 인천.landprice;
                    }
                }
                else if (인천.host == 4)
                {
                    if (인천.house == 1)
                    {
                        player2.money -= 인천.basicprice;
                        player4.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player2.money -= 인천.oneprice;
                        player4.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player2.money -= 인천.twoprice;
                        player4.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player2.money -= 인천.threeprice;
                        player4.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player2.money -= 인천.landprice;
                        player4.money += 인천.landprice;
                    }
                }
                UIScrean = false;

            }
            if (39 == distance2 % 40 && UIScrean)
            {
                if (서울.host == 0 || 서울.host == 2)
                {
                    서울권리증.SetActive(true);
                }
                if (서울.host == 1)
                {
                    if (서울.house == 1)
                    {
                        player2.money -= 서울.basicprice;
                        player1.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player2.money -= 서울.oneprice;
                        player1.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player2.money -= 서울.twoprice;
                        player1.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player2.money -= 서울.threeprice;
                        player1.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player2.money -= 서울.landprice;
                        player1.money += 서울.landprice;
                    }
                }
                else if (서울.host == 3)
                {
                    if (서울.house == 1)
                    {
                        player2.money -= 서울.basicprice;
                        player3.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player2.money -= 서울.oneprice;
                        player3.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player2.money -= 서울.twoprice;
                        player3.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player2.money -= 서울.threeprice;
                        player3.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player2.money -= 서울.landprice;
                        player3.money += 서울.landprice;
                    }
                }
                else if (서울.host == 4)
                {
                    if (서울.house == 1)
                    {
                        player2.money -= 서울.basicprice;
                        player4.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player2.money -= 서울.oneprice;
                        player4.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player2.money -= 서울.twoprice;
                        player4.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player2.money -= 서울.threeprice;
                        player4.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player2.money -= 서울.landprice;
                        player4.money += 서울.landprice;
                    }
                }
                UIScrean = false;

            }
            if (4 == distance2 % 40 && UIScrean)
            {
                재난카드1.SetActive(true);
                UIScrean = false;
            }
            if (12 == distance2 % 40 && UIScrean)
            {
                재난카드2.SetActive(true);
                UIScrean = false;
            }
            if (28 == distance2 % 40 && UIScrean)
            {
                재난카드3.SetActive(true);
                UIScrean = false;
            }
            if (38 == distance2 % 40 && UIScrean)
            {
                재난카드4.SetActive(true);
                UIScrean = false;
            }
            if (5 == distance2 % 40 && UIScrean)
            {
                if (무기.host == 0)
                {
                    무기1.SetActive(true);
                }
                else if (무기.host == 1)
                {
                    player2.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host == 3)
                {
                    player2.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host == 4)
                {
                    player2.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance2 % 40 && UIScrean)
            {
                if (무기.host2 == 0)
                {
                    무기2.SetActive(true);
                }
                else if (무기.host2 == 1)
                {
                    player2.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host2 == 3)
                {
                    player2.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host2 == 4)
                {
                    player2.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance2 % 40 && UIScrean)
            {
                if (무기.host3 == 0)
                {
                    무기3.SetActive(true);
                }
                else if (무기.host3 == 1)
                {
                    player2.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host3 == 3)
                {
                    player2.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host3 == 4)
                {
                    player2.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance2 % 40 && UIScrean)
            {
                if (무기.host4 == 0)
                {
                    무기4.SetActive(true);
                }
                else if (무기.host4 == 1)
                {
                    player2.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host4 == 3)
                {
                    player2.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host4 == 4)
                {
                    player2.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance2 % 40 || 17 == distance2 % 40 || 33 == distance2) && UIScrean)
            {
                사회기금.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance2 % 40 || 22 == distance2 % 40 || 36 == distance2) && UIScrean)
            {
                찬스카드.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance2 % 40 && UIScrean)
            {
                타임머신.SetActive(true);
                UIScrean = false;
            }
            if (동굴권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                동굴권리증.SetActive(false);
                //UIScrean = true;
            }
            else if (지하움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지하움집권리증.SetActive(false);
            }
            else if (지상움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지상움집권리증.SetActive(false);
            }
            else if (고인돌권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                고인돌권리증.SetActive(false);
            }
            else if (부뚜막권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                부뚜막권리증.SetActive(false);
            }
            else if (광개토권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                광개토권리증.SetActive(false);
            }
            else if (장군총권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                장군총권리증.SetActive(false);
            }
            else if (무령왕릉권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무령왕릉권리증.SetActive(false);
            }
            else if (정림사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                정림사권리증.SetActive(false);
            }
            else if (첨성대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                첨성대권리증.SetActive(false);
            }
            else if (불국사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                불국사권리증.SetActive(false);
            }
            else if (해인사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                해인사권리증.SetActive(false);
            }
            else if (처인성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                처인성권리증.SetActive(false);
            }
            else if (천리장성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                천리장성권리증.SetActive(false);
            }
            else if (경복궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                경복궁권리증.SetActive(false);
            }
            else if (집현전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                집현전권리증.SetActive(false);
            }
            else if (창덕궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                창덕궁권리증.SetActive(false);
            }
            else if (명동성당권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                명동성당권리증.SetActive(false);
            }
            else if (석조전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                석조전권리증.SetActive(false);
            }
            else if (가덕도등대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                가덕도등대권리증.SetActive(false);
            }
            else if (인천권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                인천권리증.SetActive(false);
            }
            else if (서울권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                서울권리증.SetActive(false);
            }
            else if (재난카드1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드1.SetActive(false);
            }
            else if (재난카드2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드2.SetActive(false);
            }
            else if (재난카드3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드3.SetActive(false);
            }
            else if (재난카드4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드4.SetActive(false);
            }
            else if (무기1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기1.SetActive(false);
            }
            else if (무기2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기2.SetActive(false);
            }
            else if (무기3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기3.SetActive(false);
            }
            else if (무기4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기4.SetActive(false);
            }
            else if (사회기금.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                사회기금.SetActive(false);
            }
            else if (찬스카드.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                찬스카드.SetActive(false);
            }
        }
        else if (DiceScript.order == 4)
        {
            if (1 == distance3 % 40 && UIScrean)
            {
                if (동굴.host == 0 || 동굴.host == 3)
                {
                    동굴권리증.SetActive(true);
                }
                if (동굴.host == 2)
                {
                    if (동굴.house == 1)
                    {
                        player3.money -= 동굴.basicprice;
                        player2.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player3.money -= 동굴.oneprice;
                        player2.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player3.money -= 동굴.twoprice;
                        player2.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player3.money -= 동굴.threeprice;
                        player2.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player3.money -= 동굴.landprice;
                        player2.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 1)
                {
                    if (동굴.house == 1)
                    {
                        player3.money -= 동굴.basicprice;
                        player1.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player3.money -= 동굴.oneprice;
                        player1.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player3.money -= 동굴.twoprice;
                        player1.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player3.money -= 동굴.threeprice;
                        player1.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player3.money -= 동굴.landprice;
                        player1.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 4)
                {
                    if (동굴.house == 1)
                    {
                        player3.money -= 동굴.basicprice;
                        player4.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player3.money -= 동굴.oneprice;
                        player4.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player3.money -= 동굴.twoprice;
                        player4.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player3.money -= 동굴.threeprice;
                        player4.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player3.money -= 동굴.landprice;
                        player4.money += 동굴.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance3 % 40 && UIScrean)
            {
                if (지하움집.host == 0 || 지하움집.host == 3)
                {
                    지하움집권리증.SetActive(true);
                }
                if (지하움집.host == 2)
                {
                    if (지하움집.house == 1)
                    {
                        player3.money -= 지하움집.basicprice;
                        player2.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player3.money -= 지하움집.oneprice;
                        player2.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player3.money -= 지하움집.twoprice;
                        player2.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player3.money -= 지하움집.threeprice;
                        player2.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player3.money -= 지하움집.landprice;
                        player2.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 1)
                {
                    if (지하움집.house == 1)
                    {
                        player3.money -= 지하움집.basicprice;
                        player1.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player3.money -= 지하움집.oneprice;
                        player1.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player3.money -= 지하움집.twoprice;
                        player1.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player3.money -= 지하움집.threeprice;
                        player1.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player3.money -= 지하움집.landprice;
                        player1.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 4)
                {
                    if (지하움집.house == 1)
                    {
                        player3.money -= 지하움집.basicprice;
                        player4.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player3.money -= 지하움집.oneprice;
                        player4.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player3.money -= 지하움집.twoprice;
                        player4.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player3.money -= 지하움집.threeprice;
                        player4.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player3.money -= 지하움집.landprice;
                        player4.money += 지하움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (6 == distance3 % 40 && UIScrean)
            {
                if (지상움집.host == 0 || 지상움집.host == 3)
                {
                    지상움집권리증.SetActive(true);
                }
                if (지상움집.host == 2)
                {
                    if (지상움집.house == 1)
                    {
                        player3.money -= 지상움집.basicprice;
                        player2.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player3.money -= 지상움집.oneprice;
                        player2.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player3.money -= 지상움집.twoprice;
                        player2.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player3.money -= 지상움집.threeprice;
                        player2.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player3.money -= 지상움집.landprice;
                        player2.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 1)
                {
                    if (지상움집.house == 1)
                    {
                        player3.money -= 지상움집.basicprice;
                        player1.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player3.money -= 지상움집.oneprice;
                        player1.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player3.money -= 지상움집.twoprice;
                        player1.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player3.money -= 지상움집.threeprice;
                        player1.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player3.money -= 지상움집.landprice;
                        player1.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 4)
                {
                    if (지상움집.house == 1)
                    {
                        player3.money -= 지상움집.basicprice;
                        player4.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player3.money -= 지상움집.oneprice;
                        player4.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player3.money -= 지상움집.twoprice;
                        player4.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player3.money -= 지상움집.threeprice;
                        player4.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player3.money -= 지상움집.landprice;
                        player4.money += 지상움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance3 % 40 && UIScrean)
            {
                if (고인돌.host == 0 || 고인돌.host == 3)
                {
                    고인돌권리증.SetActive(true);
                }
                if (고인돌.host == 2)
                {
                    if (고인돌.house == 1)
                    {
                        player3.money -= 고인돌.basicprice;
                        player2.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player3.money -= 고인돌.oneprice;
                        player2.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player3.money -= 고인돌.twoprice;
                        player2.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player3.money -= 고인돌.threeprice;
                        player2.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player3.money -= 고인돌.landprice;
                        player2.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 1)
                {
                    if (고인돌.house == 1)
                    {
                        player3.money -= 고인돌.basicprice;
                        player1.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player3.money -= 고인돌.oneprice;
                        player1.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player3.money -= 고인돌.twoprice;
                        player1.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player3.money -= 고인돌.threeprice;
                        player1.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player3.money -= 고인돌.landprice;
                        player1.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 4)
                {
                    if (고인돌.house == 1)
                    {
                        player3.money -= 고인돌.basicprice;
                        player4.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player3.money -= 고인돌.oneprice;
                        player4.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player3.money -= 고인돌.twoprice;
                        player4.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player3.money -= 고인돌.threeprice;
                        player4.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player3.money -= 고인돌.landprice;
                        player4.money += 고인돌.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance3 % 40 && UIScrean)
            {
                if (부뚜막.host == 0 || 부뚜막.host == 3)
                {
                    부뚜막권리증.SetActive(true);
                }
                if (부뚜막.host == 2)
                {
                    if (부뚜막.house == 1)
                    {
                        player3.money -= 부뚜막.basicprice;
                        player2.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player3.money -= 부뚜막.oneprice;
                        player2.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player3.money -= 부뚜막.twoprice;
                        player2.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player3.money -= 부뚜막.threeprice;
                        player2.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player3.money -= 부뚜막.landprice;
                        player2.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 1)
                {
                    if (부뚜막.house == 1)
                    {
                        player3.money -= 부뚜막.basicprice;
                        player1.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player3.money -= 부뚜막.oneprice;
                        player1.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player3.money -= 부뚜막.twoprice;
                        player1.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player3.money -= 부뚜막.threeprice;
                        player1.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player3.money -= 부뚜막.landprice;
                        player1.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 4)
                {
                    if (부뚜막.house == 1)
                    {
                        player3.money -= 부뚜막.basicprice;
                        player4.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player3.money -= 부뚜막.oneprice;
                        player4.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player3.money -= 부뚜막.twoprice;
                        player4.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player3.money -= 부뚜막.threeprice;
                        player4.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player3.money -= 부뚜막.landprice;
                        player4.money += 부뚜막.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance3 % 40 && UIScrean)
            {
                if (광개토.host == 0 || 광개토.host == 3)
                {
                    광개토권리증.SetActive(true);
                }
                if (광개토.host == 2)
                {
                    if (광개토.house == 1)
                    {
                        player3.money -= 광개토.basicprice;
                        player2.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player3.money -= 광개토.oneprice;
                        player2.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player3.money -= 광개토.twoprice;
                        player2.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player3.money -= 광개토.threeprice;
                        player2.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player3.money -= 광개토.landprice;
                        player2.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 1)
                {
                    if (광개토.house == 1)
                    {
                        player3.money -= 광개토.basicprice;
                        player1.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player3.money -= 광개토.oneprice;
                        player1.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player3.money -= 광개토.twoprice;
                        player1.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player3.money -= 광개토.threeprice;
                        player1.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player3.money -= 광개토.landprice;
                        player1.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 4)
                {
                    if (광개토.house == 1)
                    {
                        player3.money -= 광개토.basicprice;
                        player4.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player3.money -= 광개토.oneprice;
                        player4.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player3.money -= 광개토.twoprice;
                        player4.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player3.money -= 광개토.threeprice;
                        player4.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player3.money -= 광개토.landprice;
                        player4.money += 광개토.landprice;
                    }
                }
                UIScrean = false;
            }
            if (13 == distance3 % 40 && UIScrean)
            {
                if (장군총.host == 0 || 장군총.host == 3)
                {
                    장군총권리증.SetActive(true);
                }
                if (장군총.host == 2)
                {
                    if (장군총.house == 1)
                    {
                        player3.money -= 장군총.basicprice;
                        player2.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player3.money -= 장군총.oneprice;
                        player2.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player3.money -= 장군총.twoprice;
                        player2.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player3.money -= 장군총.threeprice;
                        player2.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player3.money -= 장군총.landprice;
                        player2.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 1)
                {
                    if (장군총.house == 1)
                    {
                        player3.money -= 장군총.basicprice;
                        player1.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player3.money -= 장군총.oneprice;
                        player1.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player3.money -= 장군총.twoprice;
                        player1.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player3.money -= 장군총.threeprice;
                        player1.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player3.money -= 장군총.landprice;
                        player1.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 4)
                {
                    if (장군총.house == 1)
                    {
                        player3.money -= 장군총.basicprice;
                        player4.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player3.money -= 장군총.oneprice;
                        player4.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player3.money -= 장군총.twoprice;
                        player4.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player3.money -= 장군총.threeprice;
                        player4.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player3.money -= 장군총.landprice;
                        player4.money += 장군총.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance3 % 40 && UIScrean)
            {
                if (무령왕릉.host == 0 || 무령왕릉.host == 3)
                {
                    무령왕릉권리증.SetActive(true);
                }
                if (무령왕릉.host == 2)
                {
                    if (무령왕릉.house == 1)
                    {
                        player3.money -= 무령왕릉.basicprice;
                        player2.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player3.money -= 무령왕릉.oneprice;
                        player2.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player3.money -= 무령왕릉.twoprice;
                        player2.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player3.money -= 무령왕릉.threeprice;
                        player2.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player3.money -= 무령왕릉.landprice;
                        player2.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 1)
                {
                    if (무령왕릉.house == 1)
                    {
                        player3.money -= 무령왕릉.basicprice;
                        player1.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player3.money -= 무령왕릉.oneprice;
                        player1.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player3.money -= 무령왕릉.twoprice;
                        player1.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player3.money -= 무령왕릉.threeprice;
                        player1.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player3.money -= 무령왕릉.landprice;
                        player1.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 4)
                {
                    if (무령왕릉.house == 1)
                    {
                        player3.money -= 무령왕릉.basicprice;
                        player4.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player3.money -= 무령왕릉.oneprice;
                        player4.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player3.money -= 무령왕릉.twoprice;
                        player4.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player3.money -= 무령왕릉.threeprice;
                        player4.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player3.money -= 무령왕릉.landprice;
                        player4.money += 무령왕릉.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance3 % 40 && UIScrean)
            {
                if (정림사.host == 0 || 정림사.host == 3)
                {
                    정림사권리증.SetActive(true);
                }
                if (정림사.host == 2)
                {
                    if (정림사.house == 1)
                    {
                        player3.money -= 정림사.basicprice;
                        player2.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player3.money -= 정림사.oneprice;
                        player2.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player3.money -= 정림사.twoprice;
                        player2.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player3.money -= 정림사.threeprice;
                        player2.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player3.money -= 정림사.landprice;
                        player2.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 1)
                {
                    if (정림사.house == 1)
                    {
                        player3.money -= 정림사.basicprice;
                        player1.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player3.money -= 정림사.oneprice;
                        player1.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player3.money -= 정림사.twoprice;
                        player1.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player3.money -= 정림사.threeprice;
                        player1.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player3.money -= 정림사.landprice;
                        player1.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 4)
                {
                    if (정림사.house == 1)
                    {
                        player3.money -= 정림사.basicprice;
                        player4.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player3.money -= 정림사.oneprice;
                        player4.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player3.money -= 정림사.twoprice;
                        player4.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player3.money -= 정림사.threeprice;
                        player4.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player3.money -= 정림사.landprice;
                        player4.money += 정림사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance3 % 40 && UIScrean)
            {
                if (첨성대.host == 0 || 첨성대.host == 3)
                {
                    첨성대권리증.SetActive(true);
                }
                if (첨성대.host == 2)
                {
                    if (첨성대.house == 1)
                    {
                        player3.money -= 첨성대.basicprice;
                        player2.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player3.money -= 첨성대.oneprice;
                        player2.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player3.money -= 첨성대.twoprice;
                        player2.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player3.money -= 첨성대.threeprice;
                        player2.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player3.money -= 첨성대.landprice;
                        player2.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 1)
                {
                    if (첨성대.house == 1)
                    {
                        player3.money -= 첨성대.basicprice;
                        player1.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player3.money -= 첨성대.oneprice;
                        player1.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player3.money -= 첨성대.twoprice;
                        player1.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player3.money -= 첨성대.threeprice;
                        player1.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player3.money -= 첨성대.landprice;
                        player1.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 4)
                {
                    if (첨성대.house == 1)
                    {
                        player3.money -= 첨성대.basicprice;
                        player4.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player3.money -= 첨성대.oneprice;
                        player4.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player3.money -= 첨성대.twoprice;
                        player4.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player3.money -= 첨성대.threeprice;
                        player4.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player3.money -= 첨성대.landprice;
                        player4.money += 첨성대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance3 % 40 && UIScrean)
            {
                if (불국사.host == 0 || 불국사.host == 3)
                {
                    불국사권리증.SetActive(true);
                }
                if (불국사.host == 2)
                {
                    if (불국사.house == 1)
                    {
                        player3.money -= 불국사.basicprice;
                        player2.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player3.money -= 불국사.oneprice;
                        player2.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player3.money -= 불국사.twoprice;
                        player2.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player3.money -= 불국사.threeprice;
                        player2.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player3.money -= 불국사.landprice;
                        player2.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 1)
                {
                    if (불국사.house == 1)
                    {
                        player3.money -= 불국사.basicprice;
                        player1.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player3.money -= 불국사.oneprice;
                        player1.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player3.money -= 불국사.twoprice;
                        player1.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player3.money -= 불국사.threeprice;
                        player1.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player3.money -= 불국사.landprice;
                        player1.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 4)
                {
                    if (불국사.house == 1)
                    {
                        player3.money -= 불국사.basicprice;
                        player4.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player3.money -= 불국사.oneprice;
                        player4.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player3.money -= 불국사.twoprice;
                        player4.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player3.money -= 불국사.threeprice;
                        player4.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player3.money -= 불국사.landprice;
                        player4.money += 불국사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance3 % 40 && UIScrean)
            {
                if (해인사.host == 0 || 해인사.host == 3)
                {
                    해인사권리증.SetActive(true);
                }
                if (해인사.host == 2)
                {
                    if (해인사.house == 1)
                    {
                        player3.money -= 해인사.basicprice;
                        player2.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player3.money -= 해인사.oneprice;
                        player2.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player3.money -= 해인사.twoprice;
                        player2.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player3.money -= 해인사.threeprice;
                        player2.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player3.money -= 해인사.landprice;
                        player2.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 1)
                {
                    if (해인사.house == 1)
                    {
                        player3.money -= 해인사.basicprice;
                        player1.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player3.money -= 해인사.oneprice;
                        player1.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player3.money -= 해인사.twoprice;
                        player1.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player3.money -= 해인사.threeprice;
                        player1.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player3.money -= 해인사.landprice;
                        player1.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 4)
                {
                    if (해인사.house == 1)
                    {
                        player3.money -= 해인사.basicprice;
                        player4.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player3.money -= 해인사.oneprice;
                        player4.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player3.money -= 해인사.twoprice;
                        player4.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player3.money -= 해인사.threeprice;
                        player4.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player3.money -= 해인사.landprice;
                        player4.money += 해인사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance3 % 40 && UIScrean)
            {
                if (처인성.host == 0 || 처인성.host == 3)
                {
                    처인성권리증.SetActive(true);
                }
                if (처인성.host == 2)
                {
                    if (처인성.house == 1)
                    {
                        player3.money -= 처인성.basicprice;
                        player2.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player3.money -= 처인성.oneprice;
                        player2.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player3.money -= 처인성.twoprice;
                        player2.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player3.money -= 처인성.threeprice;
                        player2.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player3.money -= 처인성.landprice;
                        player2.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 1)
                {
                    if (처인성.house == 1)
                    {
                        player3.money -= 처인성.basicprice;
                        player1.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player3.money -= 처인성.oneprice;
                        player1.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player3.money -= 처인성.twoprice;
                        player1.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player3.money -= 처인성.threeprice;
                        player1.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player3.money -= 처인성.landprice;
                        player1.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 4)
                {
                    if (처인성.house == 1)
                    {
                        player3.money -= 처인성.basicprice;
                        player4.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player3.money -= 처인성.oneprice;
                        player4.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player3.money -= 처인성.twoprice;
                        player4.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player3.money -= 처인성.threeprice;
                        player4.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player3.money -= 처인성.landprice;
                        player4.money += 처인성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance3 % 40 && UIScrean)
            {
                if (천리장성.host == 0 || 천리장성.host == 3)
                {
                    천리장성권리증.SetActive(true);
                }
                if (천리장성.host == 2)
                {
                    if (천리장성.house == 1)
                    {
                        player3.money -= 천리장성.basicprice;
                        player2.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player3.money -= 천리장성.oneprice;
                        player2.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player3.money -= 천리장성.twoprice;
                        player2.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player3.money -= 천리장성.threeprice;
                        player2.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player3.money -= 천리장성.landprice;
                        player2.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 1)
                {
                    if (천리장성.house == 1)
                    {
                        player3.money -= 천리장성.basicprice;
                        player1.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player3.money -= 천리장성.oneprice;
                        player1.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player3.money -= 천리장성.twoprice;
                        player1.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player3.money -= 천리장성.threeprice;
                        player1.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player3.money -= 천리장성.landprice;
                        player1.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 4)
                {
                    if (천리장성.house == 1)
                    {
                        player3.money -= 천리장성.basicprice;
                        player4.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player3.money -= 천리장성.oneprice;
                        player4.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player3.money -= 천리장성.twoprice;
                        player4.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player3.money -= 천리장성.threeprice;
                        player4.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player3.money -= 천리장성.landprice;
                        player4.money += 천리장성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance3 % 40 && UIScrean)
            {
                if (경복궁.host == 0 || 경복궁.host == 3)
                {
                    경복궁권리증.SetActive(true);
                }
                if (경복궁.host == 2)
                {
                    if (경복궁.house == 1)
                    {
                        player3.money -= 경복궁.basicprice;
                        player2.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player3.money -= 경복궁.oneprice;
                        player2.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player3.money -= 경복궁.twoprice;
                        player2.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player3.money -= 경복궁.threeprice;
                        player2.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player3.money -= 경복궁.landprice;
                        player2.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 1)
                {
                    if (경복궁.house == 1)
                    {
                        player3.money -= 경복궁.basicprice;
                        player1.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player3.money -= 경복궁.oneprice;
                        player1.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player3.money -= 경복궁.twoprice;
                        player1.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player3.money -= 경복궁.threeprice;
                        player1.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player3.money -= 경복궁.landprice;
                        player1.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 4)
                {
                    if (경복궁.house == 1)
                    {
                        player3.money -= 경복궁.basicprice;
                        player4.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player3.money -= 경복궁.oneprice;
                        player4.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player3.money -= 경복궁.twoprice;
                        player4.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player3.money -= 경복궁.threeprice;
                        player4.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player3.money -= 경복궁.landprice;
                        player4.money += 경복궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance3 % 40 && UIScrean)
            {
                if (집현전.host == 0 || 집현전.host == 3)
                {
                    집현전권리증.SetActive(true);
                }
                if (집현전.host == 2)
                {
                    if (집현전.house == 1)
                    {
                        player3.money -= 집현전.basicprice;
                        player2.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player3.money -= 집현전.oneprice;
                        player2.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player3.money -= 집현전.twoprice;
                        player2.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player3.money -= 집현전.threeprice;
                        player2.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player3.money -= 집현전.landprice;
                        player2.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 1)
                {
                    if (집현전.house == 1)
                    {
                        player3.money -= 집현전.basicprice;
                        player1.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player3.money -= 집현전.oneprice;
                        player1.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player3.money -= 집현전.twoprice;
                        player1.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player3.money -= 집현전.threeprice;
                        player1.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player3.money -= 집현전.landprice;
                        player1.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 4)
                {
                    if (집현전.house == 1)
                    {
                        player3.money -= 집현전.basicprice;
                        player4.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player3.money -= 집현전.oneprice;
                        player4.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player3.money -= 집현전.twoprice;
                        player4.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player3.money -= 집현전.threeprice;
                        player4.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player3.money -= 집현전.landprice;
                        player4.money += 집현전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (29 == distance3 % 40 && UIScrean)
            {
                if (창덕궁.host == 0 || 창덕궁.host == 3)
                {
                    창덕궁권리증.SetActive(true);
                }
                if (창덕궁.host == 2)
                {
                    if (창덕궁.house == 1)
                    {
                        player3.money -= 창덕궁.basicprice;
                        player2.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player3.money -= 창덕궁.oneprice;
                        player2.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player3.money -= 창덕궁.twoprice;
                        player2.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player3.money -= 창덕궁.threeprice;
                        player2.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player3.money -= 창덕궁.landprice;
                        player2.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 1)
                {
                    if (창덕궁.house == 1)
                    {
                        player3.money -= 창덕궁.basicprice;
                        player1.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player3.money -= 창덕궁.oneprice;
                        player1.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player3.money -= 창덕궁.twoprice;
                        player1.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player3.money -= 창덕궁.threeprice;
                        player1.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player3.money -= 창덕궁.landprice;
                        player1.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 4)
                {
                    if (창덕궁.house == 1)
                    {
                        player3.money -= 창덕궁.basicprice;
                        player4.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player3.money -= 창덕궁.oneprice;
                        player4.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player3.money -= 창덕궁.twoprice;
                        player4.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player3.money -= 창덕궁.threeprice;
                        player4.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player3.money -= 창덕궁.landprice;
                        player4.money += 창덕궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance3 % 40 && UIScrean)
            {
                if (명동성당.host == 0 || 명동성당.host == 3)
                {
                    명동성당권리증.SetActive(true);
                }
                if (명동성당.host == 2)
                {
                    if (명동성당.house == 1)
                    {
                        player3.money -= 명동성당.basicprice;
                        player2.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player3.money -= 명동성당.oneprice;
                        player2.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player3.money -= 명동성당.twoprice;
                        player2.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player3.money -= 명동성당.threeprice;
                        player2.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player3.money -= 명동성당.landprice;
                        player2.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 1)
                {
                    if (명동성당.house == 1)
                    {
                        player3.money -= 명동성당.basicprice;
                        player1.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player3.money -= 명동성당.oneprice;
                        player1.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player3.money -= 명동성당.twoprice;
                        player1.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player3.money -= 명동성당.threeprice;
                        player1.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player3.money -= 명동성당.landprice;
                        player1.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 4)
                {
                    if (명동성당.house == 1)
                    {
                        player3.money -= 명동성당.basicprice;
                        player4.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player3.money -= 명동성당.oneprice;
                        player4.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player3.money -= 명동성당.twoprice;
                        player4.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player3.money -= 명동성당.threeprice;
                        player4.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player3.money -= 명동성당.landprice;
                        player4.money += 명동성당.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance3 % 40 && UIScrean)
            {
                if (석조전.host == 0 || 석조전.host == 3)
                {
                    석조전권리증.SetActive(true);
                }
                if (석조전.host == 2)
                {
                    if (석조전.house == 1)
                    {
                        player3.money -= 석조전.basicprice;
                        player2.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player3.money -= 석조전.oneprice;
                        player2.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player3.money -= 석조전.twoprice;
                        player2.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player3.money -= 석조전.threeprice;
                        player2.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player3.money -= 석조전.landprice;
                        player2.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 1)
                {
                    if (석조전.house == 1)
                    {
                        player3.money -= 석조전.basicprice;
                        player1.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player3.money -= 석조전.oneprice;
                        player1.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player3.money -= 석조전.twoprice;
                        player1.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player3.money -= 석조전.threeprice;
                        player1.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player3.money -= 석조전.landprice;
                        player1.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 4)
                {
                    if (석조전.house == 1)
                    {
                        player3.money -= 석조전.basicprice;
                        player4.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player3.money -= 석조전.oneprice;
                        player4.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player3.money -= 석조전.twoprice;
                        player4.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player3.money -= 석조전.threeprice;
                        player4.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player3.money -= 석조전.landprice;
                        player4.money += 석조전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance3 % 40 && UIScrean)
            {
                if (가덕도등대.host == 0 || 가덕도등대.host == 3)
                {
                    가덕도등대권리증.SetActive(true);
                }
                if (가덕도등대.host == 2)
                {
                    if (가덕도등대.house == 1)
                    {
                        player3.money -= 가덕도등대.basicprice;
                        player2.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player3.money -= 가덕도등대.oneprice;
                        player2.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player3.money -= 가덕도등대.twoprice;
                        player2.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player3.money -= 가덕도등대.threeprice;
                        player2.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player3.money -= 가덕도등대.landprice;
                        player2.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 1)
                {
                    if (가덕도등대.house == 1)
                    {
                        player3.money -= 가덕도등대.basicprice;
                        player1.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player3.money -= 가덕도등대.oneprice;
                        player1.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player3.money -= 가덕도등대.twoprice;
                        player1.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player3.money -= 가덕도등대.threeprice;
                        player1.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player3.money -= 가덕도등대.landprice;
                        player1.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 4)
                {
                    if (가덕도등대.house == 1)
                    {
                        player3.money -= 가덕도등대.basicprice;
                        player4.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player3.money -= 가덕도등대.oneprice;
                        player4.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player3.money -= 가덕도등대.twoprice;
                        player4.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player3.money -= 가덕도등대.threeprice;
                        player4.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player3.money -= 가덕도등대.landprice;
                        player4.money += 가덕도등대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance3 % 40 && UIScrean)
            {
                if (인천.host == 0 || 인천.host == 3)
                {
                    인천권리증.SetActive(true);
                }
                if (인천.host == 2)
                {
                    if (인천.house == 1)
                    {
                        player3.money -= 인천.basicprice;
                        player2.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player3.money -= 인천.oneprice;
                        player2.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player3.money -= 인천.twoprice;
                        player2.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player3.money -= 인천.threeprice;
                        player2.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player3.money -= 인천.landprice;
                        player2.money += 인천.landprice;
                    }
                }
                else if (인천.host == 1)
                {
                    if (인천.house == 1)
                    {
                        player3.money -= 인천.basicprice;
                        player1.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player3.money -= 인천.oneprice;
                        player1.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player3.money -= 인천.twoprice;
                        player1.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player3.money -= 인천.threeprice;
                        player1.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player3.money -= 인천.landprice;
                        player1.money += 인천.landprice;
                    }
                }
                else if (인천.host == 4)
                {
                    if (인천.house == 1)
                    {
                        player3.money -= 인천.basicprice;
                        player4.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player3.money -= 인천.oneprice;
                        player4.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player3.money -= 인천.twoprice;
                        player4.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player3.money -= 인천.threeprice;
                        player4.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player3.money -= 인천.landprice;
                        player4.money += 인천.landprice;
                    }
                }
                UIScrean = false;

            }
            if (39 == distance3 % 40 && UIScrean)
            {
                if (서울.host == 0 || 서울.host == 3)
                {
                    서울권리증.SetActive(true);
                }
                if (서울.host == 2)
                {
                    if (서울.house == 1)
                    {
                        player3.money -= 서울.basicprice;
                        player2.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player3.money -= 서울.oneprice;
                        player2.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player3.money -= 서울.twoprice;
                        player2.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player3.money -= 서울.threeprice;
                        player2.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player3.money -= 서울.landprice;
                        player2.money += 서울.landprice;
                    }
                }
                else if (서울.host == 1)
                {
                    if (서울.house == 1)
                    {
                        player3.money -= 서울.basicprice;
                        player1.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player3.money -= 서울.oneprice;
                        player1.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player3.money -= 서울.twoprice;
                        player1.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player3.money -= 서울.threeprice;
                        player1.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player3.money -= 서울.landprice;
                        player1.money += 서울.landprice;
                    }
                }
                else if (서울.host == 4)
                {
                    if (서울.house == 1)
                    {
                        player3.money -= 서울.basicprice;
                        player4.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player3.money -= 서울.oneprice;
                        player4.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player3.money -= 서울.twoprice;
                        player4.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player3.money -= 서울.threeprice;
                        player4.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player3.money -= 서울.landprice;
                        player4.money += 서울.landprice;
                    }
                }
                UIScrean = false;

            }
            if (4 == distance3 % 40 && UIScrean)
            {
                재난카드1.SetActive(true);
                UIScrean = false;
            }
            if (12 == distance3 % 40 && UIScrean)
            {
                재난카드2.SetActive(true);
                UIScrean = false;
            }
            if (28 == distance3 % 40 && UIScrean)
            {
                재난카드3.SetActive(true);
                UIScrean = false;
            }
            if (38 == distance3 % 40 && UIScrean)
            {
                재난카드4.SetActive(true);
                UIScrean = false;
            }
            if (5 == distance3 % 40 && UIScrean)
            {
                if (무기.host == 0)
                {
                    무기1.SetActive(true);
                }
                else if (무기.host == 1)
                {
                    player3.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host == 2)
                {
                    player3.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host == 4)
                {
                    player3.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance3 % 40 && UIScrean)
            {
                if (무기.host2 == 0)
                {
                    무기2.SetActive(true);
                }
                else if (무기.host2 == 1)
                {
                    player3.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host2 == 2)
                {
                    player3.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host2 == 4)
                {
                    player3.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance3 % 40 && UIScrean)
            {
                if (무기.host3 == 0)
                {
                    무기3.SetActive(true);
                }
                else if (무기.host3 == 1)
                {
                    player3.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host3 == 2)
                {
                    player3.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host3 == 4)
                {
                    player3.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance3 % 40 && UIScrean)
            {
                if (무기.host4 == 0)
                {
                    무기4.SetActive(true);
                }
                else if (무기.host4 == 1)
                {
                    player3.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host4 == 2)
                {
                    player3.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                else if (무기.host4 == 4)
                {
                    player3.money -= 무기.weapon4 * 100;
                    player4.money += 무기.weapon4 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance3 % 40 || 17 == distance3 % 40 || 33 == distance3) && UIScrean)
            {
                사회기금.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance3 % 40 || 22 == distance3 % 40 || 36 == distance3) && UIScrean)
            {
                찬스카드.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance3 % 40 && UIScrean)
            {
                타임머신.SetActive(true);
                UIScrean = false;
            }
            if (동굴권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                동굴권리증.SetActive(false);
                //UIScrean = true;
            }
            else if (지하움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지하움집권리증.SetActive(false);
            }
            else if (지상움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지상움집권리증.SetActive(false);
            }
            else if (고인돌권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                고인돌권리증.SetActive(false);
            }
            else if (부뚜막권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                부뚜막권리증.SetActive(false);
            }
            else if (광개토권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                광개토권리증.SetActive(false);
            }
            else if (장군총권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                장군총권리증.SetActive(false);
            }
            else if (무령왕릉권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무령왕릉권리증.SetActive(false);
            }
            else if (정림사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                정림사권리증.SetActive(false);
            }
            else if (첨성대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                첨성대권리증.SetActive(false);
            }
            else if (불국사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                불국사권리증.SetActive(false);
            }
            else if (해인사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                해인사권리증.SetActive(false);
            }
            else if (처인성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                처인성권리증.SetActive(false);
            }
            else if (천리장성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                천리장성권리증.SetActive(false);
            }
            else if (경복궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                경복궁권리증.SetActive(false);
            }
            else if (집현전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                집현전권리증.SetActive(false);
            }
            else if (창덕궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                창덕궁권리증.SetActive(false);
            }
            else if (명동성당권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                명동성당권리증.SetActive(false);
            }
            else if (석조전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                석조전권리증.SetActive(false);
            }
            else if (가덕도등대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                가덕도등대권리증.SetActive(false);
            }
            else if (인천권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                인천권리증.SetActive(false);
            }
            else if (서울권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                서울권리증.SetActive(false);
            }
            else if (재난카드1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드1.SetActive(false);
            }
            else if (재난카드2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드2.SetActive(false);
            }
            else if (재난카드3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드3.SetActive(false);
            }
            else if (재난카드4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드4.SetActive(false);
            }
            else if (무기1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기1.SetActive(false);
            }
            else if (무기2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기2.SetActive(false);
            }
            else if (무기3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기3.SetActive(false);
            }
            else if (무기4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기4.SetActive(false);
            }
            else if (사회기금.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                사회기금.SetActive(false);
            }
            else if (찬스카드.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                찬스카드.SetActive(false);
            }
        }
        else if (DiceScript.order == 1)
        {
            if (1 == distance4 % 40 && UIScrean)
            {
                if (동굴.host == 0 || 동굴.host == 4)
                {
                    동굴권리증.SetActive(true);
                }
                if (동굴.host == 2)
                {
                    if (동굴.house == 1)
                    {
                        player4.money -= 동굴.basicprice;
                        player2.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player4.money -= 동굴.oneprice;
                        player2.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player4.money -= 동굴.twoprice;
                        player2.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player4.money -= 동굴.threeprice;
                        player2.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player4.money -= 동굴.landprice;
                        player2.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 3)
                {
                    if (동굴.house == 1)
                    {
                        player4.money -= 동굴.basicprice;
                        player3.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player4.money -= 동굴.oneprice;
                        player3.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player4.money -= 동굴.twoprice;
                        player3.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player4.money -= 동굴.threeprice;
                        player3.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player4.money -= 동굴.landprice;
                        player3.money += 동굴.landprice;
                    }
                }
                else if (동굴.host == 1)
                {
                    if (동굴.house == 1)
                    {
                        player4.money -= 동굴.basicprice;
                        player1.money += 동굴.basicprice;
                    }
                    else if (동굴.house == 2)
                    {
                        player4.money -= 동굴.oneprice;
                        player1.money += 동굴.oneprice;
                    }
                    else if (동굴.house == 3)
                    {
                        player4.money -= 동굴.twoprice;
                        player1.money += 동굴.twoprice;
                    }
                    else if (동굴.house == 4)
                    {
                        player4.money -= 동굴.threeprice;
                        player1.money += 동굴.threeprice;
                    }
                    else if (동굴.house == 5)
                    {
                        player4.money -= 동굴.landprice;
                        player1.money += 동굴.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance4 % 40 && UIScrean)
            {
                if (지하움집.host == 0 || 지하움집.host == 4)
                {
                    지하움집권리증.SetActive(true);
                }
                if (지하움집.host == 2)
                {
                    if (지하움집.house == 1)
                    {
                        player4.money -= 지하움집.basicprice;
                        player2.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player4.money -= 지하움집.oneprice;
                        player2.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player4.money -= 지하움집.twoprice;
                        player2.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player4.money -= 지하움집.threeprice;
                        player2.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player4.money -= 지하움집.landprice;
                        player2.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 3)
                {
                    if (지하움집.house == 1)
                    {
                        player4.money -= 지하움집.basicprice;
                        player3.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player4.money -= 지하움집.oneprice;
                        player3.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player4.money -= 지하움집.twoprice;
                        player3.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player4.money -= 지하움집.threeprice;
                        player3.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player4.money -= 지하움집.landprice;
                        player3.money += 지하움집.landprice;
                    }
                }
                else if (지하움집.host == 1)
                {
                    if (지하움집.house == 1)
                    {
                        player4.money -= 지하움집.basicprice;
                        player1.money += 지하움집.basicprice;
                    }
                    else if (지하움집.house == 2)
                    {
                        player4.money -= 지하움집.oneprice;
                        player1.money += 지하움집.oneprice;
                    }
                    else if (지하움집.house == 3)
                    {
                        player4.money -= 지하움집.twoprice;
                        player1.money += 지하움집.twoprice;
                    }
                    else if (지하움집.house == 4)
                    {
                        player4.money -= 지하움집.threeprice;
                        player1.money += 지하움집.threeprice;
                    }
                    else if (지하움집.house == 5)
                    {
                        player4.money -= 지하움집.landprice;
                        player1.money += 지하움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (6 == distance4 % 40 && UIScrean)
            {
                if (지상움집.host == 0 || 지상움집.host == 4)
                {
                    지상움집권리증.SetActive(true);
                }
                if (지상움집.host == 2)
                {
                    if (지상움집.house == 1)
                    {
                        player4.money -= 지상움집.basicprice;
                        player2.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player4.money -= 지상움집.oneprice;
                        player2.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player4.money -= 지상움집.twoprice;
                        player2.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player4.money -= 지상움집.threeprice;
                        player2.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player4.money -= 지상움집.landprice;
                        player2.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 3)
                {
                    if (지상움집.house == 1)
                    {
                        player4.money -= 지상움집.basicprice;
                        player3.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player4.money -= 지상움집.oneprice;
                        player3.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player4.money -= 지상움집.twoprice;
                        player3.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player4.money -= 지상움집.threeprice;
                        player3.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player4.money -= 지상움집.landprice;
                        player3.money += 지상움집.landprice;
                    }
                }
                else if (지상움집.host == 1)
                {
                    if (지상움집.house == 1)
                    {
                        player4.money -= 지상움집.basicprice;
                        player1.money += 지상움집.basicprice;
                    }
                    else if (지상움집.house == 2)
                    {
                        player4.money -= 지상움집.oneprice;
                        player1.money += 지상움집.oneprice;
                    }
                    else if (지상움집.house == 3)
                    {
                        player4.money -= 지상움집.twoprice;
                        player1.money += 지상움집.twoprice;
                    }
                    else if (지상움집.house == 4)
                    {
                        player4.money -= 지상움집.threeprice;
                        player1.money += 지상움집.threeprice;
                    }
                    else if (지상움집.house == 5)
                    {
                        player4.money -= 지상움집.landprice;
                        player1.money += 지상움집.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance4 % 40 && UIScrean)
            {
                if (고인돌.host == 0 || 고인돌.host == 4)
                {
                    고인돌권리증.SetActive(true);
                }
                if (고인돌.host == 2)
                {
                    if (고인돌.house == 1)
                    {
                        player4.money -= 고인돌.basicprice;
                        player2.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player4.money -= 고인돌.oneprice;
                        player2.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player4.money -= 고인돌.twoprice;
                        player2.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player4.money -= 고인돌.threeprice;
                        player2.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player4.money -= 고인돌.landprice;
                        player2.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 3)
                {
                    if (고인돌.house == 1)
                    {
                        player4.money -= 고인돌.basicprice;
                        player3.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player4.money -= 고인돌.oneprice;
                        player3.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player4.money -= 고인돌.twoprice;
                        player3.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player4.money -= 고인돌.threeprice;
                        player3.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player4.money -= 고인돌.landprice;
                        player3.money += 고인돌.landprice;
                    }
                }
                else if (고인돌.host == 1)
                {
                    if (고인돌.house == 1)
                    {
                        player4.money -= 고인돌.basicprice;
                        player1.money += 고인돌.basicprice;
                    }
                    else if (고인돌.house == 2)
                    {
                        player4.money -= 고인돌.oneprice;
                        player1.money += 고인돌.oneprice;
                    }
                    else if (고인돌.house == 3)
                    {
                        player4.money -= 고인돌.twoprice;
                        player1.money += 고인돌.twoprice;
                    }
                    else if (고인돌.house == 4)
                    {
                        player4.money -= 고인돌.threeprice;
                        player1.money += 고인돌.threeprice;
                    }
                    else if (고인돌.house == 5)
                    {
                        player4.money -= 고인돌.landprice;
                        player1.money += 고인돌.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance4 % 40 && UIScrean)
            {
                if (부뚜막.host == 0 || 부뚜막.host == 4)
                {
                    부뚜막권리증.SetActive(true);
                }
                if (부뚜막.host == 2)
                {
                    if (부뚜막.house == 1)
                    {
                        player4.money -= 부뚜막.basicprice;
                        player2.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player4.money -= 부뚜막.oneprice;
                        player2.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player4.money -= 부뚜막.twoprice;
                        player2.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player4.money -= 부뚜막.threeprice;
                        player2.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player4.money -= 부뚜막.landprice;
                        player2.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 3)
                {
                    if (부뚜막.house == 1)
                    {
                        player4.money -= 부뚜막.basicprice;
                        player3.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player4.money -= 부뚜막.oneprice;
                        player3.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player4.money -= 부뚜막.twoprice;
                        player3.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player4.money -= 부뚜막.threeprice;
                        player3.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player4.money -= 부뚜막.landprice;
                        player3.money += 부뚜막.landprice;
                    }
                }
                else if (부뚜막.host == 1)
                {
                    if (부뚜막.house == 1)
                    {
                        player4.money -= 부뚜막.basicprice;
                        player1.money += 부뚜막.basicprice;
                    }
                    else if (부뚜막.house == 2)
                    {
                        player4.money -= 부뚜막.oneprice;
                        player1.money += 부뚜막.oneprice;
                    }
                    else if (부뚜막.house == 3)
                    {
                        player4.money -= 부뚜막.twoprice;
                        player1.money += 부뚜막.twoprice;
                    }
                    else if (부뚜막.house == 4)
                    {
                        player4.money -= 부뚜막.threeprice;
                        player1.money += 부뚜막.threeprice;
                    }
                    else if (부뚜막.house == 5)
                    {
                        player4.money -= 부뚜막.landprice;
                        player1.money += 부뚜막.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance4 % 40 && UIScrean)
            {
                if (광개토.host == 0 || 광개토.host == 4)
                {
                    광개토권리증.SetActive(true);
                }
                if (광개토.host == 2)
                {
                    if (광개토.house == 1)
                    {
                        player4.money -= 광개토.basicprice;
                        player2.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player4.money -= 광개토.oneprice;
                        player2.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player4.money -= 광개토.twoprice;
                        player2.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player4.money -= 광개토.threeprice;
                        player2.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player4.money -= 광개토.landprice;
                        player2.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 3)
                {
                    if (광개토.house == 1)
                    {
                        player4.money -= 광개토.basicprice;
                        player3.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player4.money -= 광개토.oneprice;
                        player3.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player4.money -= 광개토.twoprice;
                        player3.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player4.money -= 광개토.threeprice;
                        player3.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player4.money -= 광개토.landprice;
                        player3.money += 광개토.landprice;
                    }
                }
                else if (광개토.host == 1)
                {
                    if (광개토.house == 1)
                    {
                        player4.money -= 광개토.basicprice;
                        player1.money += 광개토.basicprice;
                    }
                    else if (광개토.house == 2)
                    {
                        player4.money -= 광개토.oneprice;
                        player1.money += 광개토.oneprice;
                    }
                    else if (광개토.house == 3)
                    {
                        player4.money -= 광개토.twoprice;
                        player1.money += 광개토.twoprice;
                    }
                    else if (광개토.house == 4)
                    {
                        player4.money -= 광개토.threeprice;
                        player1.money += 광개토.threeprice;
                    }
                    else if (광개토.house == 5)
                    {
                        player4.money -= 광개토.landprice;
                        player1.money += 광개토.landprice;
                    }
                }
                UIScrean = false;
            }
            if (13 == distance4 % 40 && UIScrean)
            {
                if (장군총.host == 0 || 장군총.host == 4)
                {
                    장군총권리증.SetActive(true);
                }
                if (장군총.host == 2)
                {
                    if (장군총.house == 1)
                    {
                        player4.money -= 장군총.basicprice;
                        player2.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player4.money -= 장군총.oneprice;
                        player2.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player4.money -= 장군총.twoprice;
                        player2.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player4.money -= 장군총.threeprice;
                        player2.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player4.money -= 장군총.landprice;
                        player2.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 3)
                {
                    if (장군총.house == 1)
                    {
                        player4.money -= 장군총.basicprice;
                        player3.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player4.money -= 장군총.oneprice;
                        player3.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player4.money -= 장군총.twoprice;
                        player3.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player4.money -= 장군총.threeprice;
                        player3.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player4.money -= 장군총.landprice;
                        player3.money += 장군총.landprice;
                    }
                }
                else if (장군총.host == 1)
                {
                    if (장군총.house == 1)
                    {
                        player4.money -= 장군총.basicprice;
                        player1.money += 장군총.basicprice;
                    }
                    else if (장군총.house == 2)
                    {
                        player4.money -= 장군총.oneprice;
                        player1.money += 장군총.oneprice;
                    }
                    else if (장군총.house == 3)
                    {
                        player4.money -= 장군총.twoprice;
                        player1.money += 장군총.twoprice;
                    }
                    else if (장군총.house == 4)
                    {
                        player4.money -= 장군총.threeprice;
                        player1.money += 장군총.threeprice;
                    }
                    else if (장군총.house == 5)
                    {
                        player4.money -= 장군총.landprice;
                        player1.money += 장군총.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance4 % 40 && UIScrean)
            {
                if (무령왕릉.host == 0 || 무령왕릉.host == 4)
                {
                    무령왕릉권리증.SetActive(true);
                }
                if (무령왕릉.host == 2)
                {
                    if (무령왕릉.house == 1)
                    {
                        player4.money -= 무령왕릉.basicprice;
                        player2.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player4.money -= 무령왕릉.oneprice;
                        player2.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player4.money -= 무령왕릉.twoprice;
                        player2.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player4.money -= 무령왕릉.threeprice;
                        player2.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player4.money -= 무령왕릉.landprice;
                        player2.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 3)
                {
                    if (무령왕릉.house == 1)
                    {
                        player4.money -= 무령왕릉.basicprice;
                        player3.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player4.money -= 무령왕릉.oneprice;
                        player3.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player4.money -= 무령왕릉.twoprice;
                        player3.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player4.money -= 무령왕릉.threeprice;
                        player3.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player4.money -= 무령왕릉.landprice;
                        player3.money += 무령왕릉.landprice;
                    }
                }
                else if (무령왕릉.host == 1)
                {
                    if (무령왕릉.house == 1)
                    {
                        player4.money -= 무령왕릉.basicprice;
                        player1.money += 무령왕릉.basicprice;
                    }
                    else if (무령왕릉.house == 2)
                    {
                        player4.money -= 무령왕릉.oneprice;
                        player1.money += 무령왕릉.oneprice;
                    }
                    else if (무령왕릉.house == 3)
                    {
                        player4.money -= 무령왕릉.twoprice;
                        player1.money += 무령왕릉.twoprice;
                    }
                    else if (무령왕릉.house == 4)
                    {
                        player4.money -= 무령왕릉.threeprice;
                        player1.money += 무령왕릉.threeprice;
                    }
                    else if (무령왕릉.house == 5)
                    {
                        player4.money -= 무령왕릉.landprice;
                        player1.money += 무령왕릉.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance4 % 40 && UIScrean)
            {
                if (정림사.host == 0 || 정림사.host == 4)
                {
                    정림사권리증.SetActive(true);
                }
                if (정림사.host == 2)
                {
                    if (정림사.house == 1)
                    {
                        player4.money -= 정림사.basicprice;
                        player2.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player4.money -= 정림사.oneprice;
                        player2.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player4.money -= 정림사.twoprice;
                        player2.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player4.money -= 정림사.threeprice;
                        player2.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player4.money -= 정림사.landprice;
                        player2.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 3)
                {
                    if (정림사.house == 1)
                    {
                        player4.money -= 정림사.basicprice;
                        player3.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player4.money -= 정림사.oneprice;
                        player3.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player4.money -= 정림사.twoprice;
                        player3.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player4.money -= 정림사.threeprice;
                        player3.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player4.money -= 정림사.landprice;
                        player3.money += 정림사.landprice;
                    }
                }
                else if (정림사.host == 1)
                {
                    if (정림사.house == 1)
                    {
                        player4.money -= 정림사.basicprice;
                        player1.money += 정림사.basicprice;
                    }
                    else if (정림사.house == 2)
                    {
                        player4.money -= 정림사.oneprice;
                        player1.money += 정림사.oneprice;
                    }
                    else if (정림사.house == 3)
                    {
                        player4.money -= 정림사.twoprice;
                        player1.money += 정림사.twoprice;
                    }
                    else if (정림사.house == 4)
                    {
                        player4.money -= 정림사.threeprice;
                        player1.money += 정림사.threeprice;
                    }
                    else if (정림사.house == 5)
                    {
                        player4.money -= 정림사.landprice;
                        player1.money += 정림사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance4 % 40 && UIScrean)
            {
                if (첨성대.host == 0 || 첨성대.host == 4)
                {
                    Debug.Log("실행");
                    첨성대권리증.SetActive(true);
                }
                if (첨성대.host == 2)
                {
                    if (첨성대.house == 1)
                    {
                        player4.money -= 첨성대.basicprice;
                        player2.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player4.money -= 첨성대.oneprice;
                        player2.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player4.money -= 첨성대.twoprice;
                        player2.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player4.money -= 첨성대.threeprice;
                        player2.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player4.money -= 첨성대.landprice;
                        player2.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 3)
                {
                    if (첨성대.house == 1)
                    {
                        player4.money -= 첨성대.basicprice;
                        player3.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player4.money -= 첨성대.oneprice;
                        player3.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player4.money -= 첨성대.twoprice;
                        player3.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player4.money -= 첨성대.threeprice;
                        player3.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player4.money -= 첨성대.landprice;
                        player3.money += 첨성대.landprice;
                    }
                }
                else if (첨성대.host == 1)
                {
                    if (첨성대.house == 1)
                    {
                        player4.money -= 첨성대.basicprice;
                        player1.money += 첨성대.basicprice;
                    }
                    else if (첨성대.house == 2)
                    {
                        player4.money -= 첨성대.oneprice;
                        player1.money += 첨성대.oneprice;
                    }
                    else if (첨성대.house == 3)
                    {
                        player4.money -= 첨성대.twoprice;
                        player1.money += 첨성대.twoprice;
                    }
                    else if (첨성대.house == 4)
                    {
                        player4.money -= 첨성대.threeprice;
                        player1.money += 첨성대.threeprice;
                    }
                    else if (첨성대.house == 5)
                    {
                        player4.money -= 첨성대.landprice;
                        player1.money += 첨성대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance4 % 40 && UIScrean)
            {
                if (불국사.host == 0 || 불국사.host == 4)
                {
                    불국사권리증.SetActive(true);
                }
                if (불국사.host == 2)
                {
                    if (불국사.house == 1)
                    {
                        player4.money -= 불국사.basicprice;
                        player2.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player4.money -= 불국사.oneprice;
                        player2.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player4.money -= 불국사.twoprice;
                        player2.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player4.money -= 불국사.threeprice;
                        player2.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player4.money -= 불국사.landprice;
                        player2.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 3)
                {
                    if (불국사.house == 1)
                    {
                        player4.money -= 불국사.basicprice;
                        player3.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player4.money -= 불국사.oneprice;
                        player3.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player4.money -= 불국사.twoprice;
                        player3.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player4.money -= 불국사.threeprice;
                        player3.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player4.money -= 불국사.landprice;
                        player3.money += 불국사.landprice;
                    }
                }
                else if (불국사.host == 1)
                {
                    if (불국사.house == 1)
                    {
                        player4.money -= 불국사.basicprice;
                        player1.money += 불국사.basicprice;
                    }
                    else if (불국사.house == 2)
                    {
                        player4.money -= 불국사.oneprice;
                        player1.money += 불국사.oneprice;
                    }
                    else if (불국사.house == 3)
                    {
                        player4.money -= 불국사.twoprice;
                        player1.money += 불국사.twoprice;
                    }
                    else if (불국사.house == 4)
                    {
                        player4.money -= 불국사.threeprice;
                        player1.money += 불국사.threeprice;
                    }
                    else if (불국사.house == 5)
                    {
                        player4.money -= 불국사.landprice;
                        player1.money += 불국사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance4 % 40 && UIScrean)
            {
                if (해인사.host == 0 || 해인사.host == 4)
                {
                    해인사권리증.SetActive(true);
                }
                if (해인사.host == 2)
                {
                    if (해인사.house == 1)
                    {
                        player4.money -= 해인사.basicprice;
                        player2.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player4.money -= 해인사.oneprice;
                        player2.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player4.money -= 해인사.twoprice;
                        player2.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player4.money -= 해인사.threeprice;
                        player2.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player4.money -= 해인사.landprice;
                        player2.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 3)
                {
                    if (해인사.house == 1)
                    {
                        player4.money -= 해인사.basicprice;
                        player3.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player4.money -= 해인사.oneprice;
                        player3.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player4.money -= 해인사.twoprice;
                        player3.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player4.money -= 해인사.threeprice;
                        player3.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player4.money -= 해인사.landprice;
                        player3.money += 해인사.landprice;
                    }
                }
                else if (해인사.host == 1)
                {
                    if (해인사.house == 1)
                    {
                        player4.money -= 해인사.basicprice;
                        player1.money += 해인사.basicprice;
                    }
                    else if (해인사.house == 2)
                    {
                        player4.money -= 해인사.oneprice;
                        player1.money += 해인사.oneprice;
                    }
                    else if (해인사.house == 3)
                    {
                        player4.money -= 해인사.twoprice;
                        player1.money += 해인사.twoprice;
                    }
                    else if (해인사.house == 4)
                    {
                        player4.money -= 해인사.threeprice;
                        player1.money += 해인사.threeprice;
                    }
                    else if (해인사.house == 5)
                    {
                        player4.money -= 해인사.landprice;
                        player1.money += 해인사.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance4 % 40 && UIScrean)
            {
                if (처인성.host == 0 || 처인성.host == 4)
                {
                    처인성권리증.SetActive(true);
                }
                if (처인성.host == 2)
                {
                    if (처인성.house == 1)
                    {
                        player4.money -= 처인성.basicprice;
                        player2.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player4.money -= 처인성.oneprice;
                        player2.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player4.money -= 처인성.twoprice;
                        player2.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player4.money -= 처인성.threeprice;
                        player2.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player4.money -= 처인성.landprice;
                        player2.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 3)
                {
                    if (처인성.house == 1)
                    {
                        player4.money -= 처인성.basicprice;
                        player3.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player4.money -= 처인성.oneprice;
                        player3.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player4.money -= 처인성.twoprice;
                        player3.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player4.money -= 처인성.threeprice;
                        player3.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player4.money -= 처인성.landprice;
                        player3.money += 처인성.landprice;
                    }
                }
                else if (처인성.host == 1)
                {
                    if (처인성.house == 1)
                    {
                        player4.money -= 처인성.basicprice;
                        player1.money += 처인성.basicprice;
                    }
                    else if (처인성.house == 2)
                    {
                        player4.money -= 처인성.oneprice;
                        player1.money += 처인성.oneprice;
                    }
                    else if (처인성.house == 3)
                    {
                        player4.money -= 처인성.twoprice;
                        player1.money += 처인성.twoprice;
                    }
                    else if (처인성.house == 4)
                    {
                        player4.money -= 처인성.threeprice;
                        player1.money += 처인성.threeprice;
                    }
                    else if (처인성.house == 5)
                    {
                        player4.money -= 처인성.landprice;
                        player1.money += 처인성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance4 % 40 && UIScrean)
            {
                if (천리장성.host == 0 || 천리장성.host == 4)
                {
                    천리장성권리증.SetActive(true);
                }
                if (천리장성.host == 2)
                {
                    if (천리장성.house == 1)
                    {
                        player4.money -= 천리장성.basicprice;
                        player2.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player4.money -= 천리장성.oneprice;
                        player2.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player4.money -= 천리장성.twoprice;
                        player2.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player4.money -= 천리장성.threeprice;
                        player2.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player4.money -= 천리장성.landprice;
                        player2.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 3)
                {
                    if (천리장성.house == 1)
                    {
                        player4.money -= 천리장성.basicprice;
                        player3.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player4.money -= 천리장성.oneprice;
                        player3.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player4.money -= 천리장성.twoprice;
                        player3.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player4.money -= 천리장성.threeprice;
                        player3.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player4.money -= 천리장성.landprice;
                        player3.money += 천리장성.landprice;
                    }
                }
                else if (천리장성.host == 1)
                {
                    if (천리장성.house == 1)
                    {
                        player4.money -= 천리장성.basicprice;
                        player1.money += 천리장성.basicprice;
                    }
                    else if (천리장성.house == 2)
                    {
                        player4.money -= 천리장성.oneprice;
                        player1.money += 천리장성.oneprice;
                    }
                    else if (천리장성.house == 3)
                    {
                        player4.money -= 천리장성.twoprice;
                        player1.money += 천리장성.twoprice;
                    }
                    else if (천리장성.house == 4)
                    {
                        player4.money -= 천리장성.threeprice;
                        player1.money += 천리장성.threeprice;
                    }
                    else if (천리장성.house == 5)
                    {
                        player4.money -= 천리장성.landprice;
                        player1.money += 천리장성.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance4 % 40 && UIScrean)
            {
                if (경복궁.host == 0 || 경복궁.host == 4)
                {
                    경복궁권리증.SetActive(true);
                }
                if (경복궁.host == 2)
                {
                    if (경복궁.house == 1)
                    {
                        player4.money -= 경복궁.basicprice;
                        player2.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player4.money -= 경복궁.oneprice;
                        player2.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player4.money -= 경복궁.twoprice;
                        player2.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player4.money -= 경복궁.threeprice;
                        player2.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player4.money -= 경복궁.landprice;
                        player2.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 3)
                {
                    if (경복궁.house == 1)
                    {
                        player4.money -= 경복궁.basicprice;
                        player3.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player4.money -= 경복궁.oneprice;
                        player3.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player4.money -= 경복궁.twoprice;
                        player3.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player4.money -= 경복궁.threeprice;
                        player3.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player4.money -= 경복궁.landprice;
                        player3.money += 경복궁.landprice;
                    }
                }
                else if (경복궁.host == 1)
                {
                    if (경복궁.house == 1)
                    {
                        player4.money -= 경복궁.basicprice;
                        player1.money += 경복궁.basicprice;
                    }
                    else if (경복궁.house == 2)
                    {
                        player4.money -= 경복궁.oneprice;
                        player1.money += 경복궁.oneprice;
                    }
                    else if (경복궁.house == 3)
                    {
                        player4.money -= 경복궁.twoprice;
                        player1.money += 경복궁.twoprice;
                    }
                    else if (경복궁.house == 4)
                    {
                        player4.money -= 경복궁.threeprice;
                        player1.money += 경복궁.threeprice;
                    }
                    else if (경복궁.house == 5)
                    {
                        player4.money -= 경복궁.landprice;
                        player1.money += 경복궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance4 % 40 && UIScrean)
            {
                if (집현전.host == 0 || 집현전.host == 4)
                {
                    집현전권리증.SetActive(true);
                }
                if (집현전.host == 2)
                {
                    if (집현전.house == 1)
                    {
                        player4.money -= 집현전.basicprice;
                        player2.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player4.money -= 집현전.oneprice;
                        player2.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player4.money -= 집현전.twoprice;
                        player2.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player4.money -= 집현전.threeprice;
                        player2.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player4.money -= 집현전.landprice;
                        player2.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 3)
                {
                    if (집현전.house == 1)
                    {
                        player4.money -= 집현전.basicprice;
                        player3.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player4.money -= 집현전.oneprice;
                        player3.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player4.money -= 집현전.twoprice;
                        player3.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player4.money -= 집현전.threeprice;
                        player3.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player4.money -= 집현전.landprice;
                        player3.money += 집현전.landprice;
                    }
                }
                else if (집현전.host == 1)
                {
                    if (집현전.house == 1)
                    {
                        player4.money -= 집현전.basicprice;
                        player1.money += 집현전.basicprice;
                    }
                    else if (집현전.house == 2)
                    {
                        player4.money -= 집현전.oneprice;
                        player1.money += 집현전.oneprice;
                    }
                    else if (집현전.house == 3)
                    {
                        player4.money -= 집현전.twoprice;
                        player1.money += 집현전.twoprice;
                    }
                    else if (집현전.house == 4)
                    {
                        player4.money -= 집현전.threeprice;
                        player1.money += 집현전.threeprice;
                    }
                    else if (집현전.house == 5)
                    {
                        player4.money -= 집현전.landprice;
                        player1.money += 집현전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (29 == distance4 % 40 && UIScrean)
            {
                if (창덕궁.host == 0 || 창덕궁.host == 4)
                {
                    창덕궁권리증.SetActive(true);
                }
                if (창덕궁.host == 2)
                {
                    if (창덕궁.house == 1)
                    {
                        player4.money -= 창덕궁.basicprice;
                        player2.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player4.money -= 창덕궁.oneprice;
                        player2.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player4.money -= 창덕궁.twoprice;
                        player2.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player4.money -= 창덕궁.threeprice;
                        player2.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player4.money -= 창덕궁.landprice;
                        player2.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 3)
                {
                    if (창덕궁.house == 1)
                    {
                        player4.money -= 창덕궁.basicprice;
                        player3.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player4.money -= 창덕궁.oneprice;
                        player3.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player4.money -= 창덕궁.twoprice;
                        player3.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player4.money -= 창덕궁.threeprice;
                        player3.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player4.money -= 창덕궁.landprice;
                        player3.money += 창덕궁.landprice;
                    }
                }
                else if (창덕궁.host == 1)
                {
                    if (창덕궁.house == 1)
                    {
                        player4.money -= 창덕궁.basicprice;
                        player1.money += 창덕궁.basicprice;
                    }
                    else if (창덕궁.house == 2)
                    {
                        player4.money -= 창덕궁.oneprice;
                        player1.money += 창덕궁.oneprice;
                    }
                    else if (창덕궁.house == 3)
                    {
                        player4.money -= 창덕궁.twoprice;
                        player1.money += 창덕궁.twoprice;
                    }
                    else if (창덕궁.house == 4)
                    {
                        player4.money -= 창덕궁.threeprice;
                        player1.money += 창덕궁.threeprice;
                    }
                    else if (창덕궁.house == 5)
                    {
                        player4.money -= 창덕궁.landprice;
                        player1.money += 창덕궁.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance4 % 40 && UIScrean)
            {
                if (명동성당.host == 0 || 명동성당.host == 4)
                {
                    명동성당권리증.SetActive(true);
                }
                if (명동성당.host == 2)
                {
                    if (명동성당.house == 1)
                    {
                        player4.money -= 명동성당.basicprice;
                        player2.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player4.money -= 명동성당.oneprice;
                        player2.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player4.money -= 명동성당.twoprice;
                        player2.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player4.money -= 명동성당.threeprice;
                        player2.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player4.money -= 명동성당.landprice;
                        player2.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 3)
                {
                    if (명동성당.house == 1)
                    {
                        player4.money -= 명동성당.basicprice;
                        player3.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player4.money -= 명동성당.oneprice;
                        player3.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player4.money -= 명동성당.twoprice;
                        player3.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player4.money -= 명동성당.threeprice;
                        player3.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player4.money -= 명동성당.landprice;
                        player3.money += 명동성당.landprice;
                    }
                }
                else if (명동성당.host == 1)
                {
                    if (명동성당.house == 1)
                    {
                        player4.money -= 명동성당.basicprice;
                        player1.money += 명동성당.basicprice;
                    }
                    else if (명동성당.house == 2)
                    {
                        player4.money -= 명동성당.oneprice;
                        player1.money += 명동성당.oneprice;
                    }
                    else if (명동성당.house == 3)
                    {
                        player4.money -= 명동성당.twoprice;
                        player1.money += 명동성당.twoprice;
                    }
                    else if (명동성당.house == 4)
                    {
                        player4.money -= 명동성당.threeprice;
                        player1.money += 명동성당.threeprice;
                    }
                    else if (명동성당.house == 5)
                    {
                        player4.money -= 명동성당.landprice;
                        player1.money += 명동성당.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance4 % 40 && UIScrean)
            {
                if (석조전.host == 0 || 석조전.host == 4)
                {
                    석조전권리증.SetActive(true);
                }
                if (석조전.host == 2)
                {
                    if (석조전.house == 1)
                    {
                        player4.money -= 석조전.basicprice;
                        player2.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player4.money -= 석조전.oneprice;
                        player2.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player4.money -= 석조전.twoprice;
                        player2.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player4.money -= 석조전.threeprice;
                        player2.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player4.money -= 석조전.landprice;
                        player2.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 3)
                {
                    if (석조전.house == 1)
                    {
                        player4.money -= 석조전.basicprice;
                        player3.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player4.money -= 석조전.oneprice;
                        player3.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player4.money -= 석조전.twoprice;
                        player3.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player4.money -= 석조전.threeprice;
                        player3.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player4.money -= 석조전.landprice;
                        player3.money += 석조전.landprice;
                    }
                }
                else if (석조전.host == 1)
                {
                    if (석조전.house == 1)
                    {
                        player4.money -= 석조전.basicprice;
                        player1.money += 석조전.basicprice;
                    }
                    else if (석조전.house == 2)
                    {
                        player4.money -= 석조전.oneprice;
                        player1.money += 석조전.oneprice;
                    }
                    else if (석조전.house == 3)
                    {
                        player4.money -= 석조전.twoprice;
                        player1.money += 석조전.twoprice;
                    }
                    else if (석조전.house == 4)
                    {
                        player4.money -= 석조전.threeprice;
                        player1.money += 석조전.threeprice;
                    }
                    else if (석조전.house == 5)
                    {
                        player4.money -= 석조전.landprice;
                        player1.money += 석조전.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance4 % 40 && UIScrean)
            {
                if (가덕도등대.host == 0 || 가덕도등대.host == 4)
                {
                    가덕도등대권리증.SetActive(true);
                }
                if (가덕도등대.host == 2)
                {
                    if (가덕도등대.house == 1)
                    {
                        player4.money -= 가덕도등대.basicprice;
                        player2.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player4.money -= 가덕도등대.oneprice;
                        player2.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player4.money -= 가덕도등대.twoprice;
                        player2.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player4.money -= 가덕도등대.threeprice;
                        player2.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player4.money -= 가덕도등대.landprice;
                        player2.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 3)
                {
                    if (가덕도등대.house == 1)
                    {
                        player4.money -= 가덕도등대.basicprice;
                        player3.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player4.money -= 가덕도등대.oneprice;
                        player3.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player4.money -= 가덕도등대.twoprice;
                        player3.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player4.money -= 가덕도등대.threeprice;
                        player3.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player4.money -= 가덕도등대.landprice;
                        player3.money += 가덕도등대.landprice;
                    }
                }
                else if (가덕도등대.host == 1)
                {
                    if (가덕도등대.house == 1)
                    {
                        player4.money -= 가덕도등대.basicprice;
                        player1.money += 가덕도등대.basicprice;
                    }
                    else if (가덕도등대.house == 2)
                    {
                        player4.money -= 가덕도등대.oneprice;
                        player1.money += 가덕도등대.oneprice;
                    }
                    else if (가덕도등대.house == 3)
                    {
                        player4.money -= 가덕도등대.twoprice;
                        player1.money += 가덕도등대.twoprice;
                    }
                    else if (가덕도등대.house == 4)
                    {
                        player4.money -= 가덕도등대.threeprice;
                        player1.money += 가덕도등대.threeprice;
                    }
                    else if (가덕도등대.house == 5)
                    {
                        player4.money -= 가덕도등대.landprice;
                        player1.money += 가덕도등대.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance4 % 40 && UIScrean)
            {
                if (인천.host == 0 || 인천.host == 4)
                {
                    인천권리증.SetActive(true);
                }
                if (인천.host == 2)
                {
                    if (인천.house == 1)
                    {
                        player4.money -= 인천.basicprice;
                        player2.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player4.money -= 인천.oneprice;
                        player2.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player4.money -= 인천.twoprice;
                        player2.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player4.money -= 인천.threeprice;
                        player2.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player4.money -= 인천.landprice;
                        player2.money += 인천.landprice;
                    }
                }
                else if (인천.host == 3)
                {
                    if (인천.house == 1)
                    {
                        player4.money -= 인천.basicprice;
                        player3.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player4.money -= 인천.oneprice;
                        player3.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player4.money -= 인천.twoprice;
                        player3.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player4.money -= 인천.threeprice;
                        player3.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player4.money -= 인천.landprice;
                        player3.money += 인천.landprice;
                    }
                }
                else if (인천.host == 1)
                {
                    if (인천.house == 1)
                    {
                        player4.money -= 인천.basicprice;
                        player1.money += 인천.basicprice;
                    }
                    else if (인천.house == 2)
                    {
                        player4.money -= 인천.oneprice;
                        player1.money += 인천.oneprice;
                    }
                    else if (인천.house == 3)
                    {
                        player4.money -= 인천.twoprice;
                        player1.money += 인천.twoprice;
                    }
                    else if (인천.house == 4)
                    {
                        player4.money -= 인천.threeprice;
                        player1.money += 인천.threeprice;
                    }
                    else if (인천.house == 5)
                    {
                        player4.money -= 인천.landprice;
                        player1.money += 인천.landprice;
                    }
                }
                UIScrean = false;

            }
            if (39 == distance4 % 40 && UIScrean)
            {
                if (서울.host == 0 || 서울.host == 4)
                {
                    서울권리증.SetActive(true);
                }
                if (서울.host == 2)
                {
                    if (서울.house == 1)
                    {
                        player4.money -= 서울.basicprice;
                        player2.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player4.money -= 서울.oneprice;
                        player2.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player4.money -= 서울.twoprice;
                        player2.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player4.money -= 서울.threeprice;
                        player2.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player4.money -= 서울.landprice;
                        player2.money += 서울.landprice;
                    }
                }
                else if (서울.host == 3)
                {
                    if (서울.house == 1)
                    {
                        player4.money -= 서울.basicprice;
                        player3.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player4.money -= 서울.oneprice;
                        player3.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player4.money -= 서울.twoprice;
                        player3.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player4.money -= 서울.threeprice;
                        player3.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player4.money -= 서울.landprice;
                        player3.money += 서울.landprice;
                    }
                }
                else if (서울.host == 1)
                {
                    if (서울.house == 1)
                    {
                        player4.money -= 서울.basicprice;
                        player1.money += 서울.basicprice;
                    }
                    else if (서울.house == 2)
                    {
                        player4.money -= 서울.oneprice;
                        player1.money += 서울.oneprice;
                    }
                    else if (서울.house == 3)
                    {
                        player4.money -= 서울.twoprice;
                        player1.money += 서울.twoprice;
                    }
                    else if (서울.house == 4)
                    {
                        player4.money -= 서울.threeprice;
                        player1.money += 서울.threeprice;
                    }
                    else if (서울.house == 5)
                    {
                        player4.money -= 서울.landprice;
                        player1.money += 서울.landprice;
                    }
                }
                UIScrean = false;

            }
            if (4 == distance4 % 40 && UIScrean)
            {
                재난카드1.SetActive(true);
                UIScrean = false;
            }
            if (12 == distance4 % 40 && UIScrean)
            {
                재난카드2.SetActive(true);
                UIScrean = false;
            }
            if (28 == distance4 % 40 && UIScrean)
            {
                재난카드3.SetActive(true);
                UIScrean = false;
            }
            if (38 == distance4 % 40 && UIScrean)
            {
                재난카드4.SetActive(true);
                UIScrean = false;
            }
            if (5 == distance4 % 40 && UIScrean)
            {
                if (무기.host == 0)
                {
                    무기1.SetActive(true);
                }
                else if (무기.host == 1)
                {
                    player4.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host == 3)
                {
                    player4.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host == 2)
                {
                    player4.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance4 % 40 && UIScrean)
            {
                if (무기.host2 == 0)
                {
                    무기2.SetActive(true);
                }
                else if (무기.host2 == 1)
                {
                    player4.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host2 == 3)
                {
                    player4.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host2 == 2)
                {
                    player4.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance4 % 40 && UIScrean)
            {
                if (무기.host3 == 0)
                {
                    무기3.SetActive(true);
                }
                else if (무기.host3 == 1)
                {
                    player4.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host3 == 3)
                {
                    player4.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host3 == 2)
                {
                    player4.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance4 % 40 && UIScrean)
            {
                if (무기.host4 == 0)
                {
                    무기4.SetActive(true);
                }
                else if (무기.host4 == 1)
                {
                    player4.money -= 무기.weapon1 * 100;
                    player1.money += 무기.weapon1 * 100;
                }
                else if (무기.host4 == 3)
                {
                    player4.money -= 무기.weapon3 * 100;
                    player3.money += 무기.weapon3 * 100;
                }
                else if (무기.host4 == 2)
                {
                    player4.money -= 무기.weapon2 * 100;
                    player2.money += 무기.weapon2 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance4 % 40 || 17 == distance4 % 40 || 33 == distance4) && UIScrean)
            {
                사회기금.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance4 % 40 || 22 == distance4 % 40 || 36 == distance4) && UIScrean)
            {
                찬스카드.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance4 % 40 && UIScrean)
            {
                타임머신.SetActive(true);
                UIScrean = false;
            }
            if (동굴권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                동굴권리증.SetActive(false);
                //UIScrean = true;
            }
            else if (지하움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지하움집권리증.SetActive(false);
            }
            else if (지상움집권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                지상움집권리증.SetActive(false);
            }
            else if (고인돌권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                고인돌권리증.SetActive(false);
            }
            else if (부뚜막권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                부뚜막권리증.SetActive(false);
            }
            else if (광개토권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                광개토권리증.SetActive(false);
            }
            else if (장군총권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                장군총권리증.SetActive(false);
            }
            else if (무령왕릉권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무령왕릉권리증.SetActive(false);
            }
            else if (정림사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                정림사권리증.SetActive(false);
            }
            else if (첨성대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                첨성대권리증.SetActive(false);
            }
            else if (불국사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                불국사권리증.SetActive(false);
            }
            else if (해인사권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                해인사권리증.SetActive(false);
            }
            else if (처인성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                처인성권리증.SetActive(false);
            }
            else if (천리장성권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                천리장성권리증.SetActive(false);
            }
            else if (경복궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                경복궁권리증.SetActive(false);
            }
            else if (집현전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                집현전권리증.SetActive(false);
            }
            else if (창덕궁권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                창덕궁권리증.SetActive(false);
            }
            else if (명동성당권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                명동성당권리증.SetActive(false);
            }
            else if (석조전권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                석조전권리증.SetActive(false);
            }
            else if (가덕도등대권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                가덕도등대권리증.SetActive(false);
            }
            else if (인천권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                인천권리증.SetActive(false);
            }
            else if (서울권리증.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                서울권리증.SetActive(false);
            }
            else if (재난카드1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드1.SetActive(false);
            }
            else if (재난카드2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드2.SetActive(false);
            }
            else if (재난카드3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드3.SetActive(false);
            }
            else if (재난카드4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                재난카드4.SetActive(false);
            }
            else if (무기1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기1.SetActive(false);
            }
            else if (무기2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기2.SetActive(false);
            }
            else if (무기3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기3.SetActive(false);
            }
            else if (무기4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                무기4.SetActive(false);
            }
            else if (사회기금.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                사회기금.SetActive(false);
            }
            else if (찬스카드.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                찬스카드.SetActive(false);
            }
        }
    }
}