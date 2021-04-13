using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSteering : MonoBehaviour
{
    float speed;
    Vector3 oldPosition;
    void Start()
    {
        
    }
    public float maxSpeed = 1.0f;
    void FixedUpdate()
    {
        speed = Vector3.Distance(oldPosition, transform.position) * 100f;
        oldPosition = transform.position;
        Debug.Log("Speed: " + speed.ToString("F2"));
    }

    // Main movement loop
    void Update()     
    {
       
        //Load rigidbody2d as rb
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // Check for and set max speed
       if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        var carVelocity = rb.velocity;
        // Condition: when player presses D add force
        if (Input.GetKey(KeyCode.D) == true)
        {
            //Action: apply a force (move the player)
            // Get Rigidbody2d to use it

            // Add a force to the rigid body to move player
            rb.AddForce(Vector2.right * 10f);
        }

        // Condition: when player presses A add force
        if (Input.GetKey(KeyCode.A) == true)
        {
            //Action: apply a force (move the player)
            // Get Rigidbody2d to use it

            // Add a force to the rigid body to move player
            rb.AddForce(Vector2.left * 10f);

        }

        // Condition: when player presses W add force
        if (Input.GetKey(KeyCode.W) == true)
        {
            //Action: apply a force (move the player)
            // Get Rigidbody2d to use it

            // Add a force to the rigid body to move player
            rb.AddForce(Vector2.up * 10f);
        }

        // Condition: when player presses S add force
        if (Input.GetKey(KeyCode.S) == true)
        {
            //Action: apply a force (move the player)
            // Get Rigidbody2d to use it

            // Add a force to the rigid body to move player
            rb.AddForce(Vector2.down * 10f);
        }

    }
}
