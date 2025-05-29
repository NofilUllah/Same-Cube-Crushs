using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class countdown: MonoBehaviour
{
    

    public float initialTime = 60; // Initial time in seconds, set in the Inspector
    public TextMeshProUGUI countdownText; // Reference to the TextMeshPro UI text component

    private float timeRemaining; // Remaining time, updated in Update()

    public bool gameIsRunning = true;

    public static countdown instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        timeRemaining = initialTime; // Set the initial time
        DisplayTime(timeRemaining); // Display the initial time

    }

    void Update()
    {
        if (gameIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime; // Reduce timeRemaining by the time passed since the last frame
                if (timeRemaining < 0)
                {
                    timeRemaining = 0; // Ensure the timer stops at 00:00
                    GameOver(); // Call a method to handle game over actions
                }
                DisplayTime(timeRemaining);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        // Convert the time in seconds to minutes and seconds
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        // Update the TextMeshPro UI text to show the time remaining
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void GameOver()
    {
        gameIsRunning = false;
        Time.timeScale = 0f; // Pause the game
        // Add any other game over actions here
    }
}