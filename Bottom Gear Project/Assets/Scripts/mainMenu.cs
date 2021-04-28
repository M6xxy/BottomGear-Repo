using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Start game by level 1
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MonzaLoad()
    {
        SceneManager.LoadScene("MONZA LEVEL");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
        carSteeringv2.raceWon = false;
    }
}
