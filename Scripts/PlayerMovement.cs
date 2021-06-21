using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;
    public float runspeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool jumpSound = false;


    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("Is Jumping", true);

            if (!jumpSound)
            {
                FindObjectOfType<AudioManager>().Play("Jump");
                jumpSound = true;
            }
            
        }
        
    }
    public void OnLanding()
    {
        animator.SetBool("Is Jumping", false);
        FindObjectOfType<AudioManager>().Play("Land");
        jumpSound = false;
    }
    public void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
