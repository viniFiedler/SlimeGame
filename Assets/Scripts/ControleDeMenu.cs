using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ControleDeMenu : MonoBehaviour
{

    public void FechaJogo()
    {
        Application.Quit();
    }

    public void CarregaJogo()
    {
        SceneManager.LoadScene("Fase Principal", LoadSceneMode.Single);
    }

    public void CarregaInstrucoes()
    {
        SceneManager.LoadScene("ComoJogar", LoadSceneMode.Single);
    }

    public void CarregaHistoria()
    {
        SceneManager.LoadScene("Historia", LoadSceneMode.Single);
    }

    public void CarregaMenu()
    {
        SceneManager.LoadScene("Menu Principal", LoadSceneMode.Single);
    }
}
