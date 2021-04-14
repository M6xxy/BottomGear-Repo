using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Check if user is using Audio Source to run script
[RequireComponent(typeof(AudioSource))]
public class enginePitchv2: MonoBehaviour
{


    AudioSource audioSource2;
    public float carVelocityMagnitude;


    void Start()
    {
        //Get AudioSource from Player
        audioSource2 = GetComponent<AudioSource>();

    }


    void FixedUpdate()
    {
        ///////////////////////////////////////////////////////////
        // LOAD RIGIBODY 2D
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        carVelocityMagnitude = rb.velocity.magnitude;
        //set pitch varible 


        if (carVelocityMagnitude >= 0 && carVelocityMagnitude <= 8)
        {
            audioSource2.pitch = carVelocityMagnitude  / 2.6f;

        }
        if (carVelocityMagnitude > 8 && carVelocityMagnitude <= 15)
        {
            if (audioSource2.pitch < 2.9) 
            {
                audioSource2.pitch = carVelocityMagnitude / 4f;
            }

        }
        






        //////////////////////////////////////////////////////////
    }
}
