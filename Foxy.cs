using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foxy : MonoBehaviour {

    
    public enum STATE           //foxyの現在のstate
    {
        CLOSE, OPEN_1, OPEN_2, OPEN_3, MAX
    };

    STATE nowState, preState;               //state管理
    Vector3 pos, rot;                       //transform管理
    static Vector3 CLOSEpos = new Vector3(-5.5f, 1.0f, 7.0f), CLOSErot = new Vector3(0.0f, 180.0f, 0.0f);
                   //OPE_1pos = new Vector3(,,), OPE_1rot = new Vector3(,,),
                   //OPE_2pos = new Vector3(,,), OPE_2rot = new Vector3(,,);        
    // Use this for initialization
    void Start ()
    {
        nowState = STATE.CLOSE;
        preState = STATE.CLOSE;
        pos = new Vector3();
        rot = new Vector3();

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}


    public  STATE GetState()
    {
        return nowState;
    }
}
