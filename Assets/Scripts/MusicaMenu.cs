using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaMenu : MonoBehaviour
{
    public AudioSource BG;
    public AudioSource conan;

    public void tocaBG()
    {
        BG.Play();
    }

    public void tocaConan()
    {
        conan.Play();
    }
}
