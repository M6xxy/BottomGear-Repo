using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carSteeringv2 : MonoBehaviour
{
    AudioSource audioSource2;
    public float speedForce = 10f;
    public float turnForce = 10f;
    public int totalLaps = 0;
    public int maxLaps = 1;
    public Text lapCounterUI;
    public Text timeCounterUI;
    public Text winScreenUI;
    public float totalTime;
    public float timeFinished;
    public static bool raceWon;



    void Start()
    {
        audioSource2 = GetComponent<AudioSource>();
        lapCounterUI.text = "LAP " + totalLaps.ToString() + "/" + maxLaps.ToString();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Update UI Time Counter
        totalTime = Time.timeSinceLevelLoad;
        timeCounterUI.text = "TOTAL TIME: " + totalTime.ToString("F");
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

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
            turnForce = 1f;

        }
        else turnForce = 1.5f;

        // when player holds A add positive torque which turns left
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(turnForce * Time.deltaTime, ForceMode2D.Impulse);
        }

        // when player holds D add Negative torque which turns left
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(-turnForce * Time.deltaTime, ForceMode2D.Impulse);
        }
        
        
    }
    //ON TRIGGER LAP COUNT
    void OnTriggerExit2D(Collider2D collider)
    {
        totalLaps = totalLaps + 1;
        if (totalLaps < maxLaps)
        {
            lapCounterUI.text = "LAP " + totalLaps.ToString() + "/" + maxLaps.ToString();
            

        }
        // If player Finishes Race
        else if (totalLaps >= maxLaps )
        {
            // UPDATE UI TEXT
            lapCounterUI.text = "LAP " + totalLaps.ToString() + "/" + maxLaps.ToString();
            // TURN ON WIN UI
            winScreenUI.text = "YOU FINISHED THE RACE";
            // TURN OFF CAR VOLUME
            audioSource2.volume = 0f;
            // Pause Game
            Time.timeScale = 0f;
            // Set Race won as true for pause menu fix
            raceWon = true;

        }
    }
}
