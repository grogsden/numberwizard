using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("Your number is higher than " + guess + ".");
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it..." + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Your number is lower than " + guess +".");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is it..." + guess + "?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Your number is " + guess +"!");
        }
        

    }
}
