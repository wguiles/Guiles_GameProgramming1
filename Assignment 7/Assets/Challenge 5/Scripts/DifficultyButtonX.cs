using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{

        		/*
		 * Warren Guiles
		 * DifficultyButtonX
		 * Assignment 7
		 * This script is called when the player clicks one of the
           buttons in the main menu of the script (which was caused
           by the add listener). This also sets the difficulty of the 
           game based on which button was pressed.
		 */
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    /* When a button is clicked, call the StartGame() method
     * and pass it the difficulty value (1, 2, 3) from the button 
    */
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + " was clicked");

        //set difficulty in the manager based on the difficulty variable.
        gameManagerX.SetNewDifficulty(difficulty);
        gameManagerX.StartGame();
 
    }
}
