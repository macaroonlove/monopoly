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
    int ����ĭ1 = 40;
    int ����ĭ2 = 40;
    int ����ĭ3 = 40;
    int ����ĭ4 = 40;
    public GameObject menuSet;
    //int dnumber;
    void Start()
    {
        UIScrean = true;
        //Debug.Log("������ ������");
    }

    void FixedUpdate()
    {
        //Debug.Log(UIScrean);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject �÷��̾�1 = GameObject.Find("Stone").transform.Find("human2").gameObject;
        GameObject �÷��̾�2 = GameObject.Find("Stone2").transform.Find("����").gameObject;
        GameObject �÷��̾�3 = GameObject.Find("Stone3").transform.Find("r7").gameObject;
        GameObject �÷��̾�4 = GameObject.Find("Stone4").transform.Find("��������").gameObject;
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
            �÷��̾�1.SetActive(false);
        }
        if (player2.money < 0)
        {
            �÷��̾�2.SetActive(false);
        }
        if (player3.money < 0)
        {
            �÷��̾�3.SetActive(false);
        }
        if (player4.money < 0)
        {
            �÷��̾�4.SetActive(false);
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
        GameObject �����Ǹ��� = GameObject.Find("UI����").transform.Find("����UI").gameObject;
        GameObject ���Ͽ����Ǹ��� = GameObject.Find("UI����").transform.Find("���Ͽ���UI").gameObject;
        GameObject ��������Ǹ��� = GameObject.Find("UI����").transform.Find("�������UI").gameObject;
        GameObject ���ε��Ǹ��� = GameObject.Find("UI����").transform.Find("���ε�UI").gameObject;
        GameObject �ζѸ��Ǹ��� = GameObject.Find("UI����").transform.Find("�ζѸ�UI").gameObject;
        GameObject ������Ǹ��� = GameObject.Find("UI����").transform.Find("������UI").gameObject;
        GameObject �屺�ѱǸ��� = GameObject.Find("UI����").transform.Find("�屺��UI").gameObject;
        GameObject ���ɿո��Ǹ��� = GameObject.Find("UI����").transform.Find("���ɿո�UI").gameObject;
        GameObject ������Ǹ��� = GameObject.Find("UI����").transform.Find("������UI").gameObject;
        GameObject ÷����Ǹ��� = GameObject.Find("UI����").transform.Find("÷����UI").gameObject;
        GameObject �ұ���Ǹ��� = GameObject.Find("UI����").transform.Find("�ұ���UI").gameObject;
        GameObject ���λ�Ǹ��� = GameObject.Find("UI����").transform.Find("���λ�UI").gameObject;
        GameObject ó�μ��Ǹ��� = GameObject.Find("UI����").transform.Find("ó�μ�UI").gameObject;
        GameObject õ���强�Ǹ��� = GameObject.Find("UI����").transform.Find("õ���强UI").gameObject;
        GameObject �溹�ñǸ��� = GameObject.Find("UI����").transform.Find("�溹��UI").gameObject;
        GameObject �������Ǹ��� = GameObject.Find("UI����").transform.Find("������UI").gameObject;
        GameObject â���ñǸ��� = GameObject.Find("UI����").transform.Find("â����UI").gameObject;
        GameObject ������Ǹ��� = GameObject.Find("UI����").transform.Find("������UI").gameObject;
        GameObject �������Ǹ��� = GameObject.Find("UI����").transform.Find("������UI").gameObject;
        GameObject ���������Ǹ��� = GameObject.Find("UI����").transform.Find("���������UI").gameObject;
        GameObject ��õ�Ǹ��� = GameObject.Find("UI����").transform.Find("��õUI").gameObject;
        GameObject ����Ǹ��� = GameObject.Find("UI����").transform.Find("����UI").gameObject;
        GameObject �糭ī��1 = GameObject.Find("UI����").transform.Find("�糭ī��1UI").gameObject;
        GameObject �糭ī��2 = GameObject.Find("UI����").transform.Find("�糭ī��2UI").gameObject;
        GameObject �糭ī��3 = GameObject.Find("UI����").transform.Find("�糭ī��3UI").gameObject;
        GameObject �糭ī��4 = GameObject.Find("UI����").transform.Find("�糭ī��4UI").gameObject;
        GameObject ����1 = GameObject.Find("UI����").transform.Find("û����UI").gameObject;
        GameObject ����2 = GameObject.Find("UI����").transform.Find("ĥ����UI").gameObject;
        GameObject ����3 = GameObject.Find("UI����").transform.Find("�ű���UI").gameObject;
        GameObject ����4 = GameObject.Find("UI����").transform.Find("õ��UI").gameObject;
        GameObject ��ȸ��� = GameObject.Find("UI����").transform.Find("��ȸ���UI").gameObject;
        GameObject Ÿ�Ӹӽ� = GameObject.Find("UI����").transform.Find("Ÿ�Ӹӽ�UI").gameObject;
        GameObject ����ī�� = GameObject.Find("UI����").transform.Find("����ī��UI").gameObject;

        if (distance >= ����ĭ1)
        {
            player1.money += 500;
            ����ĭ1 += 40;
            //UIScrean = false;
        }
        if (distance2 >= ����ĭ2)
        {
            player2.money += 500;
            ����ĭ2 += 40;
            //UIScrean = false;
        }
        if (distance3 >= ����ĭ3)
        {
            player3.money += 500;
            ����ĭ3 += 40;
            //UIScrean = false;
        }
        if (distance4 >= ����ĭ4)
        {
            player4.money += 500;
            ����ĭ4 += 40;
            //UIScrean = false;
        }
        //Debug.Log(DiceScript.order);
        if (DiceScript.order == 2)
        {
            if (1 == distance % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 1)
                {
                    �����Ǹ���.SetActive(true);
                }
                if (����.host == 2)
                {
                    if (����.house == 1)
                    {
                        player1.money -= ����.basicprice;
                        player2.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player1.money -= ����.oneprice;
                        player2.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player1.money -= ����.twoprice;
                        player2.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player1.money -= ����.threeprice;
                        player2.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player1.money -= ����.landprice;
                        player2.money += ����.landprice;
                    }
                }
                else if (����.host == 3)
                {
                    if (����.house == 1)
                    {
                        player1.money -= ����.basicprice;
                        player3.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player1.money -= ����.oneprice;
                        player3.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player1.money -= ����.twoprice;
                        player3.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player1.money -= ����.threeprice;
                        player3.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player1.money -= ����.landprice;
                        player3.money += ����.landprice;
                    }
                }
                else if (����.host == 4)
                {
                    if (����.house == 1)
                    {
                        player1.money -= ����.basicprice;
                        player4.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player1.money -= ����.oneprice;
                        player4.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player1.money -= ����.twoprice;
                        player4.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player1.money -= ����.threeprice;
                        player4.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player1.money -= ����.landprice;
                        player4.money += ����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance % 40 && UIScrean)
            {
                if (���Ͽ���.host == 0 || ���Ͽ���.host == 1)
                {
                    ���Ͽ����Ǹ���.SetActive(true);
                }
                if (���Ͽ���.host == 2)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player1.money -= ���Ͽ���.basicprice;
                        player2.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player1.money -= ���Ͽ���.oneprice;
                        player2.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player1.money -= ���Ͽ���.twoprice;
                        player2.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player1.money -= ���Ͽ���.threeprice;
                        player2.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player1.money -= ���Ͽ���.landprice;
                        player2.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 3)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player1.money -= ���Ͽ���.basicprice;
                        player3.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player1.money -= ���Ͽ���.oneprice;
                        player3.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player1.money -= ���Ͽ���.twoprice;
                        player3.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player1.money -= ���Ͽ���.threeprice;
                        player3.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player1.money -= ���Ͽ���.landprice;
                        player3.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 4)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player1.money -= ���Ͽ���.basicprice;
                        player4.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player1.money -= ���Ͽ���.oneprice;
                        player4.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player1.money -= ���Ͽ���.twoprice;
                        player4.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player1.money -= ���Ͽ���.threeprice;
                        player4.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player1.money -= ���Ͽ���.landprice;
                        player4.money += ���Ͽ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (4 == distance % 40 && UIScrean)
            {
                �糭ī��1.SetActive(true);
                UIScrean = false;
            }
            if (6 == distance % 40 && UIScrean)
            {
                if (�������.host == 0 || �������.host == 1)
                {
                    ��������Ǹ���.SetActive(true);
                }
                if (�������.host == 2)
                {
                    if (�������.house == 1)
                    {
                        player1.money -= �������.basicprice;
                        player2.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player1.money -= �������.oneprice;
                        player2.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player1.money -= �������.twoprice;
                        player2.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player1.money -= �������.threeprice;
                        player2.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player1.money -= �������.landprice;
                        player2.money += �������.landprice;
                    }
                }
                else if (�������.host == 3)
                {
                    if (�������.house == 1)
                    {
                        player1.money -= �������.basicprice;
                        player3.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player1.money -= �������.oneprice;
                        player3.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player1.money -= �������.twoprice;
                        player3.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player1.money -= �������.threeprice;
                        player3.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player1.money -= �������.landprice;
                        player3.money += �������.landprice;
                    }
                }
                else if (�������.host == 4)
                {
                    if (�������.house == 1)
                    {
                        player1.money -= �������.basicprice;
                        player4.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player1.money -= �������.oneprice;
                        player4.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player1.money -= �������.twoprice;
                        player4.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player1.money -= �������.threeprice;
                        player4.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player1.money -= �������.landprice;
                        player4.money += �������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance % 40 && UIScrean)
            {
                if (���ε�.host == 0 || ���ε�.host == 1)
                {
                    ���ε��Ǹ���.SetActive(true);
                }
                if (���ε�.host == 2)
                {
                    if (���ε�.house == 1)
                    {
                        player1.money -= ���ε�.basicprice;
                        player2.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player1.money -= ���ε�.oneprice;
                        player2.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player1.money -= ���ε�.twoprice;
                        player2.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player1.money -= ���ε�.threeprice;
                        player2.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player1.money -= ���ε�.landprice;
                        player2.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 3)
                {
                    if (���ε�.house == 1)
                    {
                        player1.money -= ���ε�.basicprice;
                        player3.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player1.money -= ���ε�.oneprice;
                        player3.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player1.money -= ���ε�.twoprice;
                        player3.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player1.money -= ���ε�.threeprice;
                        player3.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player1.money -= ���ε�.landprice;
                        player3.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 4)
                {
                    if (���ε�.house == 1)
                    {
                        player1.money -= ���ε�.basicprice;
                        player4.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player1.money -= ���ε�.oneprice;
                        player4.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player1.money -= ���ε�.twoprice;
                        player4.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player1.money -= ���ε�.threeprice;
                        player4.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player1.money -= ���ε�.landprice;
                        player4.money += ���ε�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance % 40 && UIScrean)
            {
                if (�ζѸ�.host == 0 || �ζѸ�.host == 1)
                {
                    �ζѸ��Ǹ���.SetActive(true);
                }
                if (�ζѸ�.host == 2)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player1.money -= �ζѸ�.basicprice;
                        player2.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player1.money -= �ζѸ�.oneprice;
                        player2.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player1.money -= �ζѸ�.twoprice;
                        player2.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player1.money -= �ζѸ�.threeprice;
                        player2.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player1.money -= �ζѸ�.landprice;
                        player2.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 3)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player1.money -= �ζѸ�.basicprice;
                        player3.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player1.money -= �ζѸ�.oneprice;
                        player3.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player1.money -= �ζѸ�.twoprice;
                        player3.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player1.money -= �ζѸ�.threeprice;
                        player3.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player1.money -= �ζѸ�.landprice;
                        player3.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 4)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player1.money -= �ζѸ�.basicprice;
                        player4.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player1.money -= �ζѸ�.oneprice;
                        player4.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player1.money -= �ζѸ�.twoprice;
                        player4.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player1.money -= �ζѸ�.threeprice;
                        player4.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player1.money -= �ζѸ�.landprice;
                        player4.money += �ζѸ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 1)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (12 == distance % 40 && UIScrean)
            {
                �糭ī��2.SetActive(true);
                UIScrean = false;
            }
            if (13 == distance % 40 && UIScrean)
            {
                if (�屺��.host == 0 || �屺��.host == 1)
                {
                    �屺�ѱǸ���.SetActive(true);
                }
                if (�屺��.host == 2)
                {
                    if (�屺��.house == 1)
                    {
                        player1.money -= �屺��.basicprice;
                        player2.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player1.money -= �屺��.oneprice;
                        player2.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player1.money -= �屺��.twoprice;
                        player2.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player1.money -= �屺��.threeprice;
                        player2.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player1.money -= �屺��.landprice;
                        player2.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 3)
                {
                    if (�屺��.house == 1)
                    {
                        player1.money -= �屺��.basicprice;
                        player3.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player1.money -= �屺��.oneprice;
                        player3.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player1.money -= �屺��.twoprice;
                        player3.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player1.money -= �屺��.threeprice;
                        player3.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player1.money -= �屺��.landprice;
                        player3.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 4)
                {
                    if (�屺��.house == 1)
                    {
                        player1.money -= �屺��.basicprice;
                        player4.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player1.money -= �屺��.oneprice;
                        player4.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player1.money -= �屺��.twoprice;
                        player4.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player1.money -= �屺��.threeprice;
                        player4.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player1.money -= �屺��.landprice;
                        player4.money += �屺��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance % 40 && UIScrean)
            {
                if (���ɿո�.host == 0 || ���ɿո�.host == 1)
                {
                    ���ɿո��Ǹ���.SetActive(true);
                }
                if (���ɿո�.host == 2)
                {
                    if (���ɿո�.house == 1)
                    {
                        player1.money -= ���ɿո�.basicprice;
                        player2.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player1.money -= ���ɿո�.oneprice;
                        player2.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player1.money -= ���ɿո�.twoprice;
                        player2.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player1.money -= ���ɿո�.threeprice;
                        player2.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player1.money -= ���ɿո�.landprice;
                        player2.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 3)
                {
                    if (���ɿո�.house == 1)
                    {
                        player1.money -= ���ɿո�.basicprice;
                        player3.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player1.money -= ���ɿո�.oneprice;
                        player3.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player1.money -= ���ɿո�.twoprice;
                        player3.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player1.money -= ���ɿո�.threeprice;
                        player3.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player1.money -= ���ɿո�.landprice;
                        player3.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 4)
                {
                    if (���ɿո�.house == 1)
                    {
                        player1.money -= ���ɿո�.basicprice;
                        player4.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player1.money -= ���ɿո�.oneprice;
                        player4.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player1.money -= ���ɿո�.twoprice;
                        player4.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player1.money -= ���ɿո�.threeprice;
                        player4.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player1.money -= ���ɿո�.landprice;
                        player4.money += ���ɿո�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 1)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance % 40 && UIScrean)
            {
                if (÷����.host == 0 || ÷����.host == 1)
                {
                    ÷����Ǹ���.SetActive(true);
                }
                if (÷����.host == 2)
                {
                    if (÷����.house == 1)
                    {
                        player1.money -= ÷����.basicprice;
                        player2.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player1.money -= ÷����.oneprice;
                        player2.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player1.money -= ÷����.twoprice;
                        player2.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player1.money -= ÷����.threeprice;
                        player2.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player1.money -= ÷����.landprice;
                        player2.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 3)
                {
                    if (÷����.house == 1)
                    {
                        player1.money -= ÷����.basicprice;
                        player3.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player1.money -= ÷����.oneprice;
                        player3.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player1.money -= ÷����.twoprice;
                        player3.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player1.money -= ÷����.threeprice;
                        player3.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player1.money -= ÷����.landprice;
                        player3.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 4)
                {
                    if (÷����.house == 1)
                    {
                        player1.money -= ÷����.basicprice;
                        player4.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player1.money -= ÷����.oneprice;
                        player4.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player1.money -= ÷����.twoprice;
                        player4.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player1.money -= ÷����.threeprice;
                        player4.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player1.money -= ÷����.landprice;
                        player4.money += ÷����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance % 40 && UIScrean)
            {
                if (�ұ���.host == 0 || �ұ���.host == 1)
                {
                    �ұ���Ǹ���.SetActive(true);
                }
                if (�ұ���.host == 2)
                {
                    if (�ұ���.house == 1)
                    {
                        player1.money -= �ұ���.basicprice;
                        player2.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player1.money -= �ұ���.oneprice;
                        player2.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player1.money -= �ұ���.twoprice;
                        player2.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player1.money -= �ұ���.threeprice;
                        player2.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player1.money -= �ұ���.landprice;
                        player2.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 3)
                {
                    if (�ұ���.house == 1)
                    {
                        player1.money -= �ұ���.basicprice;
                        player3.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player1.money -= �ұ���.oneprice;
                        player3.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player1.money -= �ұ���.twoprice;
                        player3.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player1.money -= �ұ���.threeprice;
                        player3.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player1.money -= �ұ���.landprice;
                        player3.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 4)
                {
                    if (�ұ���.house == 1)
                    {
                        player1.money -= �ұ���.basicprice;
                        player4.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player1.money -= �ұ���.oneprice;
                        player4.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player1.money -= �ұ���.twoprice;
                        player4.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player1.money -= �ұ���.threeprice;
                        player4.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player1.money -= �ұ���.landprice;
                        player4.money += �ұ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance % 40 && UIScrean)
            {
                if (���λ�.host == 0 || ���λ�.host == 1)
                {
                    ���λ�Ǹ���.SetActive(true);
                }
                if (���λ�.host == 2)
                {
                    if (���λ�.house == 1)
                    {
                        player1.money -= ���λ�.basicprice;
                        player2.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player1.money -= ���λ�.oneprice;
                        player2.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player1.money -= ���λ�.twoprice;
                        player2.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player1.money -= ���λ�.threeprice;
                        player2.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player1.money -= ���λ�.landprice;
                        player2.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 3)
                {
                    if (���λ�.house == 1)
                    {
                        player1.money -= ���λ�.basicprice;
                        player3.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player1.money -= ���λ�.oneprice;
                        player3.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player1.money -= ���λ�.twoprice;
                        player3.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player1.money -= ���λ�.threeprice;
                        player3.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player1.money -= ���λ�.landprice;
                        player3.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 4)
                {
                    if (���λ�.house == 1)
                    {
                        player1.money -= ���λ�.basicprice;
                        player4.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player1.money -= ���λ�.oneprice;
                        player4.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player1.money -= ���λ�.twoprice;
                        player4.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player1.money -= ���λ�.threeprice;
                        player4.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player1.money -= ���λ�.landprice;
                        player4.money += ���λ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance % 40 && UIScrean)
            {
                if (ó�μ�.host == 0 || ó�μ�.host == 1)
                {
                    ó�μ��Ǹ���.SetActive(true);
                }
                if (ó�μ�.host == 2)
                {
                    if (ó�μ�.house == 1)
                    {
                        player1.money -= ó�μ�.basicprice;
                        player2.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player1.money -= ó�μ�.oneprice;
                        player2.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player1.money -= ó�μ�.twoprice;
                        player2.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player1.money -= ó�μ�.threeprice;
                        player2.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player1.money -= ó�μ�.landprice;
                        player2.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 3)
                {
                    if (ó�μ�.house == 1)
                    {
                        player1.money -= ó�μ�.basicprice;
                        player3.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player1.money -= ó�μ�.oneprice;
                        player3.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player1.money -= ó�μ�.twoprice;
                        player3.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player1.money -= ó�μ�.threeprice;
                        player3.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player1.money -= ó�μ�.landprice;
                        player3.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 4)
                {
                    if (ó�μ�.house == 1)
                    {
                        player1.money -= ó�μ�.basicprice;
                        player4.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player1.money -= ó�μ�.oneprice;
                        player4.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player1.money -= ó�μ�.twoprice;
                        player4.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player1.money -= ó�μ�.threeprice;
                        player4.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player1.money -= ó�μ�.landprice;
                        player4.money += ó�μ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance % 40 && UIScrean)
            {
                if (õ���强.host == 0 || õ���强.host == 1)
                {
                    õ���强�Ǹ���.SetActive(true);
                }
                if (õ���强.host == 2)
                {
                    if (õ���强.house == 1)
                    {
                        player1.money -= õ���强.basicprice;
                        player2.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player1.money -= õ���强.oneprice;
                        player2.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player1.money -= õ���强.twoprice;
                        player2.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player1.money -= õ���强.threeprice;
                        player2.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player1.money -= õ���强.landprice;
                        player2.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 3)
                {
                    if (õ���强.house == 1)
                    {
                        player1.money -= õ���强.basicprice;
                        player3.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player1.money -= õ���强.oneprice;
                        player3.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player1.money -= õ���强.twoprice;
                        player3.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player1.money -= õ���强.threeprice;
                        player3.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player1.money -= õ���强.landprice;
                        player3.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 4)
                {
                    if (õ���强.house == 1)
                    {
                        player1.money -= õ���强.basicprice;
                        player4.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player1.money -= õ���强.oneprice;
                        player4.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player1.money -= õ���强.twoprice;
                        player4.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player1.money -= õ���强.threeprice;
                        player4.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player1.money -= õ���强.landprice;
                        player4.money += õ���强.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance % 40 && UIScrean)
            {
                if (�溹��.host == 0 || �溹��.host == 1)
                {
                    �溹�ñǸ���.SetActive(true);
                }
                if (�溹��.host == 2)
                {
                    if (�溹��.house == 1)
                    {
                        player1.money -= �溹��.basicprice;
                        player2.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player1.money -= �溹��.oneprice;
                        player2.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player1.money -= �溹��.twoprice;
                        player2.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player1.money -= �溹��.threeprice;
                        player2.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player1.money -= �溹��.landprice;
                        player2.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 3)
                {
                    if (�溹��.house == 1)
                    {
                        player1.money -= �溹��.basicprice;
                        player3.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player1.money -= �溹��.oneprice;
                        player3.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player1.money -= �溹��.twoprice;
                        player3.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player1.money -= �溹��.threeprice;
                        player3.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player1.money -= �溹��.landprice;
                        player3.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 4)
                {
                    if (�溹��.house == 1)
                    {
                        player1.money -= �溹��.basicprice;
                        player4.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player1.money -= �溹��.oneprice;
                        player4.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player1.money -= �溹��.twoprice;
                        player4.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player1.money -= �溹��.threeprice;
                        player4.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player1.money -= �溹��.landprice;
                        player4.money += �溹��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 1)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (28 == distance % 40 && UIScrean)
            {
                �糭ī��3.SetActive(true);
                UIScrean = false;
            }
            if (29 == distance % 40 && UIScrean)
            {
                if (â����.host == 0 || â����.host == 1)
                {
                    â���ñǸ���.SetActive(true);
                }
                if (â����.host == 2)
                {
                    if (â����.house == 1)
                    {
                        player1.money -= â����.basicprice;
                        player2.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player1.money -= â����.oneprice;
                        player2.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player1.money -= â����.twoprice;
                        player2.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player1.money -= â����.threeprice;
                        player2.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player1.money -= â����.landprice;
                        player2.money += â����.landprice;
                    }
                }
                else if (â����.host == 3)
                {
                    if (â����.house == 1)
                    {
                        player1.money -= â����.basicprice;
                        player3.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player1.money -= â����.oneprice;
                        player3.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player1.money -= â����.twoprice;
                        player3.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player1.money -= â����.threeprice;
                        player3.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player1.money -= â����.landprice;
                        player3.money += â����.landprice;
                    }
                }
                else if (â����.host == 4)
                {
                    if (â����.house == 1)
                    {
                        player1.money -= â����.basicprice;
                        player4.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player1.money -= â����.oneprice;
                        player4.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player1.money -= â����.twoprice;
                        player4.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player1.money -= â����.threeprice;
                        player4.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player1.money -= â����.landprice;
                        player4.money += â����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 1)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 1)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player1.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player1.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player1.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player1.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player1.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance % 40 && UIScrean)
            {
                if (���������.host == 0 || ���������.host == 1)
                {
                    ���������Ǹ���.SetActive(true);
                }
                if (���������.host == 2)
                {
                    if (���������.house == 1)
                    {
                        player1.money -= ���������.basicprice;
                        player2.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player1.money -= ���������.oneprice;
                        player2.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player1.money -= ���������.twoprice;
                        player2.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player1.money -= ���������.threeprice;
                        player2.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player1.money -= ���������.landprice;
                        player2.money += ���������.landprice;
                    }
                }
                else if (���������.host == 3)
                {
                    if (���������.house == 1)
                    {
                        player1.money -= ���������.basicprice;
                        player3.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player1.money -= ���������.oneprice;
                        player3.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player1.money -= ���������.twoprice;
                        player3.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player1.money -= ���������.threeprice;
                        player3.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player1.money -= ���������.landprice;
                        player3.money += ���������.landprice;
                    }
                }
                else if (���������.host == 4)
                {
                    if (���������.house == 1)
                    {
                        player1.money -= ���������.basicprice;
                        player4.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player1.money -= ���������.oneprice;
                        player4.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player1.money -= ���������.twoprice;
                        player4.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player1.money -= ���������.threeprice;
                        player4.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player1.money -= ���������.landprice;
                        player4.money += ���������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance % 40 && UIScrean)
            {
                if (��õ.host == 0 || ��õ.host == 1)
                {
                    ��õ�Ǹ���.SetActive(true);
                }
                if (��õ.host == 2)
                {
                    if (��õ.house == 1)
                    {
                        player1.money -= ��õ.basicprice;
                        player2.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player1.money -= ��õ.oneprice;
                        player2.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player1.money -= ��õ.twoprice;
                        player2.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player1.money -= ��õ.threeprice;
                        player2.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player1.money -= ��õ.landprice;
                        player2.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 3)
                {
                    if (��õ.house == 1)
                    {
                        player1.money -= ��õ.basicprice;
                        player3.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player1.money -= ��õ.oneprice;
                        player3.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player1.money -= ��õ.twoprice;
                        player3.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player1.money -= ��õ.threeprice;
                        player3.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player1.money -= ��õ.landprice;
                        player3.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 4)
                {
                    if (��õ.house == 1)
                    {
                        player1.money -= ��õ.basicprice;
                        player4.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player1.money -= ��õ.oneprice;
                        player4.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player1.money -= ��õ.twoprice;
                        player4.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player1.money -= ��õ.threeprice;
                        player4.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player1.money -= ��õ.landprice;
                        player4.money += ��õ.landprice;
                    }
                }
                UIScrean = false;

            }
            if (38 == distance % 40 && UIScrean)
            {
                �糭ī��4.SetActive(true);
                UIScrean = false;
            }
            if (39 == distance % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 1)
                {
                    ����Ǹ���.SetActive(true);
                }
                if (����.host == 2)
                {
                    if (����.house == 1)
                    {
                        player1.money -= ����.basicprice;
                        player2.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player1.money -= ����.oneprice;
                        player2.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player1.money -= ����.twoprice;
                        player2.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player1.money -= ����.threeprice;
                        player2.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player1.money -= ����.landprice;
                        player2.money += ����.landprice;
                    }
                }
                else if (����.host == 3)
                {
                    if (����.house == 1)
                    {
                        player1.money -= ����.basicprice;
                        player3.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player1.money -= ����.oneprice;
                        player3.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player1.money -= ����.twoprice;
                        player3.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player1.money -= ����.threeprice;
                        player3.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player1.money -= ����.landprice;
                        player3.money += ����.landprice;
                    }
                }
                else if (����.host == 4)
                {
                    if (����.house == 1)
                    {
                        player1.money -= ����.basicprice;
                        player4.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player1.money -= ����.oneprice;
                        player4.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player1.money -= ����.twoprice;
                        player4.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player1.money -= ����.threeprice;
                        player4.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player1.money -= ����.landprice;
                        player4.money += ����.landprice;
                    }
                }
                UIScrean = false;

            }
            if (5 == distance % 40 && UIScrean)
            {
                if (����.host == 0)
                {
                    ����1.SetActive(true);
                }
                else if(����.host == 2)
                {
                    player1.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host == 3)
                {
                    player1.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host == 4)
                {
                    player1.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance % 40 && UIScrean)
            {
                if (����.host2 == 0)
                {
                    ����2.SetActive(true);
                }
                else if (����.host2 == 2)
                {
                    player1.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host2 == 3)
                {
                    player1.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host2 == 4)
                {
                    player1.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance % 40 && UIScrean)
            {
                if (����.host3 == 0)
                {
                    ����3.SetActive(true);
                }
                else if (����.host3 == 2)
                {
                    player1.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host3 == 3)
                {
                    player1.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host3 == 4)
                {
                    player1.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance % 40 && UIScrean)
            {
                if (����.host4 == 0)
                {
                    ����4.SetActive(true);
                }
                else if (����.host4 == 2)
                {
                    player1.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host4 == 3)
                {
                    player1.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host4 == 4)
                {
                    player1.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance % 40 || 17 == distance % 40 || 33 == distance) && UIScrean)
            {
                ��ȸ���.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance % 40 || 22 == distance % 40 || 36 == distance) && UIScrean)
            {
                ����ī��.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance % 40 && UIScrean)
            {
                Ÿ�Ӹӽ�.SetActive(true);
                UIScrean = false;
            }
            if (�����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �����Ǹ���.SetActive(false);
            }
            else if (���Ͽ����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���Ͽ����Ǹ���.SetActive(false);
            }
            else if (��������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��������Ǹ���.SetActive(false);
            }
            else if (���ε��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ε��Ǹ���.SetActive(false);
            }
            else if (�ζѸ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ζѸ��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�屺�ѱǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �屺�ѱǸ���.SetActive(false);
            }
            else if (���ɿո��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ɿո��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (÷����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ÷����Ǹ���.SetActive(false);
            }
            else if (�ұ���Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ұ���Ǹ���.SetActive(false);
            }
            else if (���λ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���λ�Ǹ���.SetActive(false);
            }
            else if (ó�μ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ó�μ��Ǹ���.SetActive(false);
            }
            else if (õ���强�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                õ���强�Ǹ���.SetActive(false);
            }
            else if (�溹�ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �溹�ñǸ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (â���ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                â���ñǸ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (���������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���������Ǹ���.SetActive(false);
            }
            else if (��õ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��õ�Ǹ���.SetActive(false);
            }
            else if (����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����Ǹ���.SetActive(false);
            }
            else if (�糭ī��1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��1.SetActive(false);
            }
            else if (�糭ī��2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��2.SetActive(false);
            }
            else if (�糭ī��3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��3.SetActive(false);
            }
            else if (�糭ī��4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��4.SetActive(false);
            }
            else if (����1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����1.SetActive(false);
            }
            else if (����2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����2.SetActive(false);
            }
            else if (����3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����3.SetActive(false);
            }
            else if (����4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����4.SetActive(false);
            }
            else if (��ȸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��ȸ���.SetActive(false);
            }
            else if (����ī��.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����ī��.SetActive(false);
            }
        }
        else if (DiceScript.order == 3)
        {
            if (1 == distance2 % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 2)
                {
                    �����Ǹ���.SetActive(true);
                }
                if (����.host == 1)
                {
                    if (����.house == 1)
                    {
                        player2.money -= ����.basicprice;
                        player1.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player2.money -= ����.oneprice;
                        player1.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player2.money -= ����.twoprice;
                        player1.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player2.money -= ����.threeprice;
                        player1.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player2.money -= ����.landprice;
                        player1.money += ����.landprice;
                    }
                }
                else if (����.host == 3)
                {
                    if (����.house == 1)
                    {
                        player2.money -= ����.basicprice;
                        player3.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player2.money -= ����.oneprice;
                        player3.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player2.money -= ����.twoprice;
                        player3.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player2.money -= ����.threeprice;
                        player3.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player2.money -= ����.landprice;
                        player3.money += ����.landprice;
                    }
                }
                else if (����.host == 4)
                {
                    if (����.house == 1)
                    {
                        player2.money -= ����.basicprice;
                        player4.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player2.money -= ����.oneprice;
                        player2.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player2.money -= ����.twoprice;
                        player4.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player2.money -= ����.threeprice;
                        player4.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player2.money -= ����.landprice;
                        player4.money += ����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance2 % 40 && UIScrean)
            {
                if (���Ͽ���.host == 0 || ���Ͽ���.host == 2)
                {
                    ���Ͽ����Ǹ���.SetActive(true);
                }
                if (���Ͽ���.host == 1)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player2.money -= ���Ͽ���.basicprice;
                        player1.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player2.money -= ���Ͽ���.oneprice;
                        player1.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player2.money -= ���Ͽ���.twoprice;
                        player1.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player2.money -= ���Ͽ���.threeprice;
                        player1.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player2.money -= ���Ͽ���.landprice;
                        player1.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 3)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player2.money -= ���Ͽ���.basicprice;
                        player3.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player2.money -= ���Ͽ���.oneprice;
                        player3.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player2.money -= ���Ͽ���.twoprice;
                        player3.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player2.money -= ���Ͽ���.threeprice;
                        player3.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player2.money -= ���Ͽ���.landprice;
                        player3.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 4)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player2.money -= ���Ͽ���.basicprice;
                        player4.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player2.money -= ���Ͽ���.oneprice;
                        player4.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player2.money -= ���Ͽ���.twoprice;
                        player4.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player2.money -= ���Ͽ���.threeprice;
                        player4.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player2.money -= ���Ͽ���.landprice;
                        player4.money += ���Ͽ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (6 == distance2 % 40 && UIScrean)
            {
                if (�������.host == 0 || �������.host == 2)
                {
                    ��������Ǹ���.SetActive(true);
                }
                if (�������.host == 1)
                {
                    if (�������.house == 1)
                    {
                        player2.money -= �������.basicprice;
                        player1.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player2.money -= �������.oneprice;
                        player1.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player2.money -= �������.twoprice;
                        player1.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player2.money -= �������.threeprice;
                        player1.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player2.money -= �������.landprice;
                        player1.money += �������.landprice;
                    }
                }
                else if (�������.host == 3)
                {
                    if (�������.house == 1)
                    {
                        player2.money -= �������.basicprice;
                        player3.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player2.money -= �������.oneprice;
                        player3.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player2.money -= �������.twoprice;
                        player3.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player2.money -= �������.threeprice;
                        player3.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player2.money -= �������.landprice;
                        player3.money += �������.landprice;
                    }
                }
                else if (�������.host == 4)
                {
                    if (�������.house == 1)
                    {
                        player2.money -= �������.basicprice;
                        player4.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player2.money -= �������.oneprice;
                        player4.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player2.money -= �������.twoprice;
                        player4.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player2.money -= �������.threeprice;
                        player4.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player2.money -= �������.landprice;
                        player4.money += �������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance2 % 40 && UIScrean)
            {
                if (���ε�.host == 0 || ���ε�.host == 2)
                {
                    ���ε��Ǹ���.SetActive(true);
                }
                if (���ε�.host == 1)
                {
                    if (���ε�.house == 1)
                    {
                        player2.money -= ���ε�.basicprice;
                        player1.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player2.money -= ���ε�.oneprice;
                        player1.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player2.money -= ���ε�.twoprice;
                        player1.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player2.money -= ���ε�.threeprice;
                        player1.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player2.money -= ���ε�.landprice;
                        player1.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 3)
                {
                    if (���ε�.house == 1)
                    {
                        player2.money -= ���ε�.basicprice;
                        player3.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player2.money -= ���ε�.oneprice;
                        player3.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player2.money -= ���ε�.twoprice;
                        player3.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player2.money -= ���ε�.threeprice;
                        player3.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player2.money -= ���ε�.landprice;
                        player3.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 4)
                {
                    if (���ε�.house == 1)
                    {
                        player2.money -= ���ε�.basicprice;
                        player4.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player2.money -= ���ε�.oneprice;
                        player4.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player2.money -= ���ε�.twoprice;
                        player4.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player2.money -= ���ε�.threeprice;
                        player4.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player2.money -= ���ε�.landprice;
                        player4.money += ���ε�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance2 % 40 && UIScrean)
            {
                if (�ζѸ�.host == 0 || �ζѸ�.host == 2)
                {
                    �ζѸ��Ǹ���.SetActive(true);
                }
                if (�ζѸ�.host == 1)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player2.money -= �ζѸ�.basicprice;
                        player1.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player2.money -= �ζѸ�.oneprice;
                        player1.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player2.money -= �ζѸ�.twoprice;
                        player1.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player2.money -= �ζѸ�.threeprice;
                        player1.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player2.money -= �ζѸ�.landprice;
                        player1.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 3)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player2.money -= �ζѸ�.basicprice;
                        player3.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player2.money -= �ζѸ�.oneprice;
                        player3.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player2.money -= �ζѸ�.twoprice;
                        player3.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player2.money -= �ζѸ�.threeprice;
                        player3.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player2.money -= �ζѸ�.landprice;
                        player3.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 4)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player2.money -= �ζѸ�.basicprice;
                        player4.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player2.money -= �ζѸ�.oneprice;
                        player4.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player2.money -= �ζѸ�.twoprice;
                        player4.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player2.money -= �ζѸ�.threeprice;
                        player4.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player2.money -= �ζѸ�.landprice;
                        player4.money += �ζѸ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance2 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 2)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (13 == distance2 % 40 && UIScrean)
            {
                if (�屺��.host == 0 || �屺��.host == 2)
                {
                    �屺�ѱǸ���.SetActive(true);
                }
                if (�屺��.host == 1)
                {
                    if (�屺��.house == 1)
                    {
                        player2.money -= �屺��.basicprice;
                        player1.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player2.money -= �屺��.oneprice;
                        player1.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player2.money -= �屺��.twoprice;
                        player1.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player2.money -= �屺��.threeprice;
                        player1.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player2.money -= �屺��.landprice;
                        player1.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 3)
                {
                    if (�屺��.house == 1)
                    {
                        player2.money -= �屺��.basicprice;
                        player3.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player2.money -= �屺��.oneprice;
                        player3.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player2.money -= �屺��.twoprice;
                        player3.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player2.money -= �屺��.threeprice;
                        player3.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player2.money -= �屺��.landprice;
                        player3.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 4)
                {
                    if (�屺��.house == 1)
                    {
                        player2.money -= �屺��.basicprice;
                        player4.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player2.money -= �屺��.oneprice;
                        player4.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player2.money -= �屺��.twoprice;
                        player4.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player2.money -= �屺��.threeprice;
                        player4.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player2.money -= �屺��.landprice;
                        player4.money += �屺��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance2 % 40 && UIScrean)
            {
                if (���ɿո�.host == 0 || ���ɿո�.host == 2)
                {
                    ���ɿո��Ǹ���.SetActive(true);
                }
                if (���ɿո�.host == 1)
                {
                    if (���ɿո�.house == 1)
                    {
                        player2.money -= ���ɿո�.basicprice;
                        player1.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player2.money -= ���ɿո�.oneprice;
                        player1.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player2.money -= ���ɿո�.twoprice;
                        player1.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player2.money -= ���ɿո�.threeprice;
                        player1.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player2.money -= ���ɿո�.landprice;
                        player1.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 3)
                {
                    if (���ɿո�.house == 1)
                    {
                        player2.money -= ���ɿո�.basicprice;
                        player3.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player2.money -= ���ɿո�.oneprice;
                        player3.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player2.money -= ���ɿո�.twoprice;
                        player3.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player2.money -= ���ɿո�.threeprice;
                        player3.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player2.money -= ���ɿո�.landprice;
                        player3.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 4)
                {
                    if (���ɿո�.house == 1)
                    {
                        player2.money -= ���ɿո�.basicprice;
                        player4.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player2.money -= ���ɿո�.oneprice;
                        player4.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player2.money -= ���ɿո�.twoprice;
                        player4.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player2.money -= ���ɿո�.threeprice;
                        player4.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player2.money -= ���ɿո�.landprice;
                        player4.money += ���ɿո�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance2 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 2)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance2 % 40 && UIScrean)
            {
                if (÷����.host == 0 || ÷����.host == 2)
                {
                    ÷����Ǹ���.SetActive(true);
                }
                if (÷����.host == 1)
                {
                    if (÷����.house == 1)
                    {
                        player2.money -= ÷����.basicprice;
                        player1.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player2.money -= ÷����.oneprice;
                        player1.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player2.money -= ÷����.twoprice;
                        player1.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player2.money -= ÷����.threeprice;
                        player1.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player2.money -= ÷����.landprice;
                        player1.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 3)
                {
                    if (÷����.house == 1)
                    {
                        player2.money -= ÷����.basicprice;
                        player3.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player2.money -= ÷����.oneprice;
                        player3.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player2.money -= ÷����.twoprice;
                        player3.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player2.money -= ÷����.threeprice;
                        player3.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player2.money -= ÷����.landprice;
                        player3.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 4)
                {
                    if (÷����.house == 1)
                    {
                        player2.money -= ÷����.basicprice;
                        player4.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player2.money -= ÷����.oneprice;
                        player4.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player2.money -= ÷����.twoprice;
                        player4.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player2.money -= ÷����.threeprice;
                        player4.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player2.money -= ÷����.landprice;
                        player4.money += ÷����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance2 % 40 && UIScrean)
            {
                if (�ұ���.host == 0 || �ұ���.host == 2)
                {
                    �ұ���Ǹ���.SetActive(true);
                }
                if (�ұ���.host == 1)
                {
                    if (�ұ���.house == 1)
                    {
                        player2.money -= �ұ���.basicprice;
                        player1.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player2.money -= �ұ���.oneprice;
                        player1.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player2.money -= �ұ���.twoprice;
                        player1.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player2.money -= �ұ���.threeprice;
                        player1.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player2.money -= �ұ���.landprice;
                        player1.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 3)
                {
                    if (�ұ���.house == 1)
                    {
                        player2.money -= �ұ���.basicprice;
                        player3.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player2.money -= �ұ���.oneprice;
                        player3.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player2.money -= �ұ���.twoprice;
                        player3.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player2.money -= �ұ���.threeprice;
                        player3.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player2.money -= �ұ���.landprice;
                        player3.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 4)
                {
                    if (�ұ���.house == 1)
                    {
                        player2.money -= �ұ���.basicprice;
                        player4.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player2.money -= �ұ���.oneprice;
                        player4.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player2.money -= �ұ���.twoprice;
                        player4.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player2.money -= �ұ���.threeprice;
                        player4.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player2.money -= �ұ���.landprice;
                        player4.money += �ұ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance2 % 40 && UIScrean)
            {
                if (���λ�.host == 0 || ���λ�.host == 2)
                {
                    ���λ�Ǹ���.SetActive(true);
                }
                if (���λ�.host == 1)
                {
                    if (���λ�.house == 1)
                    {
                        player2.money -= ���λ�.basicprice;
                        player1.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player2.money -= ���λ�.oneprice;
                        player1.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player2.money -= ���λ�.twoprice;
                        player1.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player2.money -= ���λ�.threeprice;
                        player1.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player2.money -= ���λ�.landprice;
                        player1.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 3)
                {
                    if (���λ�.house == 1)
                    {
                        player2.money -= ���λ�.basicprice;
                        player3.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player2.money -= ���λ�.oneprice;
                        player3.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player2.money -= ���λ�.twoprice;
                        player3.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player2.money -= ���λ�.threeprice;
                        player3.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player2.money -= ���λ�.landprice;
                        player3.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 4)
                {
                    if (���λ�.house == 1)
                    {
                        player2.money -= ���λ�.basicprice;
                        player4.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player2.money -= ���λ�.oneprice;
                        player4.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player2.money -= ���λ�.twoprice;
                        player4.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player2.money -= ���λ�.threeprice;
                        player4.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player2.money -= ���λ�.landprice;
                        player4.money += ���λ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance2 % 40 && UIScrean)
            {
                if (ó�μ�.host == 0 || ó�μ�.host == 2)
                {
                    ó�μ��Ǹ���.SetActive(true);
                }
                if (ó�μ�.host == 1)
                {
                    if (ó�μ�.house == 1)
                    {
                        player2.money -= ó�μ�.basicprice;
                        player1.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player2.money -= ó�μ�.oneprice;
                        player1.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player2.money -= ó�μ�.twoprice;
                        player1.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player2.money -= ó�μ�.threeprice;
                        player1.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player2.money -= ó�μ�.landprice;
                        player1.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 3)
                {
                    if (ó�μ�.house == 1)
                    {
                        player2.money -= ó�μ�.basicprice;
                        player3.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player2.money -= ó�μ�.oneprice;
                        player3.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player2.money -= ó�μ�.twoprice;
                        player3.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player2.money -= ó�μ�.threeprice;
                        player3.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player2.money -= ó�μ�.landprice;
                        player3.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 4)
                {
                    if (ó�μ�.house == 1)
                    {
                        player2.money -= ó�μ�.basicprice;
                        player4.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player2.money -= ó�μ�.oneprice;
                        player4.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player2.money -= ó�μ�.twoprice;
                        player4.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player2.money -= ó�μ�.threeprice;
                        player4.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player2.money -= ó�μ�.landprice;
                        player4.money += ó�μ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance2 % 40 && UIScrean)
            {
                if (õ���强.host == 0 || õ���强.host == 2)
                {
                    õ���强�Ǹ���.SetActive(true);
                }
                if (õ���强.host == 1)
                {
                    if (õ���强.house == 1)
                    {
                        player2.money -= õ���强.basicprice;
                        player1.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player2.money -= õ���强.oneprice;
                        player1.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player2.money -= õ���强.twoprice;
                        player1.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player2.money -= õ���强.threeprice;
                        player1.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player2.money -= õ���强.landprice;
                        player1.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 3)
                {
                    if (õ���强.house == 1)
                    {
                        player2.money -= õ���强.basicprice;
                        player3.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player2.money -= õ���强.oneprice;
                        player3.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player2.money -= õ���强.twoprice;
                        player3.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player2.money -= õ���强.threeprice;
                        player3.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player2.money -= õ���强.landprice;
                        player3.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 4)
                {
                    if (õ���强.house == 1)
                    {
                        player2.money -= õ���强.basicprice;
                        player4.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player2.money -= õ���强.oneprice;
                        player4.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player2.money -= õ���强.twoprice;
                        player4.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player2.money -= õ���强.threeprice;
                        player4.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player2.money -= õ���强.landprice;
                        player4.money += õ���强.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance2 % 40 && UIScrean)
            {
                if (�溹��.host == 0 || �溹��.host == 2)
                {
                    �溹�ñǸ���.SetActive(true);
                }
                if (�溹��.host == 1)
                {
                    if (�溹��.house == 1)
                    {
                        player2.money -= �溹��.basicprice;
                        player1.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player2.money -= �溹��.oneprice;
                        player1.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player2.money -= �溹��.twoprice;
                        player1.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player2.money -= �溹��.threeprice;
                        player1.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player2.money -= �溹��.landprice;
                        player1.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 3)
                {
                    if (�溹��.house == 1)
                    {
                        player2.money -= �溹��.basicprice;
                        player3.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player2.money -= �溹��.oneprice;
                        player3.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player2.money -= �溹��.twoprice;
                        player3.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player2.money -= �溹��.threeprice;
                        player3.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player2.money -= �溹��.landprice;
                        player3.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 4)
                {
                    if (�溹��.house == 1)
                    {
                        player2.money -= �溹��.basicprice;
                        player4.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player2.money -= �溹��.oneprice;
                        player4.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player2.money -= �溹��.twoprice;
                        player4.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player2.money -= �溹��.threeprice;
                        player4.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player2.money -= �溹��.landprice;
                        player4.money += �溹��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance2 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 2)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (29 == distance2 % 40 && UIScrean)
            {
                if (â����.host == 0 || â����.host == 2)
                {
                    â���ñǸ���.SetActive(true);
                }
                if (â����.host == 1)
                {
                    if (â����.house == 1)
                    {
                        player2.money -= â����.basicprice;
                        player1.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player2.money -= â����.oneprice;
                        player1.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player2.money -= â����.twoprice;
                        player1.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player2.money -= â����.threeprice;
                        player1.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player2.money -= â����.landprice;
                        player1.money += â����.landprice;
                    }
                }
                else if (â����.host == 3)
                {
                    if (â����.house == 1)
                    {
                        player2.money -= â����.basicprice;
                        player3.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player2.money -= â����.oneprice;
                        player3.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player2.money -= â����.twoprice;
                        player3.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player2.money -= â����.threeprice;
                        player3.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player2.money -= â����.landprice;
                        player3.money += â����.landprice;
                    }
                }
                else if (â����.host == 4)
                {
                    if (â����.house == 1)
                    {
                        player2.money -= â����.basicprice;
                        player4.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player2.money -= â����.oneprice;
                        player4.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player2.money -= â����.twoprice;
                        player4.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player2.money -= â����.threeprice;
                        player4.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player2.money -= â����.landprice;
                        player4.money += â����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance2 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 2)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance2 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 2)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player2.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player2.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player2.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player2.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player2.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance2 % 40 && UIScrean)
            {
                if (���������.host == 0 || ���������.host == 2)
                {
                    ���������Ǹ���.SetActive(true);
                }
                if (���������.host == 1)
                {
                    if (���������.house == 1)
                    {
                        player2.money -= ���������.basicprice;
                        player1.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player2.money -= ���������.oneprice;
                        player1.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player2.money -= ���������.twoprice;
                        player1.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player2.money -= ���������.threeprice;
                        player1.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player2.money -= ���������.landprice;
                        player1.money += ���������.landprice;
                    }
                }
                else if (���������.host == 3)
                {
                    if (���������.house == 1)
                    {
                        player2.money -= ���������.basicprice;
                        player3.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player2.money -= ���������.oneprice;
                        player3.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player2.money -= ���������.twoprice;
                        player3.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player2.money -= ���������.threeprice;
                        player3.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player2.money -= ���������.landprice;
                        player3.money += ���������.landprice;
                    }
                }
                else if (���������.host == 4)
                {
                    if (���������.house == 1)
                    {
                        player2.money -= ���������.basicprice;
                        player4.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player2.money -= ���������.oneprice;
                        player4.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player2.money -= ���������.twoprice;
                        player4.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player2.money -= ���������.threeprice;
                        player4.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player2.money -= ���������.landprice;
                        player4.money += ���������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance2 % 40 && UIScrean)
            {
                if (��õ.host == 0 || ��õ.host == 2)
                {
                    ��õ�Ǹ���.SetActive(true);
                }
                if (��õ.host == 1)
                {
                    if (��õ.house == 1)
                    {
                        player2.money -= ��õ.basicprice;
                        player1.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player2.money -= ��õ.oneprice;
                        player1.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player2.money -= ��õ.twoprice;
                        player1.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player2.money -= ��õ.threeprice;
                        player1.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player2.money -= ��õ.landprice;
                        player1.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 3)
                {
                    if (��õ.house == 1)
                    {
                        player2.money -= ��õ.basicprice;
                        player3.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player2.money -= ��õ.oneprice;
                        player3.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player2.money -= ��õ.twoprice;
                        player3.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player2.money -= ��õ.threeprice;
                        player3.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player2.money -= ��õ.landprice;
                        player3.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 4)
                {
                    if (��õ.house == 1)
                    {
                        player2.money -= ��õ.basicprice;
                        player4.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player2.money -= ��õ.oneprice;
                        player4.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player2.money -= ��õ.twoprice;
                        player4.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player2.money -= ��õ.threeprice;
                        player4.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player2.money -= ��õ.landprice;
                        player4.money += ��õ.landprice;
                    }
                }
                UIScrean = false;

            }
            if (39 == distance2 % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 2)
                {
                    ����Ǹ���.SetActive(true);
                }
                if (����.host == 1)
                {
                    if (����.house == 1)
                    {
                        player2.money -= ����.basicprice;
                        player1.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player2.money -= ����.oneprice;
                        player1.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player2.money -= ����.twoprice;
                        player1.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player2.money -= ����.threeprice;
                        player1.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player2.money -= ����.landprice;
                        player1.money += ����.landprice;
                    }
                }
                else if (����.host == 3)
                {
                    if (����.house == 1)
                    {
                        player2.money -= ����.basicprice;
                        player3.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player2.money -= ����.oneprice;
                        player3.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player2.money -= ����.twoprice;
                        player3.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player2.money -= ����.threeprice;
                        player3.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player2.money -= ����.landprice;
                        player3.money += ����.landprice;
                    }
                }
                else if (����.host == 4)
                {
                    if (����.house == 1)
                    {
                        player2.money -= ����.basicprice;
                        player4.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player2.money -= ����.oneprice;
                        player4.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player2.money -= ����.twoprice;
                        player4.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player2.money -= ����.threeprice;
                        player4.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player2.money -= ����.landprice;
                        player4.money += ����.landprice;
                    }
                }
                UIScrean = false;

            }
            if (4 == distance2 % 40 && UIScrean)
            {
                �糭ī��1.SetActive(true);
                UIScrean = false;
            }
            if (12 == distance2 % 40 && UIScrean)
            {
                �糭ī��2.SetActive(true);
                UIScrean = false;
            }
            if (28 == distance2 % 40 && UIScrean)
            {
                �糭ī��3.SetActive(true);
                UIScrean = false;
            }
            if (38 == distance2 % 40 && UIScrean)
            {
                �糭ī��4.SetActive(true);
                UIScrean = false;
            }
            if (5 == distance2 % 40 && UIScrean)
            {
                if (����.host == 0)
                {
                    ����1.SetActive(true);
                }
                else if (����.host == 1)
                {
                    player2.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host == 3)
                {
                    player2.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host == 4)
                {
                    player2.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance2 % 40 && UIScrean)
            {
                if (����.host2 == 0)
                {
                    ����2.SetActive(true);
                }
                else if (����.host2 == 1)
                {
                    player2.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host2 == 3)
                {
                    player2.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host2 == 4)
                {
                    player2.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance2 % 40 && UIScrean)
            {
                if (����.host3 == 0)
                {
                    ����3.SetActive(true);
                }
                else if (����.host3 == 1)
                {
                    player2.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host3 == 3)
                {
                    player2.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host3 == 4)
                {
                    player2.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance2 % 40 && UIScrean)
            {
                if (����.host4 == 0)
                {
                    ����4.SetActive(true);
                }
                else if (����.host4 == 1)
                {
                    player2.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host4 == 3)
                {
                    player2.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host4 == 4)
                {
                    player2.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance2 % 40 || 17 == distance2 % 40 || 33 == distance2) && UIScrean)
            {
                ��ȸ���.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance2 % 40 || 22 == distance2 % 40 || 36 == distance2) && UIScrean)
            {
                ����ī��.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance2 % 40 && UIScrean)
            {
                Ÿ�Ӹӽ�.SetActive(true);
                UIScrean = false;
            }
            if (�����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �����Ǹ���.SetActive(false);
                //UIScrean = true;
            }
            else if (���Ͽ����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���Ͽ����Ǹ���.SetActive(false);
            }
            else if (��������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��������Ǹ���.SetActive(false);
            }
            else if (���ε��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ε��Ǹ���.SetActive(false);
            }
            else if (�ζѸ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ζѸ��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�屺�ѱǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �屺�ѱǸ���.SetActive(false);
            }
            else if (���ɿո��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ɿո��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (÷����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ÷����Ǹ���.SetActive(false);
            }
            else if (�ұ���Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ұ���Ǹ���.SetActive(false);
            }
            else if (���λ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���λ�Ǹ���.SetActive(false);
            }
            else if (ó�μ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ó�μ��Ǹ���.SetActive(false);
            }
            else if (õ���强�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                õ���强�Ǹ���.SetActive(false);
            }
            else if (�溹�ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �溹�ñǸ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (â���ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                â���ñǸ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (���������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���������Ǹ���.SetActive(false);
            }
            else if (��õ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��õ�Ǹ���.SetActive(false);
            }
            else if (����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����Ǹ���.SetActive(false);
            }
            else if (�糭ī��1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��1.SetActive(false);
            }
            else if (�糭ī��2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��2.SetActive(false);
            }
            else if (�糭ī��3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��3.SetActive(false);
            }
            else if (�糭ī��4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��4.SetActive(false);
            }
            else if (����1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����1.SetActive(false);
            }
            else if (����2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����2.SetActive(false);
            }
            else if (����3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����3.SetActive(false);
            }
            else if (����4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����4.SetActive(false);
            }
            else if (��ȸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��ȸ���.SetActive(false);
            }
            else if (����ī��.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����ī��.SetActive(false);
            }
        }
        else if (DiceScript.order == 4)
        {
            if (1 == distance3 % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 3)
                {
                    �����Ǹ���.SetActive(true);
                }
                if (����.host == 2)
                {
                    if (����.house == 1)
                    {
                        player3.money -= ����.basicprice;
                        player2.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player3.money -= ����.oneprice;
                        player2.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player3.money -= ����.twoprice;
                        player2.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player3.money -= ����.threeprice;
                        player2.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player3.money -= ����.landprice;
                        player2.money += ����.landprice;
                    }
                }
                else if (����.host == 1)
                {
                    if (����.house == 1)
                    {
                        player3.money -= ����.basicprice;
                        player1.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player3.money -= ����.oneprice;
                        player1.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player3.money -= ����.twoprice;
                        player1.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player3.money -= ����.threeprice;
                        player1.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player3.money -= ����.landprice;
                        player1.money += ����.landprice;
                    }
                }
                else if (����.host == 4)
                {
                    if (����.house == 1)
                    {
                        player3.money -= ����.basicprice;
                        player4.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player3.money -= ����.oneprice;
                        player4.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player3.money -= ����.twoprice;
                        player4.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player3.money -= ����.threeprice;
                        player4.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player3.money -= ����.landprice;
                        player4.money += ����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance3 % 40 && UIScrean)
            {
                if (���Ͽ���.host == 0 || ���Ͽ���.host == 3)
                {
                    ���Ͽ����Ǹ���.SetActive(true);
                }
                if (���Ͽ���.host == 2)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player3.money -= ���Ͽ���.basicprice;
                        player2.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player3.money -= ���Ͽ���.oneprice;
                        player2.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player3.money -= ���Ͽ���.twoprice;
                        player2.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player3.money -= ���Ͽ���.threeprice;
                        player2.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player3.money -= ���Ͽ���.landprice;
                        player2.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 1)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player3.money -= ���Ͽ���.basicprice;
                        player1.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player3.money -= ���Ͽ���.oneprice;
                        player1.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player3.money -= ���Ͽ���.twoprice;
                        player1.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player3.money -= ���Ͽ���.threeprice;
                        player1.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player3.money -= ���Ͽ���.landprice;
                        player1.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 4)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player3.money -= ���Ͽ���.basicprice;
                        player4.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player3.money -= ���Ͽ���.oneprice;
                        player4.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player3.money -= ���Ͽ���.twoprice;
                        player4.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player3.money -= ���Ͽ���.threeprice;
                        player4.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player3.money -= ���Ͽ���.landprice;
                        player4.money += ���Ͽ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (6 == distance3 % 40 && UIScrean)
            {
                if (�������.host == 0 || �������.host == 3)
                {
                    ��������Ǹ���.SetActive(true);
                }
                if (�������.host == 2)
                {
                    if (�������.house == 1)
                    {
                        player3.money -= �������.basicprice;
                        player2.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player3.money -= �������.oneprice;
                        player2.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player3.money -= �������.twoprice;
                        player2.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player3.money -= �������.threeprice;
                        player2.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player3.money -= �������.landprice;
                        player2.money += �������.landprice;
                    }
                }
                else if (�������.host == 1)
                {
                    if (�������.house == 1)
                    {
                        player3.money -= �������.basicprice;
                        player1.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player3.money -= �������.oneprice;
                        player1.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player3.money -= �������.twoprice;
                        player1.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player3.money -= �������.threeprice;
                        player1.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player3.money -= �������.landprice;
                        player1.money += �������.landprice;
                    }
                }
                else if (�������.host == 4)
                {
                    if (�������.house == 1)
                    {
                        player3.money -= �������.basicprice;
                        player4.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player3.money -= �������.oneprice;
                        player4.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player3.money -= �������.twoprice;
                        player4.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player3.money -= �������.threeprice;
                        player4.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player3.money -= �������.landprice;
                        player4.money += �������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance3 % 40 && UIScrean)
            {
                if (���ε�.host == 0 || ���ε�.host == 3)
                {
                    ���ε��Ǹ���.SetActive(true);
                }
                if (���ε�.host == 2)
                {
                    if (���ε�.house == 1)
                    {
                        player3.money -= ���ε�.basicprice;
                        player2.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player3.money -= ���ε�.oneprice;
                        player2.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player3.money -= ���ε�.twoprice;
                        player2.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player3.money -= ���ε�.threeprice;
                        player2.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player3.money -= ���ε�.landprice;
                        player2.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 1)
                {
                    if (���ε�.house == 1)
                    {
                        player3.money -= ���ε�.basicprice;
                        player1.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player3.money -= ���ε�.oneprice;
                        player1.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player3.money -= ���ε�.twoprice;
                        player1.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player3.money -= ���ε�.threeprice;
                        player1.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player3.money -= ���ε�.landprice;
                        player1.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 4)
                {
                    if (���ε�.house == 1)
                    {
                        player3.money -= ���ε�.basicprice;
                        player4.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player3.money -= ���ε�.oneprice;
                        player4.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player3.money -= ���ε�.twoprice;
                        player4.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player3.money -= ���ε�.threeprice;
                        player4.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player3.money -= ���ε�.landprice;
                        player4.money += ���ε�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance3 % 40 && UIScrean)
            {
                if (�ζѸ�.host == 0 || �ζѸ�.host == 3)
                {
                    �ζѸ��Ǹ���.SetActive(true);
                }
                if (�ζѸ�.host == 2)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player3.money -= �ζѸ�.basicprice;
                        player2.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player3.money -= �ζѸ�.oneprice;
                        player2.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player3.money -= �ζѸ�.twoprice;
                        player2.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player3.money -= �ζѸ�.threeprice;
                        player2.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player3.money -= �ζѸ�.landprice;
                        player2.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 1)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player3.money -= �ζѸ�.basicprice;
                        player1.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player3.money -= �ζѸ�.oneprice;
                        player1.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player3.money -= �ζѸ�.twoprice;
                        player1.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player3.money -= �ζѸ�.threeprice;
                        player1.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player3.money -= �ζѸ�.landprice;
                        player1.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 4)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player3.money -= �ζѸ�.basicprice;
                        player4.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player3.money -= �ζѸ�.oneprice;
                        player4.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player3.money -= �ζѸ�.twoprice;
                        player4.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player3.money -= �ζѸ�.threeprice;
                        player4.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player3.money -= �ζѸ�.landprice;
                        player4.money += �ζѸ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance3 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 3)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (13 == distance3 % 40 && UIScrean)
            {
                if (�屺��.host == 0 || �屺��.host == 3)
                {
                    �屺�ѱǸ���.SetActive(true);
                }
                if (�屺��.host == 2)
                {
                    if (�屺��.house == 1)
                    {
                        player3.money -= �屺��.basicprice;
                        player2.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player3.money -= �屺��.oneprice;
                        player2.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player3.money -= �屺��.twoprice;
                        player2.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player3.money -= �屺��.threeprice;
                        player2.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player3.money -= �屺��.landprice;
                        player2.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 1)
                {
                    if (�屺��.house == 1)
                    {
                        player3.money -= �屺��.basicprice;
                        player1.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player3.money -= �屺��.oneprice;
                        player1.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player3.money -= �屺��.twoprice;
                        player1.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player3.money -= �屺��.threeprice;
                        player1.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player3.money -= �屺��.landprice;
                        player1.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 4)
                {
                    if (�屺��.house == 1)
                    {
                        player3.money -= �屺��.basicprice;
                        player4.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player3.money -= �屺��.oneprice;
                        player4.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player3.money -= �屺��.twoprice;
                        player4.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player3.money -= �屺��.threeprice;
                        player4.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player3.money -= �屺��.landprice;
                        player4.money += �屺��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance3 % 40 && UIScrean)
            {
                if (���ɿո�.host == 0 || ���ɿո�.host == 3)
                {
                    ���ɿո��Ǹ���.SetActive(true);
                }
                if (���ɿո�.host == 2)
                {
                    if (���ɿո�.house == 1)
                    {
                        player3.money -= ���ɿո�.basicprice;
                        player2.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player3.money -= ���ɿո�.oneprice;
                        player2.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player3.money -= ���ɿո�.twoprice;
                        player2.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player3.money -= ���ɿո�.threeprice;
                        player2.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player3.money -= ���ɿո�.landprice;
                        player2.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 1)
                {
                    if (���ɿո�.house == 1)
                    {
                        player3.money -= ���ɿո�.basicprice;
                        player1.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player3.money -= ���ɿո�.oneprice;
                        player1.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player3.money -= ���ɿո�.twoprice;
                        player1.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player3.money -= ���ɿո�.threeprice;
                        player1.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player3.money -= ���ɿո�.landprice;
                        player1.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 4)
                {
                    if (���ɿո�.house == 1)
                    {
                        player3.money -= ���ɿո�.basicprice;
                        player4.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player3.money -= ���ɿո�.oneprice;
                        player4.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player3.money -= ���ɿո�.twoprice;
                        player4.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player3.money -= ���ɿո�.threeprice;
                        player4.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player3.money -= ���ɿո�.landprice;
                        player4.money += ���ɿո�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance3 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 3)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance3 % 40 && UIScrean)
            {
                if (÷����.host == 0 || ÷����.host == 3)
                {
                    ÷����Ǹ���.SetActive(true);
                }
                if (÷����.host == 2)
                {
                    if (÷����.house == 1)
                    {
                        player3.money -= ÷����.basicprice;
                        player2.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player3.money -= ÷����.oneprice;
                        player2.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player3.money -= ÷����.twoprice;
                        player2.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player3.money -= ÷����.threeprice;
                        player2.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player3.money -= ÷����.landprice;
                        player2.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 1)
                {
                    if (÷����.house == 1)
                    {
                        player3.money -= ÷����.basicprice;
                        player1.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player3.money -= ÷����.oneprice;
                        player1.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player3.money -= ÷����.twoprice;
                        player1.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player3.money -= ÷����.threeprice;
                        player1.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player3.money -= ÷����.landprice;
                        player1.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 4)
                {
                    if (÷����.house == 1)
                    {
                        player3.money -= ÷����.basicprice;
                        player4.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player3.money -= ÷����.oneprice;
                        player4.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player3.money -= ÷����.twoprice;
                        player4.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player3.money -= ÷����.threeprice;
                        player4.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player3.money -= ÷����.landprice;
                        player4.money += ÷����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance3 % 40 && UIScrean)
            {
                if (�ұ���.host == 0 || �ұ���.host == 3)
                {
                    �ұ���Ǹ���.SetActive(true);
                }
                if (�ұ���.host == 2)
                {
                    if (�ұ���.house == 1)
                    {
                        player3.money -= �ұ���.basicprice;
                        player2.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player3.money -= �ұ���.oneprice;
                        player2.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player3.money -= �ұ���.twoprice;
                        player2.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player3.money -= �ұ���.threeprice;
                        player2.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player3.money -= �ұ���.landprice;
                        player2.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 1)
                {
                    if (�ұ���.house == 1)
                    {
                        player3.money -= �ұ���.basicprice;
                        player1.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player3.money -= �ұ���.oneprice;
                        player1.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player3.money -= �ұ���.twoprice;
                        player1.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player3.money -= �ұ���.threeprice;
                        player1.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player3.money -= �ұ���.landprice;
                        player1.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 4)
                {
                    if (�ұ���.house == 1)
                    {
                        player3.money -= �ұ���.basicprice;
                        player4.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player3.money -= �ұ���.oneprice;
                        player4.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player3.money -= �ұ���.twoprice;
                        player4.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player3.money -= �ұ���.threeprice;
                        player4.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player3.money -= �ұ���.landprice;
                        player4.money += �ұ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance3 % 40 && UIScrean)
            {
                if (���λ�.host == 0 || ���λ�.host == 3)
                {
                    ���λ�Ǹ���.SetActive(true);
                }
                if (���λ�.host == 2)
                {
                    if (���λ�.house == 1)
                    {
                        player3.money -= ���λ�.basicprice;
                        player2.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player3.money -= ���λ�.oneprice;
                        player2.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player3.money -= ���λ�.twoprice;
                        player2.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player3.money -= ���λ�.threeprice;
                        player2.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player3.money -= ���λ�.landprice;
                        player2.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 1)
                {
                    if (���λ�.house == 1)
                    {
                        player3.money -= ���λ�.basicprice;
                        player1.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player3.money -= ���λ�.oneprice;
                        player1.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player3.money -= ���λ�.twoprice;
                        player1.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player3.money -= ���λ�.threeprice;
                        player1.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player3.money -= ���λ�.landprice;
                        player1.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 4)
                {
                    if (���λ�.house == 1)
                    {
                        player3.money -= ���λ�.basicprice;
                        player4.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player3.money -= ���λ�.oneprice;
                        player4.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player3.money -= ���λ�.twoprice;
                        player4.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player3.money -= ���λ�.threeprice;
                        player4.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player3.money -= ���λ�.landprice;
                        player4.money += ���λ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance3 % 40 && UIScrean)
            {
                if (ó�μ�.host == 0 || ó�μ�.host == 3)
                {
                    ó�μ��Ǹ���.SetActive(true);
                }
                if (ó�μ�.host == 2)
                {
                    if (ó�μ�.house == 1)
                    {
                        player3.money -= ó�μ�.basicprice;
                        player2.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player3.money -= ó�μ�.oneprice;
                        player2.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player3.money -= ó�μ�.twoprice;
                        player2.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player3.money -= ó�μ�.threeprice;
                        player2.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player3.money -= ó�μ�.landprice;
                        player2.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 1)
                {
                    if (ó�μ�.house == 1)
                    {
                        player3.money -= ó�μ�.basicprice;
                        player1.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player3.money -= ó�μ�.oneprice;
                        player1.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player3.money -= ó�μ�.twoprice;
                        player1.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player3.money -= ó�μ�.threeprice;
                        player1.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player3.money -= ó�μ�.landprice;
                        player1.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 4)
                {
                    if (ó�μ�.house == 1)
                    {
                        player3.money -= ó�μ�.basicprice;
                        player4.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player3.money -= ó�μ�.oneprice;
                        player4.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player3.money -= ó�μ�.twoprice;
                        player4.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player3.money -= ó�μ�.threeprice;
                        player4.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player3.money -= ó�μ�.landprice;
                        player4.money += ó�μ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance3 % 40 && UIScrean)
            {
                if (õ���强.host == 0 || õ���强.host == 3)
                {
                    õ���强�Ǹ���.SetActive(true);
                }
                if (õ���强.host == 2)
                {
                    if (õ���强.house == 1)
                    {
                        player3.money -= õ���强.basicprice;
                        player2.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player3.money -= õ���强.oneprice;
                        player2.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player3.money -= õ���强.twoprice;
                        player2.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player3.money -= õ���强.threeprice;
                        player2.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player3.money -= õ���强.landprice;
                        player2.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 1)
                {
                    if (õ���强.house == 1)
                    {
                        player3.money -= õ���强.basicprice;
                        player1.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player3.money -= õ���强.oneprice;
                        player1.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player3.money -= õ���强.twoprice;
                        player1.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player3.money -= õ���强.threeprice;
                        player1.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player3.money -= õ���强.landprice;
                        player1.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 4)
                {
                    if (õ���强.house == 1)
                    {
                        player3.money -= õ���强.basicprice;
                        player4.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player3.money -= õ���强.oneprice;
                        player4.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player3.money -= õ���强.twoprice;
                        player4.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player3.money -= õ���强.threeprice;
                        player4.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player3.money -= õ���强.landprice;
                        player4.money += õ���强.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance3 % 40 && UIScrean)
            {
                if (�溹��.host == 0 || �溹��.host == 3)
                {
                    �溹�ñǸ���.SetActive(true);
                }
                if (�溹��.host == 2)
                {
                    if (�溹��.house == 1)
                    {
                        player3.money -= �溹��.basicprice;
                        player2.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player3.money -= �溹��.oneprice;
                        player2.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player3.money -= �溹��.twoprice;
                        player2.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player3.money -= �溹��.threeprice;
                        player2.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player3.money -= �溹��.landprice;
                        player2.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 1)
                {
                    if (�溹��.house == 1)
                    {
                        player3.money -= �溹��.basicprice;
                        player1.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player3.money -= �溹��.oneprice;
                        player1.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player3.money -= �溹��.twoprice;
                        player1.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player3.money -= �溹��.threeprice;
                        player1.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player3.money -= �溹��.landprice;
                        player1.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 4)
                {
                    if (�溹��.house == 1)
                    {
                        player3.money -= �溹��.basicprice;
                        player4.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player3.money -= �溹��.oneprice;
                        player4.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player3.money -= �溹��.twoprice;
                        player4.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player3.money -= �溹��.threeprice;
                        player4.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player3.money -= �溹��.landprice;
                        player4.money += �溹��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance3 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 3)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (29 == distance3 % 40 && UIScrean)
            {
                if (â����.host == 0 || â����.host == 3)
                {
                    â���ñǸ���.SetActive(true);
                }
                if (â����.host == 2)
                {
                    if (â����.house == 1)
                    {
                        player3.money -= â����.basicprice;
                        player2.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player3.money -= â����.oneprice;
                        player2.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player3.money -= â����.twoprice;
                        player2.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player3.money -= â����.threeprice;
                        player2.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player3.money -= â����.landprice;
                        player2.money += â����.landprice;
                    }
                }
                else if (â����.host == 1)
                {
                    if (â����.house == 1)
                    {
                        player3.money -= â����.basicprice;
                        player1.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player3.money -= â����.oneprice;
                        player1.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player3.money -= â����.twoprice;
                        player1.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player3.money -= â����.threeprice;
                        player1.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player3.money -= â����.landprice;
                        player1.money += â����.landprice;
                    }
                }
                else if (â����.host == 4)
                {
                    if (â����.house == 1)
                    {
                        player3.money -= â����.basicprice;
                        player4.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player3.money -= â����.oneprice;
                        player4.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player3.money -= â����.twoprice;
                        player4.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player3.money -= â����.threeprice;
                        player4.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player3.money -= â����.landprice;
                        player4.money += â����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance3 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 3)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance3 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 3)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                else if (������.host == 4)
                {
                    if (������.house == 1)
                    {
                        player3.money -= ������.basicprice;
                        player4.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player3.money -= ������.oneprice;
                        player4.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player3.money -= ������.twoprice;
                        player4.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player3.money -= ������.threeprice;
                        player4.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player3.money -= ������.landprice;
                        player4.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance3 % 40 && UIScrean)
            {
                if (���������.host == 0 || ���������.host == 3)
                {
                    ���������Ǹ���.SetActive(true);
                }
                if (���������.host == 2)
                {
                    if (���������.house == 1)
                    {
                        player3.money -= ���������.basicprice;
                        player2.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player3.money -= ���������.oneprice;
                        player2.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player3.money -= ���������.twoprice;
                        player2.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player3.money -= ���������.threeprice;
                        player2.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player3.money -= ���������.landprice;
                        player2.money += ���������.landprice;
                    }
                }
                else if (���������.host == 1)
                {
                    if (���������.house == 1)
                    {
                        player3.money -= ���������.basicprice;
                        player1.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player3.money -= ���������.oneprice;
                        player1.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player3.money -= ���������.twoprice;
                        player1.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player3.money -= ���������.threeprice;
                        player1.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player3.money -= ���������.landprice;
                        player1.money += ���������.landprice;
                    }
                }
                else if (���������.host == 4)
                {
                    if (���������.house == 1)
                    {
                        player3.money -= ���������.basicprice;
                        player4.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player3.money -= ���������.oneprice;
                        player4.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player3.money -= ���������.twoprice;
                        player4.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player3.money -= ���������.threeprice;
                        player4.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player3.money -= ���������.landprice;
                        player4.money += ���������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance3 % 40 && UIScrean)
            {
                if (��õ.host == 0 || ��õ.host == 3)
                {
                    ��õ�Ǹ���.SetActive(true);
                }
                if (��õ.host == 2)
                {
                    if (��õ.house == 1)
                    {
                        player3.money -= ��õ.basicprice;
                        player2.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player3.money -= ��õ.oneprice;
                        player2.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player3.money -= ��õ.twoprice;
                        player2.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player3.money -= ��õ.threeprice;
                        player2.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player3.money -= ��õ.landprice;
                        player2.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 1)
                {
                    if (��õ.house == 1)
                    {
                        player3.money -= ��õ.basicprice;
                        player1.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player3.money -= ��õ.oneprice;
                        player1.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player3.money -= ��õ.twoprice;
                        player1.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player3.money -= ��õ.threeprice;
                        player1.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player3.money -= ��õ.landprice;
                        player1.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 4)
                {
                    if (��õ.house == 1)
                    {
                        player3.money -= ��õ.basicprice;
                        player4.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player3.money -= ��õ.oneprice;
                        player4.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player3.money -= ��õ.twoprice;
                        player4.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player3.money -= ��õ.threeprice;
                        player4.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player3.money -= ��õ.landprice;
                        player4.money += ��õ.landprice;
                    }
                }
                UIScrean = false;

            }
            if (39 == distance3 % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 3)
                {
                    ����Ǹ���.SetActive(true);
                }
                if (����.host == 2)
                {
                    if (����.house == 1)
                    {
                        player3.money -= ����.basicprice;
                        player2.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player3.money -= ����.oneprice;
                        player2.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player3.money -= ����.twoprice;
                        player2.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player3.money -= ����.threeprice;
                        player2.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player3.money -= ����.landprice;
                        player2.money += ����.landprice;
                    }
                }
                else if (����.host == 1)
                {
                    if (����.house == 1)
                    {
                        player3.money -= ����.basicprice;
                        player1.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player3.money -= ����.oneprice;
                        player1.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player3.money -= ����.twoprice;
                        player1.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player3.money -= ����.threeprice;
                        player1.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player3.money -= ����.landprice;
                        player1.money += ����.landprice;
                    }
                }
                else if (����.host == 4)
                {
                    if (����.house == 1)
                    {
                        player3.money -= ����.basicprice;
                        player4.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player3.money -= ����.oneprice;
                        player4.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player3.money -= ����.twoprice;
                        player4.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player3.money -= ����.threeprice;
                        player4.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player3.money -= ����.landprice;
                        player4.money += ����.landprice;
                    }
                }
                UIScrean = false;

            }
            if (4 == distance3 % 40 && UIScrean)
            {
                �糭ī��1.SetActive(true);
                UIScrean = false;
            }
            if (12 == distance3 % 40 && UIScrean)
            {
                �糭ī��2.SetActive(true);
                UIScrean = false;
            }
            if (28 == distance3 % 40 && UIScrean)
            {
                �糭ī��3.SetActive(true);
                UIScrean = false;
            }
            if (38 == distance3 % 40 && UIScrean)
            {
                �糭ī��4.SetActive(true);
                UIScrean = false;
            }
            if (5 == distance3 % 40 && UIScrean)
            {
                if (����.host == 0)
                {
                    ����1.SetActive(true);
                }
                else if (����.host == 1)
                {
                    player3.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host == 2)
                {
                    player3.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host == 4)
                {
                    player3.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance3 % 40 && UIScrean)
            {
                if (����.host2 == 0)
                {
                    ����2.SetActive(true);
                }
                else if (����.host2 == 1)
                {
                    player3.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host2 == 2)
                {
                    player3.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host2 == 4)
                {
                    player3.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance3 % 40 && UIScrean)
            {
                if (����.host3 == 0)
                {
                    ����3.SetActive(true);
                }
                else if (����.host3 == 1)
                {
                    player3.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host3 == 2)
                {
                    player3.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host3 == 4)
                {
                    player3.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance3 % 40 && UIScrean)
            {
                if (����.host4 == 0)
                {
                    ����4.SetActive(true);
                }
                else if (����.host4 == 1)
                {
                    player3.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host4 == 2)
                {
                    player3.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                else if (����.host4 == 4)
                {
                    player3.money -= ����.weapon4 * 100;
                    player4.money += ����.weapon4 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance3 % 40 || 17 == distance3 % 40 || 33 == distance3) && UIScrean)
            {
                ��ȸ���.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance3 % 40 || 22 == distance3 % 40 || 36 == distance3) && UIScrean)
            {
                ����ī��.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance3 % 40 && UIScrean)
            {
                Ÿ�Ӹӽ�.SetActive(true);
                UIScrean = false;
            }
            if (�����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �����Ǹ���.SetActive(false);
                //UIScrean = true;
            }
            else if (���Ͽ����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���Ͽ����Ǹ���.SetActive(false);
            }
            else if (��������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��������Ǹ���.SetActive(false);
            }
            else if (���ε��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ε��Ǹ���.SetActive(false);
            }
            else if (�ζѸ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ζѸ��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�屺�ѱǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �屺�ѱǸ���.SetActive(false);
            }
            else if (���ɿո��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ɿո��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (÷����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ÷����Ǹ���.SetActive(false);
            }
            else if (�ұ���Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ұ���Ǹ���.SetActive(false);
            }
            else if (���λ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���λ�Ǹ���.SetActive(false);
            }
            else if (ó�μ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ó�μ��Ǹ���.SetActive(false);
            }
            else if (õ���强�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                õ���强�Ǹ���.SetActive(false);
            }
            else if (�溹�ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �溹�ñǸ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (â���ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                â���ñǸ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (���������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���������Ǹ���.SetActive(false);
            }
            else if (��õ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��õ�Ǹ���.SetActive(false);
            }
            else if (����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����Ǹ���.SetActive(false);
            }
            else if (�糭ī��1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��1.SetActive(false);
            }
            else if (�糭ī��2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��2.SetActive(false);
            }
            else if (�糭ī��3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��3.SetActive(false);
            }
            else if (�糭ī��4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��4.SetActive(false);
            }
            else if (����1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����1.SetActive(false);
            }
            else if (����2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����2.SetActive(false);
            }
            else if (����3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����3.SetActive(false);
            }
            else if (����4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����4.SetActive(false);
            }
            else if (��ȸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��ȸ���.SetActive(false);
            }
            else if (����ī��.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����ī��.SetActive(false);
            }
        }
        else if (DiceScript.order == 1)
        {
            if (1 == distance4 % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 4)
                {
                    �����Ǹ���.SetActive(true);
                }
                if (����.host == 2)
                {
                    if (����.house == 1)
                    {
                        player4.money -= ����.basicprice;
                        player2.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player4.money -= ����.oneprice;
                        player2.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player4.money -= ����.twoprice;
                        player2.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player4.money -= ����.threeprice;
                        player2.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player4.money -= ����.landprice;
                        player2.money += ����.landprice;
                    }
                }
                else if (����.host == 3)
                {
                    if (����.house == 1)
                    {
                        player4.money -= ����.basicprice;
                        player3.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player4.money -= ����.oneprice;
                        player3.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player4.money -= ����.twoprice;
                        player3.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player4.money -= ����.threeprice;
                        player3.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player4.money -= ����.landprice;
                        player3.money += ����.landprice;
                    }
                }
                else if (����.host == 1)
                {
                    if (����.house == 1)
                    {
                        player4.money -= ����.basicprice;
                        player1.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player4.money -= ����.oneprice;
                        player1.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player4.money -= ����.twoprice;
                        player1.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player4.money -= ����.threeprice;
                        player1.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player4.money -= ����.landprice;
                        player1.money += ����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (3 == distance4 % 40 && UIScrean)
            {
                if (���Ͽ���.host == 0 || ���Ͽ���.host == 4)
                {
                    ���Ͽ����Ǹ���.SetActive(true);
                }
                if (���Ͽ���.host == 2)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player4.money -= ���Ͽ���.basicprice;
                        player2.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player4.money -= ���Ͽ���.oneprice;
                        player2.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player4.money -= ���Ͽ���.twoprice;
                        player2.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player4.money -= ���Ͽ���.threeprice;
                        player2.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player4.money -= ���Ͽ���.landprice;
                        player2.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 3)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player4.money -= ���Ͽ���.basicprice;
                        player3.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player4.money -= ���Ͽ���.oneprice;
                        player3.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player4.money -= ���Ͽ���.twoprice;
                        player3.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player4.money -= ���Ͽ���.threeprice;
                        player3.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player4.money -= ���Ͽ���.landprice;
                        player3.money += ���Ͽ���.landprice;
                    }
                }
                else if (���Ͽ���.host == 1)
                {
                    if (���Ͽ���.house == 1)
                    {
                        player4.money -= ���Ͽ���.basicprice;
                        player1.money += ���Ͽ���.basicprice;
                    }
                    else if (���Ͽ���.house == 2)
                    {
                        player4.money -= ���Ͽ���.oneprice;
                        player1.money += ���Ͽ���.oneprice;
                    }
                    else if (���Ͽ���.house == 3)
                    {
                        player4.money -= ���Ͽ���.twoprice;
                        player1.money += ���Ͽ���.twoprice;
                    }
                    else if (���Ͽ���.house == 4)
                    {
                        player4.money -= ���Ͽ���.threeprice;
                        player1.money += ���Ͽ���.threeprice;
                    }
                    else if (���Ͽ���.house == 5)
                    {
                        player4.money -= ���Ͽ���.landprice;
                        player1.money += ���Ͽ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (6 == distance4 % 40 && UIScrean)
            {
                if (�������.host == 0 || �������.host == 4)
                {
                    ��������Ǹ���.SetActive(true);
                }
                if (�������.host == 2)
                {
                    if (�������.house == 1)
                    {
                        player4.money -= �������.basicprice;
                        player2.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player4.money -= �������.oneprice;
                        player2.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player4.money -= �������.twoprice;
                        player2.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player4.money -= �������.threeprice;
                        player2.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player4.money -= �������.landprice;
                        player2.money += �������.landprice;
                    }
                }
                else if (�������.host == 3)
                {
                    if (�������.house == 1)
                    {
                        player4.money -= �������.basicprice;
                        player3.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player4.money -= �������.oneprice;
                        player3.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player4.money -= �������.twoprice;
                        player3.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player4.money -= �������.threeprice;
                        player3.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player4.money -= �������.landprice;
                        player3.money += �������.landprice;
                    }
                }
                else if (�������.host == 1)
                {
                    if (�������.house == 1)
                    {
                        player4.money -= �������.basicprice;
                        player1.money += �������.basicprice;
                    }
                    else if (�������.house == 2)
                    {
                        player4.money -= �������.oneprice;
                        player1.money += �������.oneprice;
                    }
                    else if (�������.house == 3)
                    {
                        player4.money -= �������.twoprice;
                        player1.money += �������.twoprice;
                    }
                    else if (�������.house == 4)
                    {
                        player4.money -= �������.threeprice;
                        player1.money += �������.threeprice;
                    }
                    else if (�������.house == 5)
                    {
                        player4.money -= �������.landprice;
                        player1.money += �������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (8 == distance4 % 40 && UIScrean)
            {
                if (���ε�.host == 0 || ���ε�.host == 4)
                {
                    ���ε��Ǹ���.SetActive(true);
                }
                if (���ε�.host == 2)
                {
                    if (���ε�.house == 1)
                    {
                        player4.money -= ���ε�.basicprice;
                        player2.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player4.money -= ���ε�.oneprice;
                        player2.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player4.money -= ���ε�.twoprice;
                        player2.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player4.money -= ���ε�.threeprice;
                        player2.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player4.money -= ���ε�.landprice;
                        player2.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 3)
                {
                    if (���ε�.house == 1)
                    {
                        player4.money -= ���ε�.basicprice;
                        player3.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player4.money -= ���ε�.oneprice;
                        player3.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player4.money -= ���ε�.twoprice;
                        player3.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player4.money -= ���ε�.threeprice;
                        player3.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player4.money -= ���ε�.landprice;
                        player3.money += ���ε�.landprice;
                    }
                }
                else if (���ε�.host == 1)
                {
                    if (���ε�.house == 1)
                    {
                        player4.money -= ���ε�.basicprice;
                        player1.money += ���ε�.basicprice;
                    }
                    else if (���ε�.house == 2)
                    {
                        player4.money -= ���ε�.oneprice;
                        player1.money += ���ε�.oneprice;
                    }
                    else if (���ε�.house == 3)
                    {
                        player4.money -= ���ε�.twoprice;
                        player1.money += ���ε�.twoprice;
                    }
                    else if (���ε�.house == 4)
                    {
                        player4.money -= ���ε�.threeprice;
                        player1.money += ���ε�.threeprice;
                    }
                    else if (���ε�.house == 5)
                    {
                        player4.money -= ���ε�.landprice;
                        player1.money += ���ε�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (9 == distance4 % 40 && UIScrean)
            {
                if (�ζѸ�.host == 0 || �ζѸ�.host == 4)
                {
                    �ζѸ��Ǹ���.SetActive(true);
                }
                if (�ζѸ�.host == 2)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player4.money -= �ζѸ�.basicprice;
                        player2.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player4.money -= �ζѸ�.oneprice;
                        player2.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player4.money -= �ζѸ�.twoprice;
                        player2.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player4.money -= �ζѸ�.threeprice;
                        player2.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player4.money -= �ζѸ�.landprice;
                        player2.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 3)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player4.money -= �ζѸ�.basicprice;
                        player3.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player4.money -= �ζѸ�.oneprice;
                        player3.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player4.money -= �ζѸ�.twoprice;
                        player3.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player4.money -= �ζѸ�.threeprice;
                        player3.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player4.money -= �ζѸ�.landprice;
                        player3.money += �ζѸ�.landprice;
                    }
                }
                else if (�ζѸ�.host == 1)
                {
                    if (�ζѸ�.house == 1)
                    {
                        player4.money -= �ζѸ�.basicprice;
                        player1.money += �ζѸ�.basicprice;
                    }
                    else if (�ζѸ�.house == 2)
                    {
                        player4.money -= �ζѸ�.oneprice;
                        player1.money += �ζѸ�.oneprice;
                    }
                    else if (�ζѸ�.house == 3)
                    {
                        player4.money -= �ζѸ�.twoprice;
                        player1.money += �ζѸ�.twoprice;
                    }
                    else if (�ζѸ�.house == 4)
                    {
                        player4.money -= �ζѸ�.threeprice;
                        player1.money += �ζѸ�.threeprice;
                    }
                    else if (�ζѸ�.house == 5)
                    {
                        player4.money -= �ζѸ�.landprice;
                        player1.money += �ζѸ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (11 == distance4 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 4)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (13 == distance4 % 40 && UIScrean)
            {
                if (�屺��.host == 0 || �屺��.host == 4)
                {
                    �屺�ѱǸ���.SetActive(true);
                }
                if (�屺��.host == 2)
                {
                    if (�屺��.house == 1)
                    {
                        player4.money -= �屺��.basicprice;
                        player2.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player4.money -= �屺��.oneprice;
                        player2.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player4.money -= �屺��.twoprice;
                        player2.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player4.money -= �屺��.threeprice;
                        player2.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player4.money -= �屺��.landprice;
                        player2.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 3)
                {
                    if (�屺��.house == 1)
                    {
                        player4.money -= �屺��.basicprice;
                        player3.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player4.money -= �屺��.oneprice;
                        player3.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player4.money -= �屺��.twoprice;
                        player3.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player4.money -= �屺��.threeprice;
                        player3.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player4.money -= �屺��.landprice;
                        player3.money += �屺��.landprice;
                    }
                }
                else if (�屺��.host == 1)
                {
                    if (�屺��.house == 1)
                    {
                        player4.money -= �屺��.basicprice;
                        player1.money += �屺��.basicprice;
                    }
                    else if (�屺��.house == 2)
                    {
                        player4.money -= �屺��.oneprice;
                        player1.money += �屺��.oneprice;
                    }
                    else if (�屺��.house == 3)
                    {
                        player4.money -= �屺��.twoprice;
                        player1.money += �屺��.twoprice;
                    }
                    else if (�屺��.house == 4)
                    {
                        player4.money -= �屺��.threeprice;
                        player1.money += �屺��.threeprice;
                    }
                    else if (�屺��.house == 5)
                    {
                        player4.money -= �屺��.landprice;
                        player1.money += �屺��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (14 == distance4 % 40 && UIScrean)
            {
                if (���ɿո�.host == 0 || ���ɿո�.host == 4)
                {
                    ���ɿո��Ǹ���.SetActive(true);
                }
                if (���ɿո�.host == 2)
                {
                    if (���ɿո�.house == 1)
                    {
                        player4.money -= ���ɿո�.basicprice;
                        player2.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player4.money -= ���ɿո�.oneprice;
                        player2.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player4.money -= ���ɿո�.twoprice;
                        player2.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player4.money -= ���ɿո�.threeprice;
                        player2.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player4.money -= ���ɿո�.landprice;
                        player2.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 3)
                {
                    if (���ɿո�.house == 1)
                    {
                        player4.money -= ���ɿո�.basicprice;
                        player3.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player4.money -= ���ɿո�.oneprice;
                        player3.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player4.money -= ���ɿո�.twoprice;
                        player3.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player4.money -= ���ɿո�.threeprice;
                        player3.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player4.money -= ���ɿո�.landprice;
                        player3.money += ���ɿո�.landprice;
                    }
                }
                else if (���ɿո�.host == 1)
                {
                    if (���ɿո�.house == 1)
                    {
                        player4.money -= ���ɿո�.basicprice;
                        player1.money += ���ɿո�.basicprice;
                    }
                    else if (���ɿո�.house == 2)
                    {
                        player4.money -= ���ɿո�.oneprice;
                        player1.money += ���ɿո�.oneprice;
                    }
                    else if (���ɿո�.house == 3)
                    {
                        player4.money -= ���ɿո�.twoprice;
                        player1.money += ���ɿո�.twoprice;
                    }
                    else if (���ɿո�.house == 4)
                    {
                        player4.money -= ���ɿո�.threeprice;
                        player1.money += ���ɿո�.threeprice;
                    }
                    else if (���ɿո�.house == 5)
                    {
                        player4.money -= ���ɿո�.landprice;
                        player1.money += ���ɿո�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (16 == distance4 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 4)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (18 == distance4 % 40 && UIScrean)
            {
                if (÷����.host == 0 || ÷����.host == 4)
                {
                    Debug.Log("����");
                    ÷����Ǹ���.SetActive(true);
                }
                if (÷����.host == 2)
                {
                    if (÷����.house == 1)
                    {
                        player4.money -= ÷����.basicprice;
                        player2.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player4.money -= ÷����.oneprice;
                        player2.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player4.money -= ÷����.twoprice;
                        player2.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player4.money -= ÷����.threeprice;
                        player2.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player4.money -= ÷����.landprice;
                        player2.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 3)
                {
                    if (÷����.house == 1)
                    {
                        player4.money -= ÷����.basicprice;
                        player3.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player4.money -= ÷����.oneprice;
                        player3.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player4.money -= ÷����.twoprice;
                        player3.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player4.money -= ÷����.threeprice;
                        player3.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player4.money -= ÷����.landprice;
                        player3.money += ÷����.landprice;
                    }
                }
                else if (÷����.host == 1)
                {
                    if (÷����.house == 1)
                    {
                        player4.money -= ÷����.basicprice;
                        player1.money += ÷����.basicprice;
                    }
                    else if (÷����.house == 2)
                    {
                        player4.money -= ÷����.oneprice;
                        player1.money += ÷����.oneprice;
                    }
                    else if (÷����.house == 3)
                    {
                        player4.money -= ÷����.twoprice;
                        player1.money += ÷����.twoprice;
                    }
                    else if (÷����.house == 4)
                    {
                        player4.money -= ÷����.threeprice;
                        player1.money += ÷����.threeprice;
                    }
                    else if (÷����.house == 5)
                    {
                        player4.money -= ÷����.landprice;
                        player1.money += ÷����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (19 == distance4 % 40 && UIScrean)
            {
                if (�ұ���.host == 0 || �ұ���.host == 4)
                {
                    �ұ���Ǹ���.SetActive(true);
                }
                if (�ұ���.host == 2)
                {
                    if (�ұ���.house == 1)
                    {
                        player4.money -= �ұ���.basicprice;
                        player2.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player4.money -= �ұ���.oneprice;
                        player2.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player4.money -= �ұ���.twoprice;
                        player2.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player4.money -= �ұ���.threeprice;
                        player2.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player4.money -= �ұ���.landprice;
                        player2.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 3)
                {
                    if (�ұ���.house == 1)
                    {
                        player4.money -= �ұ���.basicprice;
                        player3.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player4.money -= �ұ���.oneprice;
                        player3.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player4.money -= �ұ���.twoprice;
                        player3.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player4.money -= �ұ���.threeprice;
                        player3.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player4.money -= �ұ���.landprice;
                        player3.money += �ұ���.landprice;
                    }
                }
                else if (�ұ���.host == 1)
                {
                    if (�ұ���.house == 1)
                    {
                        player4.money -= �ұ���.basicprice;
                        player1.money += �ұ���.basicprice;
                    }
                    else if (�ұ���.house == 2)
                    {
                        player4.money -= �ұ���.oneprice;
                        player1.money += �ұ���.oneprice;
                    }
                    else if (�ұ���.house == 3)
                    {
                        player4.money -= �ұ���.twoprice;
                        player1.money += �ұ���.twoprice;
                    }
                    else if (�ұ���.house == 4)
                    {
                        player4.money -= �ұ���.threeprice;
                        player1.money += �ұ���.threeprice;
                    }
                    else if (�ұ���.house == 5)
                    {
                        player4.money -= �ұ���.landprice;
                        player1.money += �ұ���.landprice;
                    }
                }
                UIScrean = false;
            }
            if (21 == distance4 % 40 && UIScrean)
            {
                if (���λ�.host == 0 || ���λ�.host == 4)
                {
                    ���λ�Ǹ���.SetActive(true);
                }
                if (���λ�.host == 2)
                {
                    if (���λ�.house == 1)
                    {
                        player4.money -= ���λ�.basicprice;
                        player2.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player4.money -= ���λ�.oneprice;
                        player2.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player4.money -= ���λ�.twoprice;
                        player2.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player4.money -= ���λ�.threeprice;
                        player2.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player4.money -= ���λ�.landprice;
                        player2.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 3)
                {
                    if (���λ�.house == 1)
                    {
                        player4.money -= ���λ�.basicprice;
                        player3.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player4.money -= ���λ�.oneprice;
                        player3.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player4.money -= ���λ�.twoprice;
                        player3.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player4.money -= ���λ�.threeprice;
                        player3.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player4.money -= ���λ�.landprice;
                        player3.money += ���λ�.landprice;
                    }
                }
                else if (���λ�.host == 1)
                {
                    if (���λ�.house == 1)
                    {
                        player4.money -= ���λ�.basicprice;
                        player1.money += ���λ�.basicprice;
                    }
                    else if (���λ�.house == 2)
                    {
                        player4.money -= ���λ�.oneprice;
                        player1.money += ���λ�.oneprice;
                    }
                    else if (���λ�.house == 3)
                    {
                        player4.money -= ���λ�.twoprice;
                        player1.money += ���λ�.twoprice;
                    }
                    else if (���λ�.house == 4)
                    {
                        player4.money -= ���λ�.threeprice;
                        player1.money += ���λ�.threeprice;
                    }
                    else if (���λ�.house == 5)
                    {
                        player4.money -= ���λ�.landprice;
                        player1.money += ���λ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (23 == distance4 % 40 && UIScrean)
            {
                if (ó�μ�.host == 0 || ó�μ�.host == 4)
                {
                    ó�μ��Ǹ���.SetActive(true);
                }
                if (ó�μ�.host == 2)
                {
                    if (ó�μ�.house == 1)
                    {
                        player4.money -= ó�μ�.basicprice;
                        player2.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player4.money -= ó�μ�.oneprice;
                        player2.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player4.money -= ó�μ�.twoprice;
                        player2.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player4.money -= ó�μ�.threeprice;
                        player2.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player4.money -= ó�μ�.landprice;
                        player2.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 3)
                {
                    if (ó�μ�.house == 1)
                    {
                        player4.money -= ó�μ�.basicprice;
                        player3.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player4.money -= ó�μ�.oneprice;
                        player3.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player4.money -= ó�μ�.twoprice;
                        player3.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player4.money -= ó�μ�.threeprice;
                        player3.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player4.money -= ó�μ�.landprice;
                        player3.money += ó�μ�.landprice;
                    }
                }
                else if (ó�μ�.host == 1)
                {
                    if (ó�μ�.house == 1)
                    {
                        player4.money -= ó�μ�.basicprice;
                        player1.money += ó�μ�.basicprice;
                    }
                    else if (ó�μ�.house == 2)
                    {
                        player4.money -= ó�μ�.oneprice;
                        player1.money += ó�μ�.oneprice;
                    }
                    else if (ó�μ�.house == 3)
                    {
                        player4.money -= ó�μ�.twoprice;
                        player1.money += ó�μ�.twoprice;
                    }
                    else if (ó�μ�.house == 4)
                    {
                        player4.money -= ó�μ�.threeprice;
                        player1.money += ó�μ�.threeprice;
                    }
                    else if (ó�μ�.house == 5)
                    {
                        player4.money -= ó�μ�.landprice;
                        player1.money += ó�μ�.landprice;
                    }
                }
                UIScrean = false;
            }
            if (24 == distance4 % 40 && UIScrean)
            {
                if (õ���强.host == 0 || õ���强.host == 4)
                {
                    õ���强�Ǹ���.SetActive(true);
                }
                if (õ���强.host == 2)
                {
                    if (õ���强.house == 1)
                    {
                        player4.money -= õ���强.basicprice;
                        player2.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player4.money -= õ���强.oneprice;
                        player2.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player4.money -= õ���强.twoprice;
                        player2.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player4.money -= õ���强.threeprice;
                        player2.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player4.money -= õ���强.landprice;
                        player2.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 3)
                {
                    if (õ���强.house == 1)
                    {
                        player4.money -= õ���强.basicprice;
                        player3.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player4.money -= õ���强.oneprice;
                        player3.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player4.money -= õ���强.twoprice;
                        player3.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player4.money -= õ���强.threeprice;
                        player3.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player4.money -= õ���强.landprice;
                        player3.money += õ���强.landprice;
                    }
                }
                else if (õ���强.host == 1)
                {
                    if (õ���强.house == 1)
                    {
                        player4.money -= õ���强.basicprice;
                        player1.money += õ���强.basicprice;
                    }
                    else if (õ���强.house == 2)
                    {
                        player4.money -= õ���强.oneprice;
                        player1.money += õ���强.oneprice;
                    }
                    else if (õ���强.house == 3)
                    {
                        player4.money -= õ���强.twoprice;
                        player1.money += õ���强.twoprice;
                    }
                    else if (õ���强.house == 4)
                    {
                        player4.money -= õ���强.threeprice;
                        player1.money += õ���强.threeprice;
                    }
                    else if (õ���强.house == 5)
                    {
                        player4.money -= õ���强.landprice;
                        player1.money += õ���强.landprice;
                    }
                }
                UIScrean = false;
            }
            if (26 == distance4 % 40 && UIScrean)
            {
                if (�溹��.host == 0 || �溹��.host == 4)
                {
                    �溹�ñǸ���.SetActive(true);
                }
                if (�溹��.host == 2)
                {
                    if (�溹��.house == 1)
                    {
                        player4.money -= �溹��.basicprice;
                        player2.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player4.money -= �溹��.oneprice;
                        player2.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player4.money -= �溹��.twoprice;
                        player2.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player4.money -= �溹��.threeprice;
                        player2.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player4.money -= �溹��.landprice;
                        player2.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 3)
                {
                    if (�溹��.house == 1)
                    {
                        player4.money -= �溹��.basicprice;
                        player3.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player4.money -= �溹��.oneprice;
                        player3.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player4.money -= �溹��.twoprice;
                        player3.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player4.money -= �溹��.threeprice;
                        player3.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player4.money -= �溹��.landprice;
                        player3.money += �溹��.landprice;
                    }
                }
                else if (�溹��.host == 1)
                {
                    if (�溹��.house == 1)
                    {
                        player4.money -= �溹��.basicprice;
                        player1.money += �溹��.basicprice;
                    }
                    else if (�溹��.house == 2)
                    {
                        player4.money -= �溹��.oneprice;
                        player1.money += �溹��.oneprice;
                    }
                    else if (�溹��.house == 3)
                    {
                        player4.money -= �溹��.twoprice;
                        player1.money += �溹��.twoprice;
                    }
                    else if (�溹��.house == 4)
                    {
                        player4.money -= �溹��.threeprice;
                        player1.money += �溹��.threeprice;
                    }
                    else if (�溹��.house == 5)
                    {
                        player4.money -= �溹��.landprice;
                        player1.money += �溹��.landprice;
                    }
                }
                UIScrean = false;
            }
            if (27 == distance4 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 4)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (29 == distance4 % 40 && UIScrean)
            {
                if (â����.host == 0 || â����.host == 4)
                {
                    â���ñǸ���.SetActive(true);
                }
                if (â����.host == 2)
                {
                    if (â����.house == 1)
                    {
                        player4.money -= â����.basicprice;
                        player2.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player4.money -= â����.oneprice;
                        player2.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player4.money -= â����.twoprice;
                        player2.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player4.money -= â����.threeprice;
                        player2.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player4.money -= â����.landprice;
                        player2.money += â����.landprice;
                    }
                }
                else if (â����.host == 3)
                {
                    if (â����.house == 1)
                    {
                        player4.money -= â����.basicprice;
                        player3.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player4.money -= â����.oneprice;
                        player3.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player4.money -= â����.twoprice;
                        player3.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player4.money -= â����.threeprice;
                        player3.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player4.money -= â����.landprice;
                        player3.money += â����.landprice;
                    }
                }
                else if (â����.host == 1)
                {
                    if (â����.house == 1)
                    {
                        player4.money -= â����.basicprice;
                        player1.money += â����.basicprice;
                    }
                    else if (â����.house == 2)
                    {
                        player4.money -= â����.oneprice;
                        player1.money += â����.oneprice;
                    }
                    else if (â����.house == 3)
                    {
                        player4.money -= â����.twoprice;
                        player1.money += â����.twoprice;
                    }
                    else if (â����.house == 4)
                    {
                        player4.money -= â����.threeprice;
                        player1.money += â����.threeprice;
                    }
                    else if (â����.house == 5)
                    {
                        player4.money -= â����.landprice;
                        player1.money += â����.landprice;
                    }
                }
                UIScrean = false;
            }
            if (31 == distance4 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 4)
                {
                    ������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (32 == distance4 % 40 && UIScrean)
            {
                if (������.host == 0 || ������.host == 4)
                {
                    �������Ǹ���.SetActive(true);
                }
                if (������.host == 2)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player2.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player2.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player2.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player2.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player2.money += ������.landprice;
                    }
                }
                else if (������.host == 3)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player3.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player3.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player3.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player3.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player3.money += ������.landprice;
                    }
                }
                else if (������.host == 1)
                {
                    if (������.house == 1)
                    {
                        player4.money -= ������.basicprice;
                        player1.money += ������.basicprice;
                    }
                    else if (������.house == 2)
                    {
                        player4.money -= ������.oneprice;
                        player1.money += ������.oneprice;
                    }
                    else if (������.house == 3)
                    {
                        player4.money -= ������.twoprice;
                        player1.money += ������.twoprice;
                    }
                    else if (������.house == 4)
                    {
                        player4.money -= ������.threeprice;
                        player1.money += ������.threeprice;
                    }
                    else if (������.house == 5)
                    {
                        player4.money -= ������.landprice;
                        player1.money += ������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (34 == distance4 % 40 && UIScrean)
            {
                if (���������.host == 0 || ���������.host == 4)
                {
                    ���������Ǹ���.SetActive(true);
                }
                if (���������.host == 2)
                {
                    if (���������.house == 1)
                    {
                        player4.money -= ���������.basicprice;
                        player2.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player4.money -= ���������.oneprice;
                        player2.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player4.money -= ���������.twoprice;
                        player2.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player4.money -= ���������.threeprice;
                        player2.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player4.money -= ���������.landprice;
                        player2.money += ���������.landprice;
                    }
                }
                else if (���������.host == 3)
                {
                    if (���������.house == 1)
                    {
                        player4.money -= ���������.basicprice;
                        player3.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player4.money -= ���������.oneprice;
                        player3.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player4.money -= ���������.twoprice;
                        player3.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player4.money -= ���������.threeprice;
                        player3.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player4.money -= ���������.landprice;
                        player3.money += ���������.landprice;
                    }
                }
                else if (���������.host == 1)
                {
                    if (���������.house == 1)
                    {
                        player4.money -= ���������.basicprice;
                        player1.money += ���������.basicprice;
                    }
                    else if (���������.house == 2)
                    {
                        player4.money -= ���������.oneprice;
                        player1.money += ���������.oneprice;
                    }
                    else if (���������.house == 3)
                    {
                        player4.money -= ���������.twoprice;
                        player1.money += ���������.twoprice;
                    }
                    else if (���������.house == 4)
                    {
                        player4.money -= ���������.threeprice;
                        player1.money += ���������.threeprice;
                    }
                    else if (���������.house == 5)
                    {
                        player4.money -= ���������.landprice;
                        player1.money += ���������.landprice;
                    }
                }
                UIScrean = false;
            }
            if (37 == distance4 % 40 && UIScrean)
            {
                if (��õ.host == 0 || ��õ.host == 4)
                {
                    ��õ�Ǹ���.SetActive(true);
                }
                if (��õ.host == 2)
                {
                    if (��õ.house == 1)
                    {
                        player4.money -= ��õ.basicprice;
                        player2.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player4.money -= ��õ.oneprice;
                        player2.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player4.money -= ��õ.twoprice;
                        player2.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player4.money -= ��õ.threeprice;
                        player2.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player4.money -= ��õ.landprice;
                        player2.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 3)
                {
                    if (��õ.house == 1)
                    {
                        player4.money -= ��õ.basicprice;
                        player3.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player4.money -= ��õ.oneprice;
                        player3.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player4.money -= ��õ.twoprice;
                        player3.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player4.money -= ��õ.threeprice;
                        player3.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player4.money -= ��õ.landprice;
                        player3.money += ��õ.landprice;
                    }
                }
                else if (��õ.host == 1)
                {
                    if (��õ.house == 1)
                    {
                        player4.money -= ��õ.basicprice;
                        player1.money += ��õ.basicprice;
                    }
                    else if (��õ.house == 2)
                    {
                        player4.money -= ��õ.oneprice;
                        player1.money += ��õ.oneprice;
                    }
                    else if (��õ.house == 3)
                    {
                        player4.money -= ��õ.twoprice;
                        player1.money += ��õ.twoprice;
                    }
                    else if (��õ.house == 4)
                    {
                        player4.money -= ��õ.threeprice;
                        player1.money += ��õ.threeprice;
                    }
                    else if (��õ.house == 5)
                    {
                        player4.money -= ��õ.landprice;
                        player1.money += ��õ.landprice;
                    }
                }
                UIScrean = false;

            }
            if (39 == distance4 % 40 && UIScrean)
            {
                if (����.host == 0 || ����.host == 4)
                {
                    ����Ǹ���.SetActive(true);
                }
                if (����.host == 2)
                {
                    if (����.house == 1)
                    {
                        player4.money -= ����.basicprice;
                        player2.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player4.money -= ����.oneprice;
                        player2.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player4.money -= ����.twoprice;
                        player2.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player4.money -= ����.threeprice;
                        player2.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player4.money -= ����.landprice;
                        player2.money += ����.landprice;
                    }
                }
                else if (����.host == 3)
                {
                    if (����.house == 1)
                    {
                        player4.money -= ����.basicprice;
                        player3.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player4.money -= ����.oneprice;
                        player3.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player4.money -= ����.twoprice;
                        player3.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player4.money -= ����.threeprice;
                        player3.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player4.money -= ����.landprice;
                        player3.money += ����.landprice;
                    }
                }
                else if (����.host == 1)
                {
                    if (����.house == 1)
                    {
                        player4.money -= ����.basicprice;
                        player1.money += ����.basicprice;
                    }
                    else if (����.house == 2)
                    {
                        player4.money -= ����.oneprice;
                        player1.money += ����.oneprice;
                    }
                    else if (����.house == 3)
                    {
                        player4.money -= ����.twoprice;
                        player1.money += ����.twoprice;
                    }
                    else if (����.house == 4)
                    {
                        player4.money -= ����.threeprice;
                        player1.money += ����.threeprice;
                    }
                    else if (����.house == 5)
                    {
                        player4.money -= ����.landprice;
                        player1.money += ����.landprice;
                    }
                }
                UIScrean = false;

            }
            if (4 == distance4 % 40 && UIScrean)
            {
                �糭ī��1.SetActive(true);
                UIScrean = false;
            }
            if (12 == distance4 % 40 && UIScrean)
            {
                �糭ī��2.SetActive(true);
                UIScrean = false;
            }
            if (28 == distance4 % 40 && UIScrean)
            {
                �糭ī��3.SetActive(true);
                UIScrean = false;
            }
            if (38 == distance4 % 40 && UIScrean)
            {
                �糭ī��4.SetActive(true);
                UIScrean = false;
            }
            if (5 == distance4 % 40 && UIScrean)
            {
                if (����.host == 0)
                {
                    ����1.SetActive(true);
                }
                else if (����.host == 1)
                {
                    player4.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host == 3)
                {
                    player4.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host == 2)
                {
                    player4.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                UIScrean = false;
            }
            if (15 == distance4 % 40 && UIScrean)
            {
                if (����.host2 == 0)
                {
                    ����2.SetActive(true);
                }
                else if (����.host2 == 1)
                {
                    player4.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host2 == 3)
                {
                    player4.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host2 == 2)
                {
                    player4.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                UIScrean = false;
            }
            if (25 == distance4 % 40 && UIScrean)
            {
                if (����.host3 == 0)
                {
                    ����3.SetActive(true);
                }
                else if (����.host3 == 1)
                {
                    player4.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host3 == 3)
                {
                    player4.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host3 == 2)
                {
                    player4.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                UIScrean = false;
            }
            if (35 == distance4 % 40 && UIScrean)
            {
                if (����.host4 == 0)
                {
                    ����4.SetActive(true);
                }
                else if (����.host4 == 1)
                {
                    player4.money -= ����.weapon1 * 100;
                    player1.money += ����.weapon1 * 100;
                }
                else if (����.host4 == 3)
                {
                    player4.money -= ����.weapon3 * 100;
                    player3.money += ����.weapon3 * 100;
                }
                else if (����.host4 == 2)
                {
                    player4.money -= ����.weapon2 * 100;
                    player2.money += ����.weapon2 * 100;
                }
                UIScrean = false;
            }
            if ((2 == distance4 % 40 || 17 == distance4 % 40 || 33 == distance4) && UIScrean)
            {
                ��ȸ���.SetActive(true);
                UIScrean = false;
            }
            if ((7 == distance4 % 40 || 22 == distance4 % 40 || 36 == distance4) && UIScrean)
            {
                ����ī��.SetActive(true);
                UIScrean = false;
            }
            if (30 == distance4 % 40 && UIScrean)
            {
                Ÿ�Ӹӽ�.SetActive(true);
                UIScrean = false;
            }
            if (�����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �����Ǹ���.SetActive(false);
                //UIScrean = true;
            }
            else if (���Ͽ����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���Ͽ����Ǹ���.SetActive(false);
            }
            else if (��������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��������Ǹ���.SetActive(false);
            }
            else if (���ε��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ε��Ǹ���.SetActive(false);
            }
            else if (�ζѸ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ζѸ��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�屺�ѱǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �屺�ѱǸ���.SetActive(false);
            }
            else if (���ɿո��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���ɿո��Ǹ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (÷����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ÷����Ǹ���.SetActive(false);
            }
            else if (�ұ���Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �ұ���Ǹ���.SetActive(false);
            }
            else if (���λ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���λ�Ǹ���.SetActive(false);
            }
            else if (ó�μ��Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ó�μ��Ǹ���.SetActive(false);
            }
            else if (õ���强�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                õ���强�Ǹ���.SetActive(false);
            }
            else if (�溹�ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �溹�ñǸ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (â���ñǸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                â���ñǸ���.SetActive(false);
            }
            else if (������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ������Ǹ���.SetActive(false);
            }
            else if (�������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �������Ǹ���.SetActive(false);
            }
            else if (���������Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ���������Ǹ���.SetActive(false);
            }
            else if (��õ�Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��õ�Ǹ���.SetActive(false);
            }
            else if (����Ǹ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����Ǹ���.SetActive(false);
            }
            else if (�糭ī��1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��1.SetActive(false);
            }
            else if (�糭ī��2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��2.SetActive(false);
            }
            else if (�糭ī��3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��3.SetActive(false);
            }
            else if (�糭ī��4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                �糭ī��4.SetActive(false);
            }
            else if (����1.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����1.SetActive(false);
            }
            else if (����2.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����2.SetActive(false);
            }
            else if (����3.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����3.SetActive(false);
            }
            else if (����4.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����4.SetActive(false);
            }
            else if (��ȸ���.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ��ȸ���.SetActive(false);
            }
            else if (����ī��.activeSelf == true)
            {
                yield return new WaitForSeconds(120f);
                ����ī��.SetActive(false);
            }
        }
    }
}