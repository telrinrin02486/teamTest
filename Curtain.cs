using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curtain : MonoBehaviour {

    Vector3 rRot,lRot;       //transform管理
    static Vector3 CLOSE_rRot = new Vector3(-90.0f, -16.0f, 0.0f), CLOSE_lRot = new Vector3(-90.0f, -18.0f, 0.0f);
    static Vector3 OPEN_1rRot = new Vector3(-90.0f, -25.0f, 0.0f), OPEN_1lRot = new Vector3(-90.0f, -2.0f, 0.0f);
    static Vector3 OPEN_2rRot = new Vector3(-90.0f, -30.0f, 0.0f), OPEN_2lRot = new Vector3(-90.0f, 5.0f, 0.0f);
    
    //Foxy.STATE nowState,preState;
    void Start ()
    {
        //_foxy = ;
        rRot = new Vector3();
        lRot = new Vector3();
        //nowState = Foxy.STATE.CLOSE;
        //preState = Foxy.STATE.CLOSE;
    }

   
    
     void Update()
    {
        //nowState = _foxy.GetState();
        //if (nowState != preState)
        //{
        //    switch (nowState)
        //    {
        //        case Foxy.STATE.CLOSE:
        //            break;
        //        case Foxy.STATE.OPEN_1:
        //            break;
        //        case Foxy.STATE.OPEN_2:
        //            break;
        //        case Foxy.STATE.OPEN_3:
        //            break;
        //        case Foxy.STATE.MAX:
        //            break;
        //        default:
        //            break;
        //    }
        //}
        //preState = nowState;
     }


}
