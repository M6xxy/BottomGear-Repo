using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSteering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()     
    {
       
        //Load rigidbody2d as rb
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        var carVelocity = rb.velocity;
        print(carVelocity);
        // Condition: when player presses D add force
        if (Input.GetKey(KeyCode.D) == true)
        {
            //Action: apply a force (move the player)
            // Get Rigidbody2d to use it

            // Add a force to the rigid body to move player
            rb.AddForce(Vector2.right * 10f);
            transform.Rotate(Vector3.back * 1.1f );
        }

        // Condition: when player presses A add force
        if (Input.GetKey(KeyCode.A) == true)
        {
            //Action: apply a force (move the player)
            // Get Rigidbody2d to use it

            // Add a force to the rigid body to move player
            rb.AddForce(Vector2.left * 10f);
            transform.Rotate(Vector3.forward * 1.1f );

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
