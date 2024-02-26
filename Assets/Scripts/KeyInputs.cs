using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float moveSpeed = 2f; // Adjust this value to set the speed of movement
    public float jumpPower = 6f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myRigidbody.velocity = Vector2.up * jumpPower;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = Vector2.right * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = Vector2.left * moveSpeed;
        }
    }
}