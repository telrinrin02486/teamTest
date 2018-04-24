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
    public string buttonName;
    private int buttonMax;
    private float span;
    private int count;
    // Use this for initialization
    private void Start()
    {
        Init();
        StartCoroutine(Logging());
    }

    //Update is called once per frame
    void Update() { }

    private void Init()
    {
        //各取得と初期化
        black = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
        green = new Vector4(0.0f, 1.0f, 0.0f, 1.0f);
        buttonMax = transform.childCount;
        btnsName = new string[buttonMax];
        btnImage = GetComponentsInChildren<Button>();
        colorBlock = new ColorBlock[buttonMax];
        buttonName = "NON";
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
        Debug.Log("init()");

        count = 0;
    }

    private IEnumerator Logging()
    {
        while (true)
        {
            if (!(string.Equals(GetBtnName(), "NON")))
            {
                Debug.Log("きた～！" + GetBtnName() + count);
                for (int i = 0; i < buttonMax; i++)
                {
                    if (GetBtnName() == btnsName[i])
                    {
                        //green
                        yield return new WaitForSeconds(span);
                        colorBlock[i].highlightedColor = green;
                        colorBlock[i].normalColor = green;
                        colorBlock[i].pressedColor = green;
                        btnImage[i].colors = colorBlock[i];
                        //black
                        yield return new WaitForSeconds(span);
                        colorBlock[i].highlightedColor = black;
                        colorBlock[i].normalColor = black;
                        colorBlock[i].pressedColor = black;
                        btnImage[i].colors = colorBlock[i];
                    }
                }
            }
            else
            {
                Debug.Log("なんでやねん" + GetBtnName() + count);
                yield return new WaitForSeconds(span);
            }
            count++;
        }
    }


    public void SetBtnName(string _name)
    {
        buttonName = _name;
    }

    public string GetBtnName()
    {
        return buttonName;
    }
}
