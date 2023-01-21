using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    Animator animator;
    public float speed;
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        float verticalmovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(movement, verticalmovement, 0) * speed;

        Debug.Log(movement);
        
        if (movement == 0)
            animator.SetBool("IsRunning", false);
        else
            animator.SetBool("IsRunning", true);
        if (verticalmovement != 0)
            animator.SetBool("IsVertical", true);
        if (Input.GetKeyDown(KeyCode.A))
            sr.flipX = true;
        if (Input.GetKeyDown(KeyCode.D))
            sr.flipX = false;
        
       
    }

    
}
