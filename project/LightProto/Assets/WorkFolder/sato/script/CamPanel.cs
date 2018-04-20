using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CamPanel : MonoBehaviour
{

    //各部屋の管理Dictionary
    public Dictionary<string, bool> dictionary = new Dictionary<string, bool>()
    {
        {"CAM1A", false},{"CAM1B", false},{"CAM1C", false},
        {"CAM2A", false},{"CAM2B", false},
        {"CAM4A", false},{"CAM4B", false},
        {"CAM3" , false},{"CAM5" , false},{"CAM6" , false},{"CAM7", false},
        {"end"  , false}
    };   
    
    
    // Use this for initialization
    void Start()
    {
        
    }

    void Update()
    {






    }

   
}