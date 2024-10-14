using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int min = 1;
    private int max = 100;
    private int guess;
    private int attempts = 0;

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            LowerGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            HigherGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckGuess();
        }
    }

    private void StartGame()
    {
        attempts = 0;
        // Initialize the guess to the midpoint of the range
        guess = (min + max) / 2;
        Debug.Log($"Welcome to the number guessing game! I'm thinking of a number between {min} and {max}. Is it {guess}?");
    }

    private void LowerGuess()
    {
        if (attempts < 5)
        {
            // Update the max value and recalculate the guess
            max = guess;
            guess = (min + max) / 2;
            attempts++;
            Debug.Log($"Is the number lower than {guess}?");
        }
        else
        {
            Debug.Log("I've reached the maximum number of attempts. You win!");
        }
    }

    private void HigherGuess()
    {
        if (attempts < 5)
        {
            // Update the min value and recalculate the guess
            min = guess + 1;
            guess = (min + max) / 2;
            attempts++;
            Debug.Log($"Is the number higher than {guess}?");
        }
        else
        {
            Debug.Log("I've reached the maximum number of attempts. You win!");
        }
    }

    private void CheckGuess()
    {
        if (attempts < 5)
        {
            Debug.Log("Is that correct? (yes/no)");
        }
        else
        {
            Debug.Log("I've reached the maximum number of attempts. You win!");
        }
    }
}

