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

            rb.AddForce(transform.up * -speedForce);

        }

        rb.AddTorque(Input.GetAxis("Horizontal") * torqueForce * Time.deltaTime, ForceMode2D.Impulse);
    }
}
