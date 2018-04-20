using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        switch (transform.name)
        {
            case "CAM1A":
                Debug.Log("1A");
                break;
            case "CAM1B":
                Debug.Log("1B");
                break;
            case "CAM1C":
                Debug.Log("1C");
                break;
            case "CAM2A":
                Debug.Log("2A");
                break;
            case "CAM2B":
                Debug.Log("2B");
                break;
            case "CAM4A":
                Debug.Log("4A");
                break;
            case "CAM4B":
                Debug.Log("4B");
                break;
            case "CAM3":
                Debug.Log("3");
                break;
            case "CAM5":
                Debug.Log("5");
                break;
            case "CAM6":
                Debug.Log("6");
                break;
            case "CAM7":
                Debug.Log("7");
                break;
            default:
                break;
        }
    }
}
