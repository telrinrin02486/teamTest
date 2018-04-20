using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private GameObject  camPanel;
    private CamPanel    script;
    private string      preElm;     //前回の要素数


    /// ボタンをクリックした時の処理
     void Start()
    {
        preElm = "end";
    }

public void OnClick()
    {
        if (preElm != transform.name)
        {
            camPanel = GameObject.Find("camPanel");          //Unityちゃんをオブジェクトの名前から取得して変数に格納する
            script = camPanel.GetComponent<CamPanel>();      //unitychanの中にあるUnityChanScriptを取得して変数に格納する


            //全体のflagを初期化
            List<string> keyList = new List<string>(script.dictionary.Keys);
            foreach (string key in keyList)
            {
                script.dictionary[key] = false;
            }

            script.dictionary[transform.name] = true;   //今回の要素をture
            preElm = transform.name;                    //前回の要素番号を記録
            foreach (KeyValuePair<string, bool> pair in script.dictionary)
            {
                Debug.Log(string.Format("Key : {0} / Value : {1}", pair.Key, pair.Value));
            }
        }
    }
}
