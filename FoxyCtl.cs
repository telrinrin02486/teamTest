﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxyCtl : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("state", 0);
	}
}
