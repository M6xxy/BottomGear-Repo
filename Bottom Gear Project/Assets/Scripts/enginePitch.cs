using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Check if user is using Audio Source to run script
[RequireComponent(typeof(AudioSource))]
public class enginePitch : MonoBehaviour
{
    public float gear1 = 1f;
    public float gear2 = 1.3f;
    public float gear3 = 1.6f;
    public float gear4 = 1.8f;
    public float gear5 = 2.1f;

    AudioSource audioSource;
    

    void Start()
    {
        //Get AudioSource from Player
        audioSource = GetComponent<AudioSource>();

    }

    
    void Update()
    {
        ///////////////////////////////////////////////////////////
        // LOAD RIGIBODY 2D
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //set pitch varible 


        if (rb.velocity.magnitude >= 0 && rb.velocity.magnitude <= 1.5)
        {
            audioSource.pitch = gear1;

        }

        if (rb.velocity.magnitude > 1.5 && rb.velocity.magnitude <= 2)
        {
            audioSource.pitch = gear2;

        }
        if (rb.velocity.magnitude > 2 && rb.velocity.magnitude <= 2.5)
        {
            audioSource.pitch = gear3;

        }
        if (rb.velocity.magnitude > 2.5 && rb.velocity.magnitude <= 3)
        {
            audioSource.pitch = gear4;

        }
        if (rb.velocity.magnitude > 3 && rb.velocity.magnitude <= 5)
        {
            audioSource.pitch = gear5;

        }

        //////////////////////////////////////////////////////////
    }
}
