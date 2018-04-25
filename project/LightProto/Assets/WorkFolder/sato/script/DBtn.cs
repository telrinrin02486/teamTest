using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBtn : MonoBehaviour {

    private Renderer _renderer;
    Color preColor,red,whith;
    bool btnSwitch;
    string myName;
	// Use this for initialization
	void Start ()
    {
        btnSwitch = false;
        myName = this.transform.name;
        _renderer = GetComponent<Renderer>();
        red = new Color(0, 1, 0);
        whith = new Color(1, 1, 1);
        preColor = _renderer.material.color;
        //_renderer.material.EnableKeyword("_EMISSION"); //キーワードの有効化
        //_renderer.material.DisableKeyword("_EMISSION"); //キーワードの無効化
    }
	
	// Update is called once per frame
	void Update () {

        if (myName == DBtnCtl.Instance.GetClickObj())
        {
            btnSwitch = !btnSwitch;
            if (btnSwitch)
            {
                switch (myName)
                {
                    case "R_dBtn":
                        _renderer.material.EnableKeyword("_EMISSION");
                        _renderer.material.SetColor("_EmissionColor", red);
                        break;
                    case "L_dBtn":
                        _renderer.material.EnableKeyword("_EMISSION");
                        _renderer.material.SetColor("_EmissionColor", red);
                        break;
                    case "R_lBtn":
                        _renderer.material.EnableKeyword("_EMISSION");
                        _renderer.material.SetColor("_EmissionColor", whith);
                        break;
                    case "L_lBtn":
                        _renderer.material.EnableKeyword("_EMISSION");
                        _renderer.material.SetColor("_EmissionColor", whith);
                        break;
                    default:
                        //何もしない
                        break;
                }
            }
            else
            {

                _renderer.material.SetColor("_EmissionColor", preColor);
                _renderer.material.DisableKeyword("_EMISSION");
            }
        }
    }
}
