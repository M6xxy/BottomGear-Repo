using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSteeringv2 : MonoBehaviour
{
    public float speedForce = 10f;
    public float torqueForce = 10f;
    void Start()
    {
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        print(rb.velocity.magnitude);
        // when player holds W give positive speed * speed multiplier 
        if (Input.GetKey(KeyCode.W) == true)
        {

            rb.AddForce(transform.up * speedForce);
            
        }
        // when player holds S give negative speed
        if (Input.GetKey(KeyCode.S) == true)
        {
            
            rb.AddForce(transform.up * -speedForce / 3.33f);
            // if player holds S slow down turning speed
            torqueForce = 1f;

        }
        else torqueForce = 1.5f;

        // when player holds A add positive torque which turns left
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(torqueForce * Time.deltaTime, ForceMode2D.Impulse);
        }

        // when player holds D add Negative torque which turns left
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-torqueForce * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}
