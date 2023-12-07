using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float velocidade = 6f;
    public float tempoSuave = 0.1f;
    
    private Animator animator;
    private AudioSource audioSource;

    float velocidadeSuave;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }
    
    /*
    public void TeleportCamera(Vector3 newPosition)
    {
        CinemachineVirtualCameraBase vcamBase = CinemachineCore.Instance.GetVirtualCamera(10);
        CinemachineVirtualCamera vcam = vcamBase as CinemachineVirtualCamera;
        vcam.transform.position = new Vector3(newPosition.x, newPosition.y, vcam.transform.position.z);
    }
    */

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        

        Vector3 direcao = new Vector3(horizontal, 0f, vertical).normalized;

        if(direcao.magnitude >= 0.1f)
        {
            animator.SetBool("IsMoving", true);
            float anguloAlvo = Mathf.Atan2(direcao.x, direcao.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angulo = Mathf.SmoothDampAngle(transform.eulerAngles.y, anguloAlvo, ref velocidadeSuave, tempoSuave);
            transform.rotation = Quaternion.Euler(0f, angulo, 0f);
            
            Vector3 direcaoMov = Quaternion.Euler(0f, anguloAlvo, 0f) * Vector3.forward;
            controller.Move(direcaoMov.normalized * velocidade * Time.deltaTime);
            controller.Move(new Vector3(0,0,0));
        }
        else
        {
            animator.SetBool("IsMoving", false);
        }

        if(transform.position.y < -5f)
        {
            mortePlayer();
        }
        if(transform.position.z > 75)
        {
            CheckpointSaver.check_Point = 2;
        }
        if(transform.position.z > 136)
        {
            CheckpointSaver.check_Point = 3;
        }

        if(transform.position.z > 200)
        {
            CheckpointSaver.check_Point = 4;
        }


        
    }

    void mortePlayer()
    {
        
        CheckpointSaver.Vidas = CheckpointSaver.Vidas - 1;
        if(CheckpointSaver.Vidas >= 0)
        {
            if(CheckpointSaver.check_Point == 1)
            {
                transform.position = new Vector3(10, 1, 3);
                
               // TeleportCamera(new Vector3(10, 1, 3));
                //Destroy(controller);
                // Usar instantiate;
            }
            else if(CheckpointSaver.check_Point == 2)
            {
                transform.position = new Vector3(10, 1, 71);
            }
            else if(CheckpointSaver.check_Point == 3)
            {
                transform.position = new Vector3(10, 1, 139);
            }

            else
            {
                transform.position = new Vector3(10, 1, 210);
            }
        }
        else
        {
            Debug.Log("PERDEU");
        }
        audioSource.Play();
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Bola 01")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 02")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 03")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 04")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 05")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 06")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 07")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 08")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Bola 09")
        {
            mortePlayer();
        }
        if(col.gameObject.name == "Computador")
        {
            SceneManager.LoadScene("PC01", LoadSceneMode.Additive);
        }
        //if(col.gameObject.name == "")
    }
}
