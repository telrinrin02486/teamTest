using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButton : MonoBehaviour
{
    private Renderer _renderer;
    private bool lbutton;

    // Use this for initialization
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        lbutton = false;
        _renderer.material.EnableKeyword("_EMISSION"); //キーワードの有効化を忘れずに
        _renderer.material.SetColor("_EmissionColor", new Color(1, 1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            lbutton = !lbutton;
        }
        else if (lbutton)
        {
            _renderer.material.SetColor("_EmissionColor", new Color(0, 1, 1));
        }
        else _renderer.material.SetColor("_EmissionColor", new Color(1, 1, 1));
    }

}