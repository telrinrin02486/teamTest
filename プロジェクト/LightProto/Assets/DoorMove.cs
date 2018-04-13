using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    private GameObject leftDoor, rightDoor;
    private bool isMove;
	// Use this for initialization
	void Start ()
    {
        isMove = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(isMove && Input.GetMouseButton(0))
        {
           
        }
	}

    private void OnBecameInvisible()
    {
        isMove = false;
    }
    void OnBecameVisible()
    {
        isMove = true;
    }
}
