using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolasScript : MonoBehaviour
{
    public float velocidade;
    private Rigidbody rigid;
    public Vector3 posicaoInicial ;


    private void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        posicaoInicial = transform.position;
        
    }

    private void Update()
    {
        rigid.AddForce(-Vector3.forward * velocidade);

        if(transform.position.y < -5f)
        {
            reseta();
            
        }
    }
    private void reseta()
    {
    
        GetComponent<Rigidbody>().velocity = Vector3.zero;
        GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        
        transform.position = posicaoInicial;
        velocidade = Random.Range(1f, 3f);

        if(CheckpointSaver.check_Point == 2)
        {
            transform.position = posicaoInicial + new Vector3(0,0,72);
        }

        if(CheckpointSaver.check_Point == 3)
        {
            transform.position = posicaoInicial + new Vector3(0,0,140);
        }

        
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "Trigger 01")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 02")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 03")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 04")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 05")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 06")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 07")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 08")
        {
            reseta();
        }
        if(col.gameObject.name == "Trigger 09")
        {
            reseta();
        }
    }
}
