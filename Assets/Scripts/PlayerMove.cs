using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 2.5f;
    public float jumpSpeed = 3.3f;
    private float xRange = 6.5f;
    private bool MovingLeft = false;
    private bool MovingRight = false;
    private bool onGround = true;
    public Animator animator;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component of this object
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Set the animation parameters
        animator.SetBool("MovingRight", MovingRight);
        animator.SetBool("MovingLeft", MovingLeft);

        // Move left
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-speed, 0));
            MovingRight = false;
            MovingLeft = true;
        }

        // Move right
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(speed, 0));
            MovingLeft = false;
            MovingRight = true;
        }

        //Jump
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKey("w")) && onGround)
        {
            // Add impulse force in Y direction
            rb.AddForce(new Vector2(0, jumpSpeed), ForceMode2D.Impulse);

            // No longer on ground
            onGround = false;
        }

        //If the player reaches the end of the map, wrap around to the other side
        if (transform.position.x > xRange)
        {
            rb.position = new Vector2(-xRange,-3);
        }
        else if (transform.position.x < -xRange)
        {
            rb.position = new Vector2(xRange, -3);
        }
    }

    // If character collides with object tagged "Ground" they can jump again.
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}
