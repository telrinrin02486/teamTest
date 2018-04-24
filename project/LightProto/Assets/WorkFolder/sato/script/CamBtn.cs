using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CamBtn : MonoBehaviour
{

    private string myName;
    // Use this for initialization
    void Start()
    {
        myName = this.transform.name;
    }

    public void OnClick()
    {
        CamBtnCtl.Instance.SetBtnName(myName);
    }

}
