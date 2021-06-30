using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();

        
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        score = 0;
        Debug.Log("Welcome to NumberWizard, player.");
        Debug.Log("Choose a number, player. But keep it to yourself.");
        Debug.Log("The highest you can choose is: " + max + ".");
        Debug.Log("Do not choose lower than: " + min + ".");
        Debug.Log("Tell me if your number is higher or lower than: " + guess + ".");
        Debug.Log("Push Up Arrow if it's higher, or push Down Arrow if it's lower, push Enter if the guess is correct.");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("It only took me " + score + " tries!");
            StartGame();
            
        }   
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number higher or lower than " + guess + ".");
        score = score +1;
        
    }

}
