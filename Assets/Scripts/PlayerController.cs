using System;
using System.IO.IsolatedStorage;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
    public float speed = 2.0f;
    //private PlayerController controller;
    private Rigidbody2D rb;
    private Animator anim;
    private bool facingRight;

    void Awake()
    {
        //controller = new PlayerController();
    }

    void Start() {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        facingRight = true;
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        if (move != 0)
        {
            rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        float verticalSpeed = Math.Abs(rb.linearVelocity.y);
        if (Input.GetButton("Jump") && verticalSpeed < 0.01) {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 5.0f);
        }
        anim.SetBool("isJumping", verticalSpeed > 0.01);

        if (!facingRight && move > 0) Flip();
        if (facingRight && move < 0) Flip();
    }
    
    void Flip() {
        facingRight = !facingRight;  // Flip the boolean

        Vector3 localScale = transform.localScale; // Current pose
        localScale.x *= -1.0f;                     // Flip in x
        transform.localScale = localScale;         // Set new pose
    }
}