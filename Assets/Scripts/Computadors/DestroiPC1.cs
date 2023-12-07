using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroiPC1 : MonoBehaviour
{   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void fimDeJogo()
    {   
        Destroy(GameObject.Find("Deus"));

        SceneManager.LoadScene("Ganhou", LoadSceneMode.Single);

        Debug.Log("HAHAHAHAHAHAHAH");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        
        fimDeJogo(); 
        
    }
}
