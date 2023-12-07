using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;



public class MostraVida : MonoBehaviour
{
    public TMPro.TextMeshProUGUI textoVida;
    public TMPro.TextMeshProUGUI textoPonto;
    
    
    void Start()
    {
        textoVida.text = $"Vidas: {CheckpointSaver.Vidas}";
        textoPonto.text = $"Pontos: {CheckpointSaver.Points}";
       
    }

    void Update()
    {
        textoVida.text = $"Vidas: {CheckpointSaver.Vidas}";
        textoPonto.text = $"Pontos: {CheckpointSaver.Points}";
    }
}
