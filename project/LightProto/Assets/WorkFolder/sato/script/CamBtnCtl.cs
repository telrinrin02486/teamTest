using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class CamBtnCtl : Singleton<CamBtnCtl>
{
    private string[] btnsName;
    private Button[] btnImage;
    private ColorBlock[] colorBlock;
    private Vector4 green, black;
    public string nowBtnName, preBtnName;
    private int buttonMax;
    Coroutine coroutine;
    private float span;
 
    // Use this for initialization
    private void Start()
    {
        Init();
        coroutine = StartCoroutine(Logging());
    }

    //Update is called once per frame
    void Update()
    {
        preBtnName = nowBtnName;
    }

    private void Init()
    {
        //各取得と初期化
        black = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
        green = new Vector4(0.0f, 1.0f, 0.0f, 1.0f);
        buttonMax = transform.childCount;
        btnsName = new string[buttonMax];
        btnImage = GetComponentsInChildren<Button>();
        colorBlock = new ColorBlock[buttonMax];
        nowBtnName = "CAM1A";
        preBtnName = nowBtnName;
        span = 1.0f;
        foreach (Transform child in transform)
        {
            btnsName[child.GetSiblingIndex()] = child.name;
        }

        //button初期colorset
        for (int i = 0; i < buttonMax; i++)
        {
            colorBlock[i] = btnImage[i].colors;
            colorBlock[i].highlightedColor = black;
            colorBlock[i].normalColor = black;
            colorBlock[i].pressedColor = black;
            btnImage[i].colors = colorBlock[i];
        }
        
    }

    private IEnumerator Logging()
    {
        while (true)
        {
            //Debug.Log("start" + GetBtnName());
            for (int i = 0; i < buttonMax; i++)
            {
                if (nowBtnName == btnsName[i])
                {
                    Debug.Log("きた～！" + GetBtnName());
                    //green
                    colorBlock[i].highlightedColor = green;
                    colorBlock[i].normalColor = green;
                    colorBlock[i].pressedColor = green;
                    btnImage[i].colors = colorBlock[i];
                    yield return new WaitForSeconds(span);
                    //black
                    colorBlock[i].highlightedColor = black;
                    colorBlock[i].normalColor = black;
                    colorBlock[i].pressedColor = black;
                    btnImage[i].colors = colorBlock[i];
                    yield return new WaitForSeconds(span);

                    if (preBtnName != nowBtnName)
                    {
                       
                        StopCoroutine(coroutine);
                    }
                }
            }
            //Debug.Log("end" + GetBtnName());
        }
    }


    public void SetBtnName(string _name)
    {
        nowBtnName = _name;
    }

    public string GetBtnName()
    {
        return nowBtnName;
    }
}
