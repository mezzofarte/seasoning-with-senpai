using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject steakPrefab;
    private int score = 0;
    public bool gameOver = false;
    [SerializeField] private GameObject playerObject;
    [SerializeField] private GameObject gameOverPanel;

    void Awake()
    {
        playerObject.GetComponent<Player>().onPlayerDeath.AddListener(setGameOverPanelActive);
    }

    void Update()
    {
    }

    public int getScore()
    {
        return score;
    }

    void setGameOverPanelActive()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }
    public void newSteak()
    {
        Instantiate(steakPrefab, new Vector3(26.2f, -6.9f, 46.9f),Quaternion.identity);
        score++;
    }
}
