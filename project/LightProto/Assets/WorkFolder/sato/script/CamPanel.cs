using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamPanel : MonoBehaviour
{
    private Renderer _renderer;

    // Use this for initialization
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        StartCoroutine(BlinkerCoroutine());
    }

    void Update() { }

    IEnumerator BlinkerCoroutine()
    {
        //こちらは動く例
        //変更前のマテリアルのコピーを保存
        var originalMaterial = new Material(_renderer.material);
        while (true)
        {
            _renderer.material.SetColor("_EmissionColor", new Color(0, 1, 0));
            yield return new WaitForSeconds(1.0f); //1秒待って
            _renderer.material = originalMaterial; //元に戻す
            yield return new WaitForSeconds(1.0f); //また1秒待ってくりかえし
        }
    }
}