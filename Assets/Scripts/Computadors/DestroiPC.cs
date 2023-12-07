using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiPC : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(CheckpointSaver.check_Point == 1)
        {
            Destroy(GameObject.Find("Parede01"));
        }
        if(CheckpointSaver.check_Point == 2)
        {
            Destroy(GameObject.Find("Parede02"));
        }
        if(CheckpointSaver.check_Point == 3)
        {
            Destroy(GameObject.Find("Parede03"));
        }
        if(CheckpointSaver.check_Point == 4)
        {
            Destroy(GameObject.Find("Parede04"));
        }
        Destroy(gameObject);
        
        
    }
}
