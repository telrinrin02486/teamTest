using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBtnCtl : Singleton<DBtnCtl>
{

    //private string objName;
	// Use this for initialization
	void Start () {
      

    }

    // Update is called once per frame
     void Update () {

      
    }

    public string GetClickObj()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                return hit.collider.gameObject.transform.name;
            }
            else
            {
                return "NON";
            }
        }
        else {
            return "NON";
        }
    }

    //private void SetobjName(string _name)
    //{
    //    objName = _name;
    //}
}
