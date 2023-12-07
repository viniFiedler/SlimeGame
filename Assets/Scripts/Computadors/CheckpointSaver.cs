using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckpointSaver : MonoBehaviour
{
    // Start is called before the first frame update
    public static int check_Point = 1;
    public static int Points = 0;
    public static int Vidas = 3;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void fimDeJogo()
    {   
        check_Point = 1;
        Points = 0;
        Vidas = 3;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Destroy(gameObject);
        SceneManager.LoadScene("Fim", LoadSceneMode.Single);

         Debug.Log("HAHAHAHAHAHAHAH");
    }

    void Update()
    {

        if(CheckpointSaver.Vidas < 0)
        {
            fimDeJogo();
        }

        
    }
    // Update is called once per frame
}
