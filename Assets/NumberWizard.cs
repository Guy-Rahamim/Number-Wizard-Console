using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
	int SecretNumber = 232;
		int guess = 500;
		int max = 1000;
		int min = 1;
    // Start is called before the first frame update
    void Start()
    {
		startGame();


    }

	void startGame()
	{
		guess = 500;
		max = 1000;
		min = 1;
		Debug.Log("Welcome to Number Wizard");
		Debug.Log("Please choose a number from the following range:");
		Debug.Log("Lowest: " + min);
		Debug.Log("Highest: " + max);
		max += 1;
	}
    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			nextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			nextGuess();
		}

		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("You are correct!");
		}

	}
	void nextGuess()
	{
		guess = (max + min) / 2;
		Debug.Log("Is it higher or lower than " + guess + "?");
		
	
	}
}
