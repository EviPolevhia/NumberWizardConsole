using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

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

        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("Please pick a number. Don't tell me what it is yet, that's the whole point of the game!");
        Debug.Log("The highest number you can select is: " + max + ".");
        Debug.Log("The lowest number you can select is: " + min + ".");
        Debug.Log("If you select anything outside of these bounds then please stop being mean to the poor program.");
        Debug.Log("Tell me if your number is higher or lower than " + guess + ".");
        Debug.Log("Press Up = Higher, Push Down = Lower, Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()

    {   //Detect when the Up key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pressed up, so I take it my guess was too low.");
            min = guess;
            NextGuess();
        }
        //Detect when the Down key is pressed down
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You pressed down, so it seems my guess was too high.");
            max = guess;
            NextGuess();
        }
        //Detect when the Return key is pressed down
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was pressed, so I was right! Behold, the power of the Number Wizard! ...Alright. So it took me a lot of guesses to get right. But what do you expect for a first time program?");
            StartGame();        
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess + "?");
    }
}
