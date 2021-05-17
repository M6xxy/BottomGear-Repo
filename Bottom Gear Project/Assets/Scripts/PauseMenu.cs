using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    AudioSource audioSource2;
    // Start is called before the first frame update
    void Awake()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        audioSource2 = GetComponent<AudioSource>();
        carSteeringv2.raceWon = false;
    }

    // Update is called once per frame
    void Update()
    {   
        // if race isnt over allow pause menu
        if (carSteeringv2.raceWon == false)
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                if (isPaused)
                {
                    ResumeGame();
                    audioSource2.volume = 0.2f;
                }
                else
                {
                    PauseGame();
                    audioSource2.volume = 0f;

                }
            }
        }
        else
        {
            pauseMenu.SetActive(true);
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void goToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
