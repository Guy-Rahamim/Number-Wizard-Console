using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour

{		int guess = 500;
		int max = 1000;
		int min = 1;
    // Start is called before the first frame update
    void Start()
    {

		Debug.Log("Welcome to Number Wizard");
		Debug.Log("Please choose a number from the following range:");
		Debug.Log("Lowest: " + min);
		Debug.Log("Highest: "+max);

    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Debug.Log("Up arrow is pressed");
			max = guess;
		}

		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Debug.Log("Down arrow is pressed");
			min = guess;
		}

		else if (Input.GetKeyDown(KeyCode.Return))
		{
			Debug.Log("Enter is pressed");
		}

	}
}
