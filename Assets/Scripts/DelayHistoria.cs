using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class DelayHistoria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(voltaMenu());
    }

    private IEnumerator voltaMenu()
    {
        yield return new WaitForSeconds(46);
        SceneManager.LoadScene("Menu Principal", LoadSceneMode.Single);
    }

    public void SaiHistoria()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu Principal", LoadSceneMode.Single);
        }
    }
}
