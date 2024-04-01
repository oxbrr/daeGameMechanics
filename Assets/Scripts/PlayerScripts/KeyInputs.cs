using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float moveSpeed = 2f;
    public float jumpPower = 6f;
    private bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        // Check if the player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        // Debug log to check if the player is grounded
        Debug.Log("Grounded: " + isGrounded);

        if (Input.GetKeyDown(KeyCode.W) && isGrounded) // Only allow jumping when grounded
        {
            myRigidbody.velocity = Vector2.up * jumpPower;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = new Vector2(-moveSpeed, myRigidbody.velocity.y);
        }
        else
        {
            myRigidbody.velocity = new Vector2(0, myRigidbody.velocity.y);
        }

    }
}
