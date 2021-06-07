﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float runSpeed= 2;
    public float jumpSpeed= 3;

    Rigidbody2D rb2d;

    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate(){
        if(Input.GetKey("d")||Input.GetKey("right"))
        {
            rb2d.velocity= new Vector2(runSpeed, rb2d.velocity.y);
        }
        else if(Input.GetKey("a")||Input.GetKey("left"))
        {
            rb2d.velocity= new Vector2(-runSpeed, rb2d.velocity.y);

        }
        
        else
        {
            rb2d.velocity=new Vector2(0, rb2d.velocity.y);
        }

        if(Input.GetKey("w")&& checkGnd.isGrounded)
        {
            rb2d.velocity= new Vector2(rb2d.velocity.x, jumpSpeed);

        }
    }
}