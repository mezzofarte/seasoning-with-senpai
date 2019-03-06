using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private float score = 0;
    private int health = 3;
    public bool gameOver = false;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject gameOverPanel;

    void Awake()
    {
        playerObject.GetComponent<Player>().onPlayerDeath.AddListener(setGameOverPanelActive);
    }

    void Update()
    {
        if (!gameOver)
        {
            score += (Time.deltaTime * 4);
        }
    }

    public int getScore()
    {
        return (int)score;
    }

    public int getHealth()
    {
        return health;
    }

    void setGameOverPanelActive()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }
}
