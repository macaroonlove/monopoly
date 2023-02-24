using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 찬스카드 : MonoBehaviour
{
    // Start is called before the first frame update
    int 찬스;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void okbutton()
    {
        GameObject 찬스1 = GameObject.Find("UI모음").transform.Find("찬스1UI").gameObject;
        GameObject 찬스2 = GameObject.Find("UI모음").transform.Find("찬스2UI").gameObject;
        GameObject 찬스3 = GameObject.Find("UI모음").transform.Find("찬스3UI").gameObject;
        GameObject 찬스4 = GameObject.Find("UI모음").transform.Find("찬스4UI").gameObject;

        찬스 = Random.Range(1, 5);

        if(찬스 == 1)
        {
            찬스1.SetActive(true);
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (찬스 == 2)
        {
            찬스2.SetActive(true);
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (찬스 == 3)
        {
            찬스3.SetActive(true);
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
        else if (찬스 == 4)
        {
            찬스4.SetActive(true);
            if (gameObject.activeSelf == true)
                gameObject.SetActive(false);
        }
    }
}
