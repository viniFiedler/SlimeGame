using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaPrincipal : MonoBehaviour
{
    public AudioSource gerudo;

    public void TocaGerudo()
    {
        gerudo.Play();
    }
        
}
