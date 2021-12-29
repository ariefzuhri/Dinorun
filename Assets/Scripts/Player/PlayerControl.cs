using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float jumpForce = 9.0f;
    private bool canDoubleJump = true;
    private bool isGrounded = true;

    private Rigidbody2D rb;

    void Start()
    {
        canDoubleJump = true;
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                var velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
                canDoubleJump = true;
                isGrounded = false;
            }
            else
            {
                if (canDoubleJump)
                {
                    canDoubleJump = false;
                    var velocity = rb.velocity;
                    velocity.y = jumpForce;
                    rb.velocity = velocity;
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Floor" || collision.collider.tag == "Obstacle")
        {
            isGrounded = true;
        }
    }
}