using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reny1Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    CharacterController characterController;
    void Start()
    {
        anim = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        //Animation Controller parameters for the character
        anim.SetBool("isDef", false);
        anim.SetBool("isDancing", false);
        anim.SetBool("isWalking", false);
        //Time to start the animation
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isDef", true);
            anim.SetBool("isWalking", true);
            anim.SetBool("isDancing", false);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isDancing", true);
            anim.SetBool("isDef", true);
            anim.SetBool("isWalking", false);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isDancing", true);
            anim.SetBool("isDef", false);
        }
    }
}
