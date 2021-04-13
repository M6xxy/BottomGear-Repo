using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Check if user is using Audio Source to run script
[RequireComponent(typeof(AudioSource))]
public class enginePitch : MonoBehaviour
{
    public float strtPitch = 0;
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


        if (rb.velocity.magnitude > 0.7 && rb.velocity.magnitude <= 1.5)
        {
            audioSource.pitch = 1;

        }
        else if (rb.velocity.magnitude > 1.5 && rb.velocity.magnitude < 2.5)
        {
            audioSource.pitch = 2;
        }
        else audioSource.pitch = 3;

        //////////////////////////////////////////////////////////
    }
}
