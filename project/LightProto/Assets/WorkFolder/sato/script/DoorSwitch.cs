﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    private Renderer    _renderer;
    private bool dSwitch;

    // Use this for initialization
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        dSwitch = false;
        _renderer.material.EnableKeyword("_EMISSION"); //キーワードの有効化を忘れずに
        _renderer.material.SetColor("_EmissionColor", new Color(1, 0, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(1))
        {
            dSwitch = !dSwitch;
        }
        else if (dSwitch)
        {
            _renderer.material.SetColor("_EmissionColor", new Color(0, 1, 0)); 
        }
        else _renderer.material.SetColor("_EmissionColor", new Color(1, 0, 0));
    }

}