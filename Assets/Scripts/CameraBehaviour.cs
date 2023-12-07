using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    ThirdPersonMovement myObject;

    void Start()
    {
        myObject = GameObject.FindObjectOfType<ThirdPersonMovement>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }   
}
