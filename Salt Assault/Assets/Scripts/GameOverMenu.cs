using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    
    public void PlayAgain()
    {
        // Replace "Game" with name of first level
        // when game is complete
        //
        // SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
