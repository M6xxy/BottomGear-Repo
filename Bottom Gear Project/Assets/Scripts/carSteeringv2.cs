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
        if (Input.GetKey(KeyCode.W) == true)
        {

            rb.AddForce(transform.up * speedForce);
            
        }
        if (Input.GetKey(KeyCode.S) == true)
        {

            rb.AddForce(transform.up * -speedForce / 3.33f);
            torqueForce = 1f;

        }
        else torqueForce = 1.5f;

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(torqueForce * Time.deltaTime, ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-torqueForce * Time.deltaTime, ForceMode2D.Impulse);
        }

        // While player holds S half turnrate
        
        else torqueForce = 1.5f;
        //  rb.AddTorque(Input.GetAxis("Horizontal") * torqueForce * Time.deltaTime, ForceMode2D.Impulse);
    }
}
