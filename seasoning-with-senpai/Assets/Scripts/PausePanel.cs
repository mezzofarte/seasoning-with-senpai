using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    public GameObject pausePanel;

    [SerializeField] private GameObject gameControllerObject;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameControllerObject.GetComponent<GameController>().gameOver)
            {
                TogglePause();
            }
            else
            {
                if (isPaused)
                {
                    TogglePause();
                }
            }
        }
    }

    public void TogglePause()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            Time.timeScale = 0;
            pausePanel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
