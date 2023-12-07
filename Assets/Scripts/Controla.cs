using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Controla : MonoBehaviour
{

    public void FechaJogo()
    {
        Application.Quit();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void CarregaJogo()
    {
        SceneManager.LoadScene("Fase Principal", LoadSceneMode.Single);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
